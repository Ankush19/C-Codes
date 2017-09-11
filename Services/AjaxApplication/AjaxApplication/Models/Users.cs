using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjaxApplication.Models
{
    public class Users
    {
        [Key]
        public int MyID { get; set; }
        public string Name { get; set; }
    }
}