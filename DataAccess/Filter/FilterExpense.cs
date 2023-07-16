using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Filter
{
    public class FilterExpense
    {
        public int? ExpenseTypeId { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public DateTime? MinDateOfExpense { get; set; }
        public DateTime? MaxDateOfExpense { get; set; }
    }
}
