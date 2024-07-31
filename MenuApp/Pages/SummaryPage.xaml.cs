using MenuApp.BusinessLogic;

namespace MenuApp.Pages;

public partial class SummaryPage : ContentPage

{
    public Manager m;
    public Bill b;
    public SummaryPage(Manager manager, Bill bill)
    {
        InitializeComponent();
        m = manager;
        b = bill;
        Checkout();
        
    }

    public void Checkout()
    {
        newItemsPrice.Text = $"Items Price: {b.ItemsPrice()}";
    }

}