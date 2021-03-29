using System.Collections.Generic;

namespace Entities
{
    public class District
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public int DistrictNumber { get; set; }
        public List<School> Schools { get; set; }
    }
}