﻿using OngProject.Core.Interfaces;
using OngProject.Core.Models.DTOs;
using OngProject.Entities;

namespace OngProject.Core.Mapper
{
    public class EntityMapper : IEntityMapper
    {
        public OrganizationDTO OrganizationToOrganizationDto(Organization organization)
        {
            var organizationDto = new OrganizationDTO
            {
                Name = organization.Name,
                Image = organization.Image,
                Phone = organization.Phone,
                Address = organization.Address,
                FacebookUrl = organization.FacebookUrl,
                InstagramUrl = organization.InstagramUrl,
                LinkedinUrl = organization.LinkedinUrl
            };
            return organizationDto;
        }

        public UserDTO UserToUserDto(User user)
        {
            var userDto = new UserDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
            return userDto;
        }

        public UserDetailDto UserToUserDetailDto(User user)
        {
            return new UserDetailDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Photo = user.Photo,
                RolId = user.RolId
            };
        }

        public User UserRegisterDtoToUser(UserRegisterDto dto)
        {
            return new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Password = dto.Password,
                RolId = dto.RolId
            };
        }
        public SlideDtoForDisplay SlideToSlideDtoForDisplay(Slides slides)
        {
            var slideDto = new SlideDtoForDisplay
            {
                Order = slides.Order,
                ImageUrl = slides.ImageUrl,
            };
            return slideDto;
        }

        public Slides SlideDtoForUploadToSlide(SlideDtoForUpload slideDto)
        {
            var slide = new Slides
            {
                Order = slideDto.Order,
                Text = slideDto.Text,
                OrganizationId = slideDto.OrganizationId
            };
            return slide;
        }


        public ContactDTO ContactToContactDTO(Contacts contacts)
        {
            var contactDto = new ContactDTO
            {
                Email = contacts.Email,
                Message = contacts.Message,
                Name = contacts.Name,
                Phone = contacts.Phone
            };
            return contactDto;
        }
        public Contacts ContactDTOToContact(ContactDTO contactsDto)
        {
            var contacts = new Contacts
            {
                Email = contactsDto.Email,
                Message = contactsDto.Message,
                Name = contactsDto.Name,
                Phone = contactsDto.Phone
            };
            return contacts;
        }
        public CommentDTO CommentToCommentDTO(Comment comment)
        {
            var commentDTO = new CommentDTO
            {
                Body = comment.Body
            };
            return commentDTO;
        }
        public CategoryDtoForDisplay CategoryToCategoryDtoForDisplay(Category category)
        {
            var categoryDtoForDisplay = new CategoryDtoForDisplay
            {
                Name = category.Name,
            };
            return categoryDtoForDisplay;
        }
        public Category CategoryDtoForRegisterToCategory(CategoryDTOForRegister category)
        {
            var categoryEntity = new Category
            {
                Name = category.Name,
                Description = category.Description,
                Image = category.Image,
            };
            return categoryEntity;
        }

        public Comment CommentDTOToComment(CommentDTO dto)
        {
            var commetn = new Comment
            {
                Body = dto.Body,
                NewId = dto.NewId,
                UserId = dto.UserId
            };
            return commetn;
        }

        public ActivityDTOForDisplay ActivityForActivityDTODisplay(Activities dto)
        {
            var activityDisplay = new ActivityDTOForDisplay
            {
                 Name=dto.Name,
                 Content = dto.Content,
                 Image = dto.Image
            };
            return activityDisplay;
        }
        public Activities ActivityDTOForRegister(ActivityDTOForRegister dto)
        {
            var activityRegister = new Activities
            {
                Name = dto.Name,
                Content = dto.Content
            };
            return activityRegister;
        }
        public New NewDtoForUploadtoNew(NewDtoForUpload newDtoForUpload)
        {
            New newEntity = new()
            {
                Name = newDtoForUpload.Name,
                Content = newDtoForUpload.Content,
                CategoryId = newDtoForUpload.Category
            };
            return newEntity;
        }
        public NewDtoForDisplay NewtoNewDtoForDisplay(New newEntity)
        {
            NewDtoForDisplay newEntityForDisplay = new()
            {
                Name = newEntity.Name,
                Content = newEntity.Content,
                Image = newEntity.Image,
                Category = newEntity.CategoryId
            };
            return newEntityForDisplay;
        }
        public Member MemberDTOToMember(MemberDTO memberDTO)
        {
            var member = new Member
            {
                Name = memberDTO.Name,
                Description = memberDTO.Description,
                Image = memberDTO.File.FileName,
            };
            return member;
        }
        public Testimonials TestimonialDTOToTestimonial(TestimonialDTO testimonialDTO)
        {
            var testimonial = new Testimonials
            {
                Name = testimonialDTO.Name,
                Content = testimonialDTO.Content,
                Image = testimonialDTO.File.FileName,
            };
            return testimonial;
        }

        public TestimonialDTO TestimonialToTestimonialDTO(Testimonials testimonial)
        {
            var testimonialDTO = new TestimonialDTO
            {
                Name = testimonial.Name,
                Content = testimonial.Content,
            };
            return testimonialDTO;
        }
        public MemberDTORegister MemberToMemberDTO(Member member)
        {
            var memberDTO = new MemberDTORegister
            {
                Name = member.Name,
                Description = member.Description,
            };
            return memberDTO;
        }

        public MemberDTODisplay MemberToMemberDTODisplay(Member member)
        {
            var memberDTO = new MemberDTODisplay
            {
                Name = member.Name,
                Description = member.Description,
                Image = member.Image,
            };
            return memberDTO;
        }

        public Member MemberDTORegisterToMember(MemberDTORegister memberDTO)
        {
            var member = new Member
            {
                Name = memberDTO.Name,
                Description = memberDTO.Description,
            };
            return member;
        }
    }
}