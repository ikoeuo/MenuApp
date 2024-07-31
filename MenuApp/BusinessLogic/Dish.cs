using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp.BusinessLogic
{
    public class Dish
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    

        public Dish(string name, double price, string description, string image)
        {
            Name = name;
            Price = price;
            Description = description;
            Image = image;

        }
    }
}
