using System;
using System.Collections.Generic;
using Data.Models;

namespace Entities
{
    public enum ROLE
    {
        ADMIN = 1,
        TEACHER = 2
    }
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ROLE? UserRole { get; set; }
        public UserStatus? Status { get; set; }
        public School School { get; set; }
        public int? SchoolId { get; set; }
        public DateTime CreateAtDateUTC { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set; } = DateTime.UtcNow;
        //  public ICollection<Class> Classes { get; set; }
    }
}