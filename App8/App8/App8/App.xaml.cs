using System;
using Xamarin.Forms;
using App8;
using Xamarin.Forms.Xaml;
using App8.Models;

namespace App8
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Hotels();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
