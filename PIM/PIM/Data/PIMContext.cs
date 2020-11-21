using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PIM.Models;

namespace PIM.Data
{
    public class PIMContext : DbContext
    {
        public PIMContext(DbContextOptions<PIMContext> options): base(options)
        {
        }

        public DbSet<Pessoa> pessoas { get;  set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");

        } 

    }
}
