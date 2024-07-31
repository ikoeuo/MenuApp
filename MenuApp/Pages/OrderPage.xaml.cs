using MenuApp.BusinessLogic;
using MenuApp.Pages;
using System.Collections.ObjectModel;

namespace MenuApp.NewFolder;

public partial class OrderPage : ContentPage
{
    public Manager m;

    public Bill b;
    public List<Dish> selectedDish {  get; set; }
	public ObservableCollection<Dish> Dishes {  get; set; }
    public Command<Dish> AddCommand { get; }

    public OrderPage(Manager manager ,Bill bill)
	{
        InitializeComponent();
        m = manager;
        b = bill;
        menu();
        selectedDish = new List<Dish>();
        Dishes = new ObservableCollection<Dish>(m.GetListDishes());
        AddCommand = new Command<Dish>(AddToOrder);
        BindingContext = this;

    }

    public void showOrderClicked(object sender, EventArgs e) //goes to next page if 1 or more item is clicked, otherwise gives alert
    {
		if (m.GetSelectedDishes().Count > 0) 
		{
			Navigation.PushAsync(new ViewOrderPage(m, b));
		}
		else
		{
			DisplayAlert("Order Empty", "Please select an item", "OK");
		}

	}

	public void menu() //adds food items to menu and clears menu so it doesn't keep adding the same dishes :D
    {
        m.dishes.Clear(); 

        m.AddDish(new Dish("Burger", 14.99, "Classic burger with bacon and cheese", "burger.jpg"));
        m.AddDish(new Dish("Grilled Veggies", 12.99, "Grilled veggies with choice of sauce", "grilled.jpg"));
        m.AddDish(new Dish("Pasta", 18.99, "Pasta with cheese spread and Egg", "noodle.jpg"));
        m.AddDish(new Dish("Pizza", 14.99, "Classic pepperoni pizza", "pizza.png"));
        m.AddDish(new Dish("Veggie Salad", 14.99, "Veggie salad with choice of sauce", "salad.jpg"));
    }

	public void AddToOrder(Dish dish)//adds food items to order
	{
        m.AddSelected(dish);
        DisplayAlert("Dish Added", $"{dish.Name} has been added to order.", "OK");
    }
}

