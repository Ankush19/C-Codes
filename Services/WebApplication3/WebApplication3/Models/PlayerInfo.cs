using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class PlayerInfo
    {
        [Key]
        public int JNo { get; set; }
        public string PName { get; set; }
        public int Goals { get; set; }
    }
}