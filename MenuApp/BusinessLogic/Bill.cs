using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuApp.BusinessLogic
{
    public class Bill
    {
        public List<Dish> SelectedItems { get; set; }

        public double ItemsPrice() //adds up the total price of all of the dishes in the order
        {
            return SelectedItems.Sum(dish => dish.Price);
        }

        public double HST() //calculates tax based on the total price
        {
            return Math.Round((ItemsPrice() * 0.13), 2);
        }
        public double Tip() //calculates tip based on the total price
        {
            return Math.Round((ItemsPrice() * 0.05), 2);
        }
        
        public double TotalPrice() //adds up the total price of all of the dishes in the order, tax, and tip to get the total order price
        {
            return Math.Round((ItemsPrice() + HST() + Tip()), 2); 
        }

        public Bill(List<Dish> selectedItems)
        {
            SelectedItems = selectedItems ?? new List<Dish>();
        }

    }
}
