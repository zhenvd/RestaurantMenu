using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuItem
    {
        string NameOfItem;
        string Description;
        string Category;
        double Price;
        DateTime CreationDate = DateTime.Today;

        public MenuItem(string name, string desc, string category, double price)
        {
            NameOfItem = name;
            Description = desc;
            Category = category;
            Price = price;
        }
    }
}
