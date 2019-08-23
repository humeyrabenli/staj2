﻿using System.ComponentModel.DataAnnotations;

namespace Abis.Mbs.MvcWebUI.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }       
        [Required]
        public string Email { get; set; }

    }
}
