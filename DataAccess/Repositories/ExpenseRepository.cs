using DataAccess.Entities;
using DataAccess.Filter;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class ExpenseRepository
    {
        private readonly NyamaContext _context;

        public ExpenseRepository()
        {
            _context = new NyamaContext();
        }

        public Expense GetExpenseById(int id)
        {
            return _context.Expense.FirstOrDefault(x => x.ExpenseId == id);
        }

        public List<ExpenseType> GetAllExpenseType()
        {
            return _context.ExpenseType.ToList();
        }

        public bool AddExpense(Expense expense)
        {
            _context.Add(expense);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateExpense(Expense expense)
        {
            _context.Update(expense);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteExpense(int id)
        {
            var getExpense = GetExpenseById(id);
            _context.Remove(getExpense);
            _context.SaveChanges();
            return true;
        }

        public List<Expense> FilterExpense(FilterExpense filter)
        {
            var query = _context.Expense.Include(x => x.ExpenseType).AsQueryable();

            if(filter == null)
            {
                return query.ToList();
            }

            if (filter.ExpenseTypeId.HasValue)
            {
                query = query.Where(x => x.ExpenseType.ExpenseTypeId == filter.ExpenseTypeId);
            }

            if (filter.MinAmount.HasValue)
            {
                query = query.Where(x => x.Amount >= filter.MinAmount);
            }

            if (filter.MaxAmount.HasValue)
            {
                query= query.Where(x => x.Amount <= filter.MaxAmount);
            }

            if (filter.MinDateOfExpense.HasValue)
            {
                query = query.Where(x => x.DateOfExpense >= filter.MinDateOfExpense);
            }

            if (filter.MaxDateOfExpense.HasValue)
            {
                query = query.Where(x => x.DateOfExpense <= filter.MaxDateOfExpense);
            }

            return query.ToList();
        }
    }
}
