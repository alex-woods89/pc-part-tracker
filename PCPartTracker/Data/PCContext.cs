using Microsoft.EntityFrameworkCore;
using PCPartTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCPartTracker.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Case> Cases { get; set; }

        public DbSet<CPU> CPUs { get; set; }

        public DbSet<Harddrive> Harddrives { get; set; }

        public DbSet<Motherboard> Motherboards { get; set; }

        public DbSet<PSU> PSUs { get; set; }

        public DbSet<RAM> RAMs { get; set; }

        public DbSet<PC> PCs { get; set; }

        public DbSet<GPU> GPUs { get; set; }
    }
}
