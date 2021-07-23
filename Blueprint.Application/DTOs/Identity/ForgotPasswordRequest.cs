﻿using System.ComponentModel.DataAnnotations;

namespace Blueprint.Application.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}