using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Firebase.Xamarin.Database;
using SharedListMobile.services;

namespace SharedListMobile.ViewModel
{
    public class ShoppingListViewModel
    {
        public ObservableCollection<ShoppingItem> ShoppingItems { get; set; }

        public ShoppingListViewModel()
        {
            var service = new FirebaseService();
            Task<IReadOnlyCollection<FirebaseObject<ShoppingItem>>> items = service.GetShoppingListItems();

            ShoppingItems = new ObservableCollection<ShoppingItem>();

            foreach (var firebaseObject in items.Result)
            {
                ShoppingItems.Add(firebaseObject.Object);
            }
        }
    }
}
