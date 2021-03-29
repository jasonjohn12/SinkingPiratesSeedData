using System;

namespace Entities
{
    public class Entry
    {
        public int EntryId { get; set; }
        public int CreatedByUserId { get; set; }
        public int LastEditByUserId { get; set; }
        public DateTime CreatedAtDateUTC { get; set; }
        public DateTime? RecentContactDateUTC { get; set; }
        public string Note { get; set; }
        public bool Contacted { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}