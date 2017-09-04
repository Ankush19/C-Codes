using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ValidationDemo.Models
{
    public class RegisterContext:DbContext
    {
        public DbSet<Register> Entries { get; set; }

    }
}