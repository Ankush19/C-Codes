using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationDemo.Models
{
    public class Login
    {
        [Key]
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}