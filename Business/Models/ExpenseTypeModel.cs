using System;

namespace Business.Models
{
    public class ExpenseTypeModel
    {
        public int ExpenseTypeId { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int CategoryId { get; set; } = default!;
    }
}
