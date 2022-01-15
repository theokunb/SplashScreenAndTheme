using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SplashScreen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();


            await Task.WhenAll(
                SplashGrid.FadeTo(0, 2000),
                icon.ScaleTo(10, 2000)
                );
        }
    }
}
