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
        //public StudentDbContext()
        //{ }
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Books> Books { get; set; }
        public DbSet<Book> Booksa { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentInfo> StudentInfo { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    if (!optionsBuilder.IsConfigured)

        //    {
        //        optionsBuilder.UseSqlServer("Server=.;Database=MyMVCProjecta;Trusted_Connection=True;MultipleActiveResultSets=true");
        //    }

        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentInfo>(entity =>

            {

                //entity.Property(e => e.CreatedAt).HasColumnType("datetime");
                //entity.Property(e => e.IsActive)

                //    .IsRequired()

                //    .HasDefaultValueSql("((1))");



                //entity.Property(e => e.LastUpdated)

                //    .HasColumnType("datetime")

                //    .HasDefaultValueSql("(getdate())");



                //entity.HasOne(d => d.Student)

                //   .WithMany(p => p.StudentInfo)

                //   .HasForeignKey(d => d.StudentId)

                //   .HasConstraintName("FK_StudentInfoMaster_Student");

            });


        }



    }
    }

