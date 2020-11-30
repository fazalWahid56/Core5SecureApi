﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace App.Identity
{
    public class IdentityContext : IdentityDbContext
    {
        public IdentityContext(DbContextOptions options) : base(options)
        { }

        // public DbSet<Employee> Employees { get; set; }
    }
}