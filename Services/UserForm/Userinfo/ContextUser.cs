﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userinfo
{
    public class ContextUser:DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
