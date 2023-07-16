using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Models
{
    public class FilterOrderModel
    {
        public int? ShopId { get; set; }
        public bool? IsPayed { get; set; }
        public int ? MaxQuantity { get; set; }
        public int? MinQuantity  { get; set; }
        public DateTime? MinDateOfOrder { get; set; }
        public DateTime? MaxDateOfOrder { get; set; }
        public DateTime? MinDateOfPayement { get; set; }
        public DateTime? MaxDateOfPayement { get; set; }
    }
}
