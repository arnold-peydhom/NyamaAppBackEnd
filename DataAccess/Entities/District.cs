using System;

namespace DataAccess.Entities
{
    public class District
    {
        public int DistrictId { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int CityId { get; set; } = default!;

        public City City { get; set; } = default!;
        public HashSet<Shop> Shops { get; set; } = default!;
    }
}
