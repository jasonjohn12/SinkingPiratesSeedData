using System;
using System.Collections.Generic;

namespace Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public int ClassId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public DateTime CreatedAtUTC { get; set; }
        public DateTime? LastEditDateUTC { get; set; }
        public int LastEditByUserId { get; set; }
        public ICollection<Entry> Entries { get; set; }
    }
}