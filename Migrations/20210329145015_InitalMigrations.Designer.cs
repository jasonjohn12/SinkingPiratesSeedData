// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SeedDatabase.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210329145015_InitalMigrations")]
    partial class InitalMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Entities.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            ClassName = "Principals of BioMedical Science",
                            UserId = 2
                        },
                        new
                        {
                            ClassId = 2,
                            ClassName = "Chemistry",
                            UserId = 2
                        },
                        new
                        {
                            ClassId = 3,
                            ClassName = "Physics",
                            UserId = 3
                        },
                        new
                        {
                            ClassId = 4,
                            ClassName = "Biology",
                            UserId = 4
                        },
                        new
                        {
                            ClassId = 5,
                            ClassName = "Algebra",
                            UserId = 2
                        },
                        new
                        {
                            ClassId = 6,
                            ClassName = "English",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DistrictName")
                        .HasColumnType("TEXT");

                    b.Property<int>("DistrictNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Districts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DistrictName = "Piper School District",
                            DistrictNumber = 206
                        });
                });

            modelBuilder.Entity("Entities.Entry", b =>
                {
                    b.Property<int>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Contacted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAtDateUTC")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LastEditByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RecentContactDateUTC")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntryId");

                    b.HasIndex("StudentId");

                    b.ToTable("Entries");

                    b.HasData(
                        new
                        {
                            EntryId = 1,
                            Contacted = false,
                            CreatedAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4480),
                            CreatedByUserId = 1,
                            LastEditByUserId = 0,
                            Note = "Did not turn in last assignment",
                            StudentId = 1
                        },
                        new
                        {
                            EntryId = 2,
                            Contacted = false,
                            CreatedAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4980),
                            CreatedByUserId = 1,
                            LastEditByUserId = 0,
                            Note = "Did not turn in last assignment",
                            StudentId = 1
                        },
                        new
                        {
                            EntryId = 3,
                            Contacted = false,
                            CreatedAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4990),
                            CreatedByUserId = 3,
                            LastEditByUserId = 0,
                            Note = "She's too smart.",
                            StudentId = 2
                        },
                        new
                        {
                            EntryId = 4,
                            Contacted = false,
                            CreatedAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4990),
                            CreatedByUserId = 3,
                            LastEditByUserId = 0,
                            Note = "Left Message to parent. No Answer",
                            StudentId = 2
                        },
                        new
                        {
                            EntryId = 5,
                            Contacted = false,
                            CreatedAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4990),
                            CreatedByUserId = 1,
                            LastEditByUserId = 0,
                            Note = "Did not turn in last assignment",
                            StudentId = 1
                        },
                        new
                        {
                            EntryId = 6,
                            Contacted = false,
                            CreatedAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4990),
                            CreatedByUserId = 1,
                            LastEditByUserId = 0,
                            Note = "Did not turn in last assignment",
                            StudentId = 3
                        },
                        new
                        {
                            EntryId = 7,
                            Contacted = false,
                            CreatedAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4990),
                            CreatedByUserId = 1,
                            LastEditByUserId = 0,
                            Note = "Did not turn in last assignment",
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("Entities.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DistrictId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DistrictId = 1,
                            Name = "Piper High School"
                        });
                });

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<double>("Grade")
                        .HasColumnType("REAL");

                    b.Property<int>("LastEditByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastEditDateUTC")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            ClassId = 1,
                            CreatedAtUTC = new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(6520),
                            FirstName = "Harry",
                            Grade = 60.0,
                            LastEditByUserId = 1,
                            LastName = "Potter",
                            UserId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            ClassId = 2,
                            CreatedAtUTC = new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(7730),
                            FirstName = "Luna",
                            Grade = 77.0,
                            LastEditByUserId = 2,
                            LastName = "LoveGood",
                            UserId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            ClassId = 2,
                            CreatedAtUTC = new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(7770),
                            FirstName = "Hermoine",
                            Grade = 58.0,
                            LastEditByUserId = 2,
                            LastName = "Granger",
                            UserId = 1
                        },
                        new
                        {
                            StudentId = 4,
                            ClassId = 5,
                            CreatedAtUTC = new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(7770),
                            FirstName = "Ron",
                            Grade = 48.0,
                            LastEditByUserId = 2,
                            LastName = "Weasely",
                            UserId = 1
                        },
                        new
                        {
                            StudentId = 5,
                            ClassId = 3,
                            CreatedAtUTC = new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(7770),
                            FirstName = "Draco",
                            Grade = 50.0,
                            LastEditByUserId = 2,
                            LastName = "Malfor",
                            UserId = 3
                        },
                        new
                        {
                            StudentId = 6,
                            ClassId = 3,
                            CreatedAtUTC = new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(7770),
                            FirstName = "Gregory",
                            Grade = 40.0,
                            LastEditByUserId = 2,
                            LastName = "Goyle",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateAtDateUTC")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserRole")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreateAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(2450),
                            FirstName = "Jason",
                            LastActive = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(2880),
                            LastName = "John",
                            PasswordHash = new byte[] { 59, 136, 59, 244, 121, 85, 69, 56, 176, 36, 125, 152, 202, 104, 43, 65, 56, 49, 110, 237, 33, 106, 215, 190, 99, 226, 226, 204, 213, 143, 189, 27, 214, 10, 66, 230, 187, 60, 245, 216, 103, 216, 17, 71, 97, 13, 69, 76, 124, 214, 126, 204, 166, 170, 35, 149, 21, 41, 2, 180, 99, 184, 166, 186 },
                            PasswordSalt = new byte[] { 252, 53, 60, 100, 141, 181, 239, 92, 177, 47, 241, 77, 205, 132, 8, 199, 103, 85, 94, 189, 14, 185, 235, 38, 43, 95, 149, 17, 20, 242, 113, 68, 30, 174, 148, 57, 59, 240, 133, 180, 164, 43, 182, 108, 161, 106, 12, 59, 130, 240, 91, 173, 85, 188, 235, 175, 5, 228, 5, 55, 156, 69, 142, 112, 159, 73, 251, 41, 72, 99, 138, 103, 90, 177, 0, 57, 54, 185, 103, 88, 187, 210, 206, 184, 2, 140, 217, 4, 116, 88, 77, 247, 233, 151, 149, 122, 109, 110, 115, 45, 227, 91, 150, 93, 29, 221, 145, 11, 53, 24, 172, 187, 151, 28, 92, 10, 23, 38, 247, 207, 151, 220, 213, 184, 193, 239, 146, 33 },
                            SchoolId = 1,
                            Status = 1,
                            UserName = "jasonjohn12",
                            UserRole = 1
                        },
                        new
                        {
                            UserId = 2,
                            CreateAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3590),
                            FirstName = "Shawna",
                            LastActive = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3600),
                            LastName = "John",
                            PasswordHash = new byte[] { 198, 220, 210, 40, 7, 118, 91, 208, 64, 24, 187, 197, 107, 167, 105, 251, 153, 55, 104, 150, 174, 102, 222, 202, 198, 54, 59, 76, 86, 211, 95, 241, 135, 99, 207, 83, 112, 12, 208, 136, 208, 67, 78, 182, 187, 14, 58, 254, 107, 165, 106, 248, 237, 72, 19, 33, 195, 254, 214, 44, 125, 217, 56, 227 },
                            SchoolId = 1,
                            Status = 1,
                            UserName = "shawnajohn09",
                            UserRole = 2
                        },
                        new
                        {
                            UserId = 3,
                            CreateAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3660),
                            FirstName = "Eric",
                            LastActive = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3660),
                            LastName = "Mabie",
                            PasswordHash = new byte[] { 180, 255, 110, 119, 134, 36, 15, 123, 246, 28, 94, 114, 210, 157, 2, 100, 40, 186, 231, 218, 126, 3, 150, 192, 122, 73, 21, 129, 229, 236, 108, 87, 152, 17, 150, 181, 5, 164, 10, 80, 155, 138, 214, 139, 205, 83, 254, 251, 105, 154, 10, 158, 200, 243, 62, 39, 230, 207, 172, 230, 72, 131, 204, 168 },
                            SchoolId = 1,
                            Status = 1,
                            UserName = "emaybe",
                            UserRole = 2
                        },
                        new
                        {
                            UserId = 4,
                            CreateAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3840),
                            FirstName = "Kalli",
                            LastActive = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3840),
                            LastName = "Hinemen",
                            PasswordHash = new byte[] { 42, 178, 238, 209, 13, 227, 76, 65, 173, 224, 69, 91, 44, 42, 226, 241, 201, 51, 51, 34, 125, 101, 19, 235, 222, 253, 60, 241, 132, 224, 128, 196, 147, 114, 35, 196, 24, 107, 169, 62, 89, 179, 214, 134, 70, 103, 8, 48, 60, 69, 137, 250, 16, 96, 247, 155, 83, 152, 182, 190, 221, 66, 104, 214 },
                            SchoolId = 1,
                            Status = 1,
                            UserName = "kallioop",
                            UserRole = 2
                        },
                        new
                        {
                            UserId = 5,
                            CreateAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3870),
                            FirstName = "John",
                            LastActive = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3870),
                            LastName = "Ngyuen",
                            PasswordHash = new byte[] { 162, 235, 233, 140, 190, 206, 47, 63, 174, 247, 97, 232, 215, 144, 105, 36, 226, 2, 171, 251, 27, 7, 108, 155, 74, 207, 94, 81, 60, 132, 241, 27, 96, 19, 192, 122, 98, 88, 43, 152, 100, 244, 224, 86, 130, 186, 142, 91, 104, 211, 166, 132, 218, 153, 41, 149, 93, 201, 111, 104, 159, 57, 89, 152 },
                            SchoolId = 1,
                            Status = 1,
                            UserName = "jngyuen",
                            UserRole = 1
                        },
                        new
                        {
                            UserId = 6,
                            CreateAtDateUTC = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3940),
                            FirstName = "John",
                            LastActive = new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3940),
                            LastName = "Tytla",
                            PasswordHash = new byte[] { 238, 105, 32, 159, 202, 50, 240, 43, 195, 133, 103, 164, 81, 244, 9, 254, 222, 126, 129, 48, 207, 16, 32, 204, 73, 25, 137, 216, 114, 75, 112, 112, 203, 226, 246, 28, 187, 78, 79, 134, 185, 22, 49, 247, 47, 197, 150, 27, 248, 95, 165, 116, 129, 10, 209, 49, 140, 131, 113, 173, 66, 29, 12, 64 },
                            SchoolId = 1,
                            Status = 1,
                            UserName = "jtytla",
                            UserRole = 1
                        });
                });

            modelBuilder.Entity("Entities.Entry", b =>
                {
                    b.HasOne("Entities.Student", "Student")
                        .WithMany("Entries")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.School", b =>
                {
                    b.HasOne("Entities.District", "District")
                        .WithMany("Schools")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.HasOne("Entities.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId");
                });
#pragma warning restore 612, 618
        }
    }
}
