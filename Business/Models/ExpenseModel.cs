using System;

namespace Business.Models
{
    public class ExpenseModel
    {
        public int ExpenseId { get; set; } = default!;
        public int Quantity { get; set; } = default!;
        public decimal Amount { get; set; } = default!;
        public DateTime DateOfExpense { get; set; } = default!;
        public int UnitId { get; set; } = default!;
        public int ExpenseTypeId { get; set; } = default!;
    }
}
