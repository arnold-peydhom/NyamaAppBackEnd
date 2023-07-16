using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    public class ReferentialRepository
    {
        private readonly NyamaContext _context;

        public ReferentialRepository()
        {
            _context = new NyamaContext();
        }

        public List<City> GetCityToSelect()
        {
            return _context.City.ToList();
        }

        public List<District> GetDistrictToSelect()
        {
            return _context.District.ToList();
        }

        public List<ExpenseType> GetExpenseTypeToSelect()
        {
            return _context.ExpenseType.ToList();
        }

        public List<Category> GetCategoryToSelect()
        {
            return _context.Category.ToList();
        }

        public List<Unit> GetUnitToSelect()
        {
            return _context.Unit.ToList();
        }

        public List<District> GetDistrictByCityId(int id)
        {
            return _context.District.Where(x => x.CityId == id).ToList();
        }
    }
}
