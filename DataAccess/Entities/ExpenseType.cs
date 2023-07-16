using System;

namespace DataAccess.Entities
{
    public class ExpenseType
    {
        public int ExpenseTypeId { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int CategoryId { get; set; } = default!;

        public Category Category { get; set; } = default!;
        public HashSet<Expense> Expenses { get; set; } = default!;
    }
}
