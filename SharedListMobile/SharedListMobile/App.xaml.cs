using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharedListMobile.services;
using Xamarin.Forms;


namespace SharedListMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SharedListMobile.MainPage();
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
