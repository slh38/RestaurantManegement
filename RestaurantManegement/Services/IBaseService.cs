using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManegement.Services
{
    public  interface IBaseService<T>
    {
        public void Add(T item);
        public void Update(T item);
        public void Remove(T id);
        public List<T> GetAll();
        public T Get(int id);
    }
}
