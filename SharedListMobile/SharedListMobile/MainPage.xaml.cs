using SharedListMobile.ViewModel;
using Xamarin.Forms;

namespace SharedListMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new ShoppingListViewModel();
        }
    }
}
