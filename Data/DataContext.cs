using System;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<District> Districts { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Entry> Entries { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<District>().HasData(InitialDistrictData.InitialDistrict);
            modelBuilder.Entity<School>().HasData(InitialSchoolData.InitialSchools);
            modelBuilder.Entity<User>().HasData(InitialUsersData.InitialUsers);
            modelBuilder.Entity<Class>().HasData
                (InitialClassData.InitialClasses);
            modelBuilder.Entity<Student>().HasData
               (InitialStudentData.InitialStudent);
            modelBuilder.Entity<Entry>().HasData
             (InitialEntryData.InitialEntries);
        }
    }


}