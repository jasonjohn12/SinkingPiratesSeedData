using System;
using Data.Models;
using System.Security.Cryptography;
using Entities;
using System.Text;

namespace Data
{

    public static class InitialUsersData
    {

        public static User[] InitialUsers =  {
            new User { UserId = 1, Status = UserStatus.ACTIVE, SchoolId = 1, UserName = "jasonjohn12", PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("password")), PasswordSalt = new HMACSHA512().Key, FirstName = "Jason", LastName = "John", UserRole = ROLE.ADMIN, CreateAtDateUTC = DateTime.UtcNow, LastActive = DateTime.UtcNow },
            new User { UserId = 2,Status = UserStatus.ACTIVE, SchoolId = 1, UserName = "shawnajohn09",PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("password")), FirstName = "Shawna", LastName = "John", UserRole = ROLE.TEACHER, CreateAtDateUTC = DateTime.UtcNow, LastActive = DateTime.UtcNow },
            new User { UserId = 3,Status = UserStatus.ACTIVE, SchoolId = 1, UserName = "emaybe",PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("password")), FirstName = "Eric", LastName = "Mabie", UserRole = ROLE.TEACHER, CreateAtDateUTC = DateTime.UtcNow, LastActive = DateTime.UtcNow },
            new User { UserId = 4,Status = UserStatus.ACTIVE, SchoolId = 1, UserName = "kallioop",PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("password")), FirstName = "Kalli", LastName = "Hinemen", UserRole = ROLE.TEACHER, CreateAtDateUTC = DateTime.UtcNow, LastActive = DateTime.UtcNow },
            new User { UserId = 5,Status = UserStatus.ACTIVE, SchoolId = 1, UserName = "jngyuen",PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("password")), FirstName = "John", LastName = "Ngyuen", UserRole = ROLE.ADMIN, CreateAtDateUTC = DateTime.UtcNow, LastActive = DateTime.UtcNow },
            new User { UserId = 6,Status = UserStatus.ACTIVE, SchoolId = 1, UserName = "jtytla",PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("password")), FirstName = "John", LastName = "Tytla", UserRole = ROLE.ADMIN, CreateAtDateUTC = DateTime.UtcNow, LastActive = DateTime.UtcNow }
        };

    }


}