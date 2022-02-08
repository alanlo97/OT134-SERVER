﻿using OngProject.Core.Helper;
using OngProject.Core.Interfaces;
using OngProject.Core.Mapper;
using OngProject.Core.Models.DTOs;
using OngProject.Core.Models.Response;
using OngProject.Entities;
using OngProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OngProject.Core.Business
{
    public class TestimonialsService : ITestimonialsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly EntityMapper _mapper;
        private readonly ImageService _imageService;

        public TestimonialsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = new EntityMapper();
            _imageService = new ImageService(_unitOfWork);
        }

        public IEnumerable<Testimonials> GetAll()
        {
            throw new NotImplementedException();
        }

        public Testimonials GetById()
        {
            throw new NotImplementedException();
        }

        public async Task<Result> Insert(TestimonialDTO testimonialDTO)
        {
            try
            {
                var testimonial = _mapper.TestimonialDTOToTestimonial(testimonialDTO);

                var resultName = await _unitOfWork.TestimonialsRepository.FindByConditionAsync(x => x.Name == testimonialDTO.Name);

                if (resultName.Count == 0)
                {
                    var aws = new S3AwsHelper();
                    var result = await _imageService.UploadFile($"{Guid.NewGuid()}{testimonialDTO.File.FileName}", testimonialDTO.File);

                    testimonial.Image = result;
                    testimonial.SoftDelete = false;
                    testimonial.LastModified = DateTime.Now;

                    await _unitOfWork.TestimonialsRepository.Create(testimonial);
                    await _unitOfWork.SaveChangesAsync();

                    var testimonialDisplay = _mapper.TestimonialDTOToTestimonialDisplay(testimonialDTO);
                    testimonialDisplay.Image = result;

                    return Result<TestimonialDTODisplay>.SuccessResult(testimonialDisplay);
                }
                else
                {
                    throw new Exception("El nombre del testimonio ya existe en el sistema, intente uno diferente al ingresado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Testimonio no registrado: " + ex.Message);
            }
        }

        public void Update(Testimonials testimonials)
        {
            throw new NotImplementedException();
        }

        public async Task<Result> Delete(int id)
        {
            try
            {
                var testimonial = await _unitOfWork.TestimonialsRepository.GetByIdAsync(id);
                if (testimonial is not null)
                {
                    if (testimonial.SoftDelete)
                        return Result.FailureResult("El testimonio ya se encuentra eliminado del sistema");

                    testimonial.SoftDelete = true;
                    testimonial.LastModified = DateTime.Now;
                    await this._unitOfWork.SaveChangesAsync();

                    var testimonialDTO = _mapper.TestimonialToTestimonialDTO(testimonial);

                    return Result<string>.SuccessResult("Testimonio eliminado.");
                }

                return Result.FailureResult("No existe un testimonio con ese Id");
            }
            catch (Exception ex)
            {
                return Result.ErrorResult(new List<string> { ex.Message });
            }
        }
    }
}
