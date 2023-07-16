using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Filter
{
    public class FilterShop
    {
        public string? NameShop { get; set; }
        public int? DistrictId { get; set; }
        public bool? IsProspection { get; set; }
        public DateTime? MinJoiningDate { get; set; }
        public DateTime? MaxJoiningDate { get; set; }
        public int? MinOrder { get; set; }
        public int? MaxOrder { get; set; }
        public int? MinQuantityOfBag { get; set; }
        public int? MaxQuantityOfBag { get; set; }
    }
}
