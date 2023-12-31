﻿using API.Utilities.Enums;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Accounts
{
    public class NewAccountDto
    {
        [Required]
        public Guid Guid { get; set; }
        [Required]
        [PasswordPolicy]
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public int Otp { get; set; }
        public bool IsUsed { get; set; }
        public DateTime ExpiredTime { get; set; }
        
    }
}
