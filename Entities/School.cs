namespace Entities
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public District District { get; set; }
        public int DistrictId { get; set; }

    }
}