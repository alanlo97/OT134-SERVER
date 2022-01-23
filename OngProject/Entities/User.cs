﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OngProject.Entities
{
    public class User : EntityBase
    {
        [Required(ErrorMessage = "The First Name Is Required")]
        [StringLength(maximumLength: 255, ErrorMessage = "The First Name Is Too Long")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The Last Name Is Required")]
        [StringLength(maximumLength: 255, ErrorMessage = "The Last Name Is Too Long")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "The Email Is Required")]
        [StringLength(maximumLength: 320, ErrorMessage = "The Email Is Too Long")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The Password Is Required")]
        [StringLength(maximumLength: 20, ErrorMessage = "The Password Is Too Long")]
        public string Password { get; set; }
        [Required(ErrorMessage = "The Photo Is Required")]
        [StringLength(maximumLength: 255, ErrorMessage = "The Photo Is Too Long")]
        public string Photo { get; set; }
    }
}