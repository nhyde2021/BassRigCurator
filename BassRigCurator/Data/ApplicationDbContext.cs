using BassRigCurator.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BassRigCurator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Bass> Basses { get; set; }
        public DbSet<Amp> Amps { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
