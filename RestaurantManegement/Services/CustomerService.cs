using RestaurantManegement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManegement.Services
{
    internal class CustomerService : IBaseService<Customer>
    {
        private readonly ApplicationDbContext _context;
        public CustomerService( ApplicationDbContext context)
        {
            _context = new ApplicationDbContext();
        }
        public void Add(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }

        public Customer Get(int id)
        {
           var customer= _context.Customers.FirstOrDefault(x => x.Id == id);
            return customer;
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = _context.Customers.Where(x => x.IsDElete == false).ToList();
            if (customers.Count>0)
            {
                return customers;
            }
            else
            {
                return null;
            }
            
        }

        public void Remove(Customer customer)
        {
            var deleteCustomer=_context.Customers.FirstOrDefault(x=>x.Id == customer.Id);
            if (deleteCustomer != null)
            {
                deleteCustomer.IsDElete = true;
                _context.SaveChanges();
            }
        }

        public void Update(Customer customer)
        {
            Customer cs = _context.Customers.FirstOrDefault(x => x.Id == customer.Id);
            cs.Email=customer.Email;
            cs.Adres=customer.Adres;
            cs.Phone=customer.Phone;
            _context.SaveChanges();
        }
    }
}
