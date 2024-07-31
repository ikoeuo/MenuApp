using MenuApp.BusinessLogic;
using MenuApp.Pages;
using System.Collections.ObjectModel;

namespace MenuApp.NewFolder;

public partial class ViewOrderPage : ContentPage
{
    public Manager? m;

    public Bill? b;
    public ObservableCollection<Dish> SelectedDishes { get; set; }
    public Command<Dish> RemoveCommand { get; }

    public ViewOrderPage(Manager manager, Bill bill)
    {
        InitializeComponent();
        m = manager;
        b = bill;
        SelectedDishes = new ObservableCollection<Dish>(m.GetSelectedDishes());
        RemoveCommand = new Command<Dish>(RemoveFromOrder); //when buttons are clicked dishes are removed from the order
        BindingContext = this;
     }

    public void addMoreItemsBtnClicked(object sender, EventArgs e) //navigates back to order page
    {
        Navigation.PushAsync(new OrderPage(m, b));
    }

    public void checkoutBtnClicked(object sender, EventArgs e) // navigates to view order page to show bill :)
    {
        if (m.GetSelectedDishes().Count > 0)
        {
            Navigation.PushAsync(new SummaryPage(m, b));
        }
        else
        {
            DisplayAlert("Order Empty", "Please go back and select an item", "OK");
        }
    }
    public void RemoveFromOrder(Dish dish) //removes items from order when they are clicked
    {
        m.RemoveDish(dish);
        SelectedDishes.Remove(dish);
        DisplayAlert("Dish Removed", $"{dish.Name} has been removed from order.", "OK");
    }
}