using System;
using Entities;

namespace Data
{
    public static class InitialStudentData
    {
        public static Student[] InitialStudent = {
                         new Student
               {
                   StudentId = 1,
                   ClassId = 1,
                   FirstName = "Harry",
                   LastName = "Potter",
                   Grade = 60,
                   CreatedAtUTC = DateTime.UtcNow,
                   LastEditByUserId = 1,
                   UserId = 1
               },
               new Student
               {
                   StudentId = 2,
                   ClassId = 2,
                   FirstName = "Luna",
                   LastName = "LoveGood",
                   Grade = 77,
                   CreatedAtUTC = DateTime.UtcNow,
                   LastEditByUserId = 2,
                   UserId = 2
               },
                new Student
                {
                    StudentId = 3,
                    ClassId = 2,
                    FirstName = "Hermoine",
                    LastName = "Granger",
                    Grade = 58,
                    CreatedAtUTC = DateTime.UtcNow,
                    LastEditByUserId = 2,
                    UserId = 1
                },
                new Student
                {
                    StudentId = 4,
                    ClassId = 5,
                    FirstName = "Ron",
                    LastName = "Weasely",
                    Grade = 48,
                    CreatedAtUTC = DateTime.UtcNow,
                    LastEditByUserId = 2,
                    UserId = 1
                },
                new Student
                {
                    StudentId = 5,
                    ClassId = 3,
                    FirstName = "Draco",
                    LastName = "Malfor",
                    Grade = 50,
                    CreatedAtUTC = DateTime.UtcNow,
                    LastEditByUserId = 2,
                    UserId = 3
                },
                new Student
                {
                    StudentId = 6,
                    ClassId = 3,
                    FirstName = "Gregory",
                    LastName = "Goyle",
                    Grade = 40,
                    CreatedAtUTC = DateTime.UtcNow,
                    LastEditByUserId = 2,
                    UserId = 3
                }
        };
    }
}