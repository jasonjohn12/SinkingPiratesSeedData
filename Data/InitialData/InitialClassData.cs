using Entities;

namespace Data
{
    public static class InitialClassData
    {
        public static Class[] InitialClasses = {
                new Class { ClassId = 1, ClassName = "Principals of BioMedical Science", UserId = 2 },
                new Class { ClassId = 2, ClassName = "Chemistry", UserId = 2 },
                new Class { ClassId = 3, ClassName = "Physics", UserId = 3 },
                new Class { ClassId = 4, ClassName = "Biology", UserId = 4 },
                new Class { ClassId = 5, ClassName = "Algebra", UserId = 2 },
                new Class { ClassId = 6, ClassName = "English", UserId = 1 }
        };
    }
}