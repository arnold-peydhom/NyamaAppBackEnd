using System;

namespace Business.Models
{
    public class DistrictModel
    {
        public int DistrictId { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string CityId { get; set; } = default!;
    }
}
