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

        double ItemsPrice
        {
            get { return SelectedItems.Sum(dish => dish.Price); }
        }

        double HST 
        {
            get {return ItemsPrice * 0.13; }
        }
        double Tip 
        { 
            get {return ItemsPrice * 0.05;  }
        }
        
        double TotalPrice
        {
            get { return ItemsPrice + HST + Tip; }
        }

        public Bill(List<Dish> selectedItems)
        {
            SelectedItems = selectedItems ?? new List<Dish>();
        }

    }
}
