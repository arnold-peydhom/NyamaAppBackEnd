using DataAccess.Entities;
using DataAccess.Filter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    public class ShopRepository
    {
        private readonly NyamaContext _context;

        public ShopRepository()
        {
            _context = new NyamaContext();
        }

        public Shop GetShopById(int shopId)
        {
            return _context.Shop.FirstOrDefault(x => x.ShopId == shopId);
        }

        public List<Shop> getAllShop()
        {
            return _context.Shop.ToList();
        }

        public bool AddShop(Shop shop)
        {
            _context.Add(shop);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteShop(int id)
        {
            var getShopById = GetShopById(id);
            _context.Remove(getShopById);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateShop(Shop shop)
        {
            _context.SaveChanges();
            _context.Update(shop);
            return true;
        }

        public List<Shop> Filter(FilterShop filter)
        {
            var query = _context.Shop.Include(x => x.District).Include(x => x.Orders).AsQueryable();
            if (filter == null)
            {
                return query.ToList();
            }

            if (!string.IsNullOrEmpty(filter.NameShop))
            {
                query = query.Where(x => x.Name.Contains(filter.NameShop));
            }

            if (filter.DistrictId.HasValue)
            {
                query = query.Where(x => x.District.DistrictId == filter.DistrictId);
            }

            if (filter.IsProspection.HasValue)
            {
                query = query.Where(x => x.IsProspection == filter.IsProspection);
            }

            if (filter.MinJoiningDate.HasValue)
            {
                query = query.Where(x => x.JoiningDate >= filter.MinJoiningDate);
            }

            if (filter.MaxJoiningDate.HasValue)
            {
                query = query.Where(x => x.JoiningDate <= filter.MaxJoiningDate);
            }

            if (filter.MinOrder.HasValue)
            {
                query = query.Where(x => x.Orders.Count >= filter.MinOrder);
            }

            if (filter.MaxOrder.HasValue)
            {
                query = query.Where(x => x.Orders.Count <= filter.MaxOrder);
            }

            if (filter.MinQuantityOfBag.HasValue)
            {
                query = query.Where(x => x.Orders.Any(o => o.QuantityOfBags >= filter.MinQuantityOfBag));
            }

            if (filter.MaxQuantityOfBag.HasValue)
            {
                query = query.Where(x => x.Orders.Any(o => o.QuantityOfBags <= filter.MaxQuantityOfBag));
            }

            return query.ToList();
        }

        public int GetNumberOfOrder(int idShop)
        {
            var query = _context.Order.AsQueryable();
            return query.Count(x => x.ShopId == idShop);
        }

        public int GetQuantityOfBags(int idShop)
        {
            var query = _context.Order.AsQueryable();
            var listOfOrder = query.Where(x => x.ShopId == idShop).Select(x=>x.QuantityOfBags);

            if (listOfOrder is not null)
            {
                var valueOfCount = 0;
                foreach (var list in listOfOrder)
                {
                    valueOfCount = valueOfCount + list;
                }

                return valueOfCount;
            }
            return 0;
        }
    }
}
