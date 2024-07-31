using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp.BusinessLogic
{
    public class Bill
    {
        public List<Dish> SelectedItems { get; set; }

        public double ItemsPrice()
        {
            return SelectedItems.Sum(dish => dish.Price);
        }

        public double HST() 
        {
            return ItemsPrice() * 0.13;
        }
        public double Tip()
        {
            return ItemsPrice() * 0.05;
        }
        
        public double TotalPrice()
        {
            return ItemsPrice() + HST() + Tip(); 
        }

        public Bill(List<Dish> selectedItems)
        {
            SelectedItems = selectedItems ?? new List<Dish>();
        }

        public Bill()
        {
        }
    }
}
