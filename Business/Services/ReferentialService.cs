using Business.Models;
using DataAccess.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class ReferentialService
    {
        ReferentialRepository referentialRepository = new ReferentialRepository();

        public List<City> GetCityToSelect()
        {
            return referentialRepository.GetCityToSelect();
        }

        public List<District> GetDistrictToSelect()
        {
            return referentialRepository.GetDistrictToSelect();
        }

        public List<ExpenseType> GetExpenseTypeToSelect()
        {
            return referentialRepository.GetExpenseTypeToSelect();
        }

        public List<Category> GetCategoryToSelect()
        {
            return referentialRepository.GetCategoryToSelect();
        }

        public List<Unit> GetUnitToSelect()
        {
            return referentialRepository.GetUnitToSelect();
        }

        public List<District> GetDistrictByCityId(int id)
        {
            return referentialRepository.GetDistrictByCityId(id);
        }
    }
}
