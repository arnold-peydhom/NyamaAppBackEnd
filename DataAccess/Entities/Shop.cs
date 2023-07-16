using System;

namespace DataAccess.Entities
{
    public class Shop
    {
        public int ShopId { get; set; } = default!;
        public string Name { get; set; } = default!;
        public bool IsProspection { get; set; } = default!;
        public string FirstPhone { get; set; } = default!;
        public bool? IsWhatsappFirstPhone { get; set; }
        public string? GpsLongigtude { get; set; }
        public string? GpsLatitude { get; set; }
        public string? SecondPhone { get; set; }
        public bool? IsWhatsappSecondPhone { get; set; }
        public DateTime CreatingDate { get; set; } = default!;
        public DateTime JoiningDate { get; set; } = default!;
        public int? ImageId { get; set; }
        public int DistrictId { get; set; }

        public Image Image { get; set; } = default!;
        public District District { get; set; } = default!;
        public HashSet<Order> Orders { get; set; } = default!;
    }
}
