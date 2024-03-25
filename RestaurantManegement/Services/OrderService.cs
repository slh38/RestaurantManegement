using RestaurantManegement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManegement.Services
{
    public class OrderService : IBaseService<Order>
    {
        private readonly ApplicationDbContext _Context;
        public OrderService()
        {
            _Context=new ApplicationDbContext();
        }
        public void Add(Order order)
        {
            _Context.Orders.Add(order);
        }

        public Order Get(int id)
        {
            var getOrder = _Context.Orders.FirstOrDefault(x => x.Id == id);
            return getOrder;
        }

        public List<Order> GetAll()
        {
            List<Order> orders = _Context.Orders.Where(x => x.IsDElete == false).ToList();
            
            if (orders.Count >0)
            {
                return orders;
            }
            else
            {
                return null;
            }
        }

        public void Remove(Order id)
        {
            Order DeleteOrder = _Context.Orders.Find(id);
            DeleteOrder.IsDElete = true;
            _Context.SaveChanges();
        }

        public void Update(Order order)
        {
            Order updateOrder = _Context.Orders.FirstOrDefault(x => x.Id == order.Id);
            updateOrder.Quantity = order.Quantity;
            updateOrder.Menu= order.Menu;
            updateOrder.OrderDate = order.OrderDate;
            updateOrder.Reservations = order.Reservations;
            _Context.SaveChanges();
        }
    }
}
