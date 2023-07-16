using Business.Models;
using DataAccess.Entities;
using DataAccess.Filter;
using DataAccess.Repositories;

namespace Business.Services
{
    public class ExpenseService
    {
        ExpenseRepository expenseRepository = new ExpenseRepository();

        public Expense GetExpenseById(int id)
        {
            return expenseRepository.GetExpenseById(id);
        }

        public List<ExpenseType> GetAllExpenseType()
        {
            return expenseRepository.GetAllExpenseType();
        }

        public bool AddExpense(ExpenseModel expense)
        {
            var getExpense = expense.ExpenseId;
            if (getExpense > 0)
            {
                return false;
            }
            var entity = new Expense()
            {
                Quantity = expense.Quantity,
                Amount = expense.Amount,
                DateOfExpense = expense.DateOfExpense,
                ExpenseTypeId = expense.ExpenseTypeId,
                UnitId = expense.UnitId,
            };

            expenseRepository.AddExpense(entity);
            return true;
        }

        public bool DeleteExpense(int id)
        {
            var getExpense = expenseRepository.GetExpenseById(id);
            if (getExpense is null)
            {
                return false;
            }
            expenseRepository.DeleteExpense(id);
            return true;
        }

        public bool UpdateExpense(ExpenseModel expense)
        {
            var getExpense = GetExpenseById(expense.ExpenseId);
            if (getExpense is null)
            {
                return false;
            }
            getExpense.Quantity = expense.Quantity;
            getExpense.Amount = expense.Amount;
            getExpense.DateOfExpense = expense.DateOfExpense;
            getExpense.ExpenseTypeId = expense.ExpenseTypeId;
            getExpense.UnitId = expense.UnitId;

            expenseRepository.UpdateExpense(getExpense);
            return true;
        }

        public List<ExpenseModel> FilterExpense(FilterExpenseModel filter)
        {
            var convertToEntity = new FilterExpense()
            {
                ExpenseTypeId = filter.ExpenseTypeId,
                MaxAmount = filter.MaxAmount,
                MaxDateOfExpense = filter.MaxDateOfExpense,
                MinAmount = filter.MinAmount,
                MinDateOfExpense = filter.MinDateOfExpense, 
            };
            var concat = expenseRepository.FilterExpense(convertToEntity);
            return concat.Select(x => new ExpenseModel
            {
                Quantity = x.Quantity,
                Amount = x.Amount,
                DateOfExpense = x.DateOfExpense,
                ExpenseTypeId = x.ExpenseTypeId,
                UnitId = x.UnitId,
                ExpenseId = x.ExpenseId
            }).ToList();
        }
    }
}
