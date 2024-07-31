using MenuApp.BusinessLogic;
using MenuApp.NewFolder;

namespace MenuApp
{
    public partial class MainPage : ContentPage
    {
        public Manager? m;
        public Bill? b;
        public MainPage()
        {
            InitializeComponent();
            m = new Manager();
        }
        public void StartOrderClicked(object sender, EventArgs e) //navigates to the order page
        {
                Navigation.PushAsync(new OrderPage(m, b));

        }
    }

}
