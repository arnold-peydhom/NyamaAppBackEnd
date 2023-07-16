using System;

namespace DataAccess.Entities
{
    public class Category
    {
        public int CategoryId { get; set; } = default!;
        public string Name { get; set; } = default!;

        public HashSet<ExpenseType> ExpenseTypes { get; set; } = default!;
    }
}
