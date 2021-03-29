using System;
using Entities;

namespace Data
{
    public static class InitialEntryData
    {
        public static Entry[] InitialEntries = {
            new Entry
       {
           EntryId = 1,
           StudentId = 1,
           CreatedByUserId = 1,
           Note = "Did not turn in last assignment",
           Contacted = false,
           CreatedAtDateUTC = DateTime.UtcNow
       },
       new Entry
       {
           EntryId = 2,
           StudentId = 1,
           CreatedByUserId = 1,
           Note = "Did not turn in last assignment",
           Contacted = false,
           CreatedAtDateUTC = DateTime.UtcNow
       },
       new Entry
       {
           EntryId = 3,
           StudentId = 2,
           CreatedByUserId = 3,
           Note = "She's too smart.",
           Contacted = false,
           CreatedAtDateUTC = DateTime.UtcNow
       },
       new Entry
       {
           EntryId = 4,
           StudentId = 2,
           CreatedByUserId = 3,
           Note = "Left Message to parent. No Answer",
           Contacted = false,
           CreatedAtDateUTC = DateTime.UtcNow
       },
       new Entry
       {
           EntryId = 5,
           StudentId = 1,
           CreatedByUserId = 1,
           Note = "Did not turn in last assignment",
           Contacted = false,
           CreatedAtDateUTC = DateTime.UtcNow
       },
       new Entry
       {
           EntryId = 6,
           StudentId = 3,
           CreatedByUserId = 1,
           Note = "Did not turn in last assignment",
           Contacted = false,
           CreatedAtDateUTC = DateTime.UtcNow
       },
       new Entry
       {
           EntryId = 7,
           StudentId = 3,
           CreatedByUserId = 1,
           Note = "Did not turn in last assignment",
           Contacted = false,
           CreatedAtDateUTC = DateTime.UtcNow
       }
        };
    }
}