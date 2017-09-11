using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxApplication.Models
{
    public class UserContext:DbContext
    {
        public DbSet<Users> UserEntries { get; set; }

    }
}