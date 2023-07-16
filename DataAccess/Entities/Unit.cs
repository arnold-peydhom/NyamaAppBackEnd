using System;

namespace DataAccess.Entities
{
    public class Unit
    {
        public int UnitId { get; set; } = default!;
        public string Name { get; set; } = default!;

        public HashSet<Expense> Expenses { get; set; }
    }
}
