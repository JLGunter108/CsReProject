﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCWebApp.Models;

namespace MVCWebApp.Data
{
    public class MVCWebAppContext : DbContext
    {
        public MVCWebAppContext (DbContextOptions<MVCWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MVCWebApp.Models.User> User { get; set; } = default!;

        public DbSet<MVCWebApp.Models.Post> Post { get; set; }
    }
}
