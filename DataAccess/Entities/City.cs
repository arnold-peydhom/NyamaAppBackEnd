using System;

namespace DataAccess.Entities
{
    public class City
    {
        public int CityId { get; set; } = default!;
        public string Name { get; set; } = default!;

        public HashSet<District> Districts { get; set; } = default!;
    }
}
