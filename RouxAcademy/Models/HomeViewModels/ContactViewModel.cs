using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RouxAcademy.Models.HomeViewModels
{
    public class ContactViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Questions and Comments")]
        public string Comments { get; set; }

    }
}