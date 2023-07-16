using Business.Models;
using DataAccess.Entities;
using DataAccess.Filter;
using DataAccess.Repositories;

namespace Business.Services
{
    public class OrderService
    {
        OrderRepository orderRepository = new OrderRepository();

        public Order GetOrderById(int id)
        {
            return orderRepository.GetOrderById(id);
        }

        public bool AddOrder(OrderModel order)
        {
            var getOrder = order.OrderId;
            if (getOrder > 0)
            {
                return false;
            }
            var entity = new Order()
            {
                CreatingDate = order.CreatingDate,
                IsPayLater = order.IsPayLater,
                QuantityOfBags = order.QuantityOfBags,
                PayementDate = order.PayementDate,
                ShopId = order.ShopId,
            };
            orderRepository.AddOrder(entity);
            return true;
        }

        public bool DeleteOrder(int id)
        {
            var getOrder = orderRepository.GetOrderById(id);
            if (getOrder is null)
            {
                return false;
            }
            orderRepository.DeleteOrder(id);
            return true;
        }

        public bool UpdateOrder(OrderModel order)
        {
            var getOrder = orderRepository.GetOrderById(order.OrderId);
            if (getOrder is null)
            {
                return false;
            }

            getOrder.CreatingDate = order.CreatingDate;
            getOrder.IsPayLater = order.IsPayLater;
            getOrder.QuantityOfBags = order.QuantityOfBags;
            getOrder.PayementDate = order.PayementDate;
            getOrder.ShopId = order.ShopId;

            orderRepository.UpdateOrder(getOrder);
            return true;
        }

        public List<OrderModel> FilterOrder(FilterOrderModel filter)
        {
            var convertToEntity = new FilterOrder()
            {
                ShopId = filter.ShopId,
                IsPayed = filter.IsPayed,
                MaxQuantity = filter.MaxQuantity,
                MinQuantity = filter.MinQuantity,
                MinDateOfOrder = filter.MinDateOfOrder,
                MaxDateOfOrder = filter.MaxDateOfOrder,
                MinDateOfPayement = filter.MinDateOfPayement,
                MaxDateOfPayement = filter.MaxDateOfPayement,
            };
            var response = orderRepository.FilterOrder(convertToEntity);
            return response.Select(x => new OrderModel
            {
                CreatingDate = x.CreatingDate,
                IsPayLater = x.IsPayLater,
                QuantityOfBags = x.QuantityOfBags,
                PayementDate = x.PayementDate,
                ShopId = x.ShopId,
            }).ToList();
        }
    }
}
