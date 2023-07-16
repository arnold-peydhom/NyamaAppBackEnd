using System;

namespace Business.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; } = default!;
        public DateTime CreatingDate { get; set; } = default!;
        public bool IsPayLater { get; set; } = default!;
        public int QuantityOfBags { get; set; } = default!;
        public DateTime PayementDate { get; set; } = default!;
        public int ShopId { get; set; } = default!;
    }
}
