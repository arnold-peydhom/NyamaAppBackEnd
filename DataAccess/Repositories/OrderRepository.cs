using DataAccess.Entities;
using DataAccess.Filter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    public class OrderRepository
    {
        private readonly NyamaContext _context;

        public OrderRepository()
        {
            _context = new NyamaContext();
        }

        public Order GetOrderById(int id)
        {
            return _context.Order.FirstOrDefault(x => x.OrderId == id);
        }

        public bool AddOrder(Order order)
        {
            _context.Add(order);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateOrder(Order order)
        {
            _context.Update(order);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteOrder(int id)
        {
            var getOrder = GetOrderById(id);
            _context.Remove(getOrder);
            _context.SaveChanges();
            return true;
        }

        public List<Order> FilterOrder(FilterOrder filter)
        {
            var query = _context.Order.Include(x => x.Shop).AsQueryable();
            if (filter == null)
            {
                return query.ToList();
            }

            if (filter.ShopId.HasValue)
            {
                query = query.Where(x => x.Shop.ShopId == filter.ShopId);
            }
            
            if (filter.IsPayed.HasValue)
            {
                query = query.Where(x => x.IsPayLater == filter.IsPayed);
            }

            if (filter.MinQuantity.HasValue)
            {
                query = query.Where(x => x.QuantityOfBags >= filter.MinQuantity);
            }

            if (filter.MaxQuantity.HasValue)
            {
                query = query.Where(x => x.QuantityOfBags <= filter.MaxQuantity);
            }

            if (filter.MinDateOfOrder.HasValue)
            {
                query = query.Where(x => x.CreatingDate >= filter.MinDateOfOrder);
            }

            if (filter.MaxDateOfOrder.HasValue)
            {
                query = query.Where(x => x.CreatingDate <= filter.MaxDateOfOrder);
            }

            if (filter.MinDateOfPayement.HasValue)
            {
                query = query.Where(x => x.PayementDate >= filter.MinDateOfPayement);
            }

            if (filter.MaxDateOfPayement.HasValue)
            {
                query = query.Where(x => x.PayementDate <= filter.MaxDateOfPayement);
            }

            return query.ToList();
        }
    }
}
