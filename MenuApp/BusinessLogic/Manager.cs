using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp.BusinessLogic
{
    public class Manager
    {
        internal List<Dish> dishes;
        internal List<Dish> selectedDishes;
        public Manager()
        {
            dishes = new List<Dish>();
            selectedDishes = new List<Dish>();

        }

        public void Add(Dish dish)
        {
            dishes.Add(dish);
        }

        public List<Dish> GetListDishes()
        {
            return new List<Dish>(dishes);
        }

        public List<Dish> GetSelectedDishes()
        {
            return new List<Dish>(selectedDishes);
        }

        public void Remove(Dish dish)
        {
            selectedDishes.Remove(dish);
        }

    }

}
