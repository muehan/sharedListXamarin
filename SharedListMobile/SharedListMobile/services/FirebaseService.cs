using System.Collections.Generic;
using Firebase.Xamarin.Database;
using Firebase.Xamarin.Database.Query;
using System.Diagnostics;
using System.Linq;
using Firebase.Xamarin.Auth;

namespace SharedListMobile.services
{
    public class FirebaseService
    {
        public async void Init()
        {
            var firebase = new FirebaseClient("https://sharedlist-40f8d.firebaseio.com");

            var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBBeAqd9qBd_H_JkU5b3YVvWRIFqewqiE0"));

            var user = await authProvider.SignInWithEmailAndPasswordAsync("yourEmail", "yourPassword");

            Debug.WriteLine($"user: {user.User.Email}");

            IReadOnlyCollection<FirebaseObject<ShoppingItem>> items = await firebase
              .Child("sharedList/shoppingList")
              .WithAuth(user.FirebaseToken)
              .OnceAsync<ShoppingItem>();

            Debug.WriteLine($"item count {items.Count}");

            foreach (var item in items)
            {
                Debug.WriteLine($"{item.Key} name is {item.Object.value}");
            }
        }
    }

    public class ShoppingLists
    {
        public IEnumerable<ShoppingItem> ShoppingItems { get; set; }
    }

    public class ShoppingItem
    {
        public string key { get; set; }

        public string value { get; set; }
    }
}
