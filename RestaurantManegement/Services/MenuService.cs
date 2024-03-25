using RestaurantManegement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManegement.Services
{
    public class MenuService : IBaseService<Menu>
    {
        private readonly ApplicationDbContext _Context;
        public MenuService()
        {
            _Context = new ApplicationDbContext();
        }
        public void Add(Menu item)
        {
            _Context.Add(item);
            _Context.SaveChanges();
        }

        public Menu Get(int id)
        {
            var menuId = _Context.Menus.FirstOrDefault(x => x.Id == id);
            return menuId;
        }

        public List<Menu> GetAll()
        {
            List<Menu> list = _Context.Menus.Where(x => x.IsDElete == false).ToList();
            return list;
        }

        public void Remove(Menu id)
        {
            Menu deleteMenu = _Context.Menus.Find(id);
            deleteMenu.IsDElete = true;
            _Context.SaveChanges();
        }

        public void Update(Menu menu)
        {
            Menu updateMenu = _Context.Menus.Find(menu.Id);
            updateMenu.Title= menu.Title;
            updateMenu.Description = menu.Description;
            updateMenu.Price=menu.Price;
            _Context.SaveChanges();
        }
    }
}
