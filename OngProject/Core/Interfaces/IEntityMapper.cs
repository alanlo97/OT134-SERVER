﻿using OngProject.Core.Models.DTOs;
using OngProject.Entities;

namespace OngProject.Core.Interfaces
{
    public interface IEntityMapper
    {
        OrganizationDTO OrganizationToOrganizationDto(Organization organization);
        UserDTO UserToUserDto(User user);
        UserDetailDto UserToUserDetailDto(User user);
        User UserRegisterDtoToUser(UserRegisterDto dto);
        SlideDtoForDisplay SlideToSlideDtoForDisplay(Slides slides);
        Slides SlideDtoForUploadToSlide(SlideDtoForUpload slideDto);
        ContactDTO ContactToContactDTO(Contacts contacts);
        Contacts ContactDTOToContact(ContactDTO contactsDto);
        CommentDtoForDisplay CommentToCommentDtoForDisplay(Comment comment);
        Comment CommentForRegisterToComment(CommentDtoForRegister commentDto);
        CategoryDtoForDisplay CategoryToCategoryDtoForDisplay(Category category);
        Category CategoryDtoForRegisterToCategory(CategoryDTOForRegister category);
        New NewDtoForUploadtoNew(NewDtoForUpload newDTO);
        NewDtoForDisplay NewtoNewDtoForDisplay(New newvar);
        Activities ActivityDTOForRegister(ActivityDTOForRegister dto);
        ActivityDTOForDisplay ActivityForActivityDTODisplay(Activities dto);
        TestimonialDTO TestimonialToTestimonialDTO(Testimonials testimonial);
        Testimonials TestimonialDTOToTestimonial(TestimonialDTO testimonialDTO);
        TestimonialDTODisplay TestimonialDTOToTestimonialDisplay(TestimonialDTO testimonalDTO);
        MemberDTORegister MemberToMemberDTO(Member member);
        MemberDTODisplay MemberToMemberDTODisplay(Member member);
        Member MemberDTORegisterToMember(MemberDTORegister memberDTO);
    }
}