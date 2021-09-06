using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace MyMVCProject.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }


    public class StudentDbContext : DbContext
    {
        public StudentDbContext()
        { }
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Books> Books { get; set; }
        public DbSet<Book> Booksa { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)

            {
                optionsBuilder.UseSqlServer("Server=.;Database=MyMVCProjecta;Trusted_Connection=True;MultipleActiveResultSets=true");
            }

        }



    }
}

