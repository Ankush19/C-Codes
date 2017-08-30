using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userinfo
{
    public class User
    {
        [Key]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
