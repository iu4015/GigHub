﻿using System.ComponentModel.DataAnnotations;

namespace GigHubMVC.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
