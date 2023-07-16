using System;

namespace DataAccess.Entities
{
    public class Expense
    {
        public int ExpenseId { get; set; } = default!;
        public int Quantity { get; set; } = default!;
        public decimal Amount { get; set; } = default!;
        public DateTime DateOfExpense { get; set; } = default!;
        public int UnitId { get; set; } = default!;
        public int ExpenseTypeId { get; set; } = default!;

        public ExpenseType ExpenseType { get; set; } = default!;
        public Unit Unit { get; set; } = default!;
    }
}
