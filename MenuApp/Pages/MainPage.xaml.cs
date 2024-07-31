using MenuApp.BusinessLogic;
using MenuApp.NewFolder;

namespace MenuApp
{
    public partial class MainPage : ContentPage
    {
        public Manager m;
        public Bill b;
        public MainPage(Manager manager, Bill bill)
        {
            InitializeComponent();
            m = new Manager();
            b = new Bill();
        }

        public void StartOrderClicked(object sender, EventArgs e)//navigates to the order page
        {
                Navigation.PushAsync(new OrderPage(m, b));

        }
    }

}
