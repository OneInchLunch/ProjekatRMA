using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjekatRMA.Views
{
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
        InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        private void ToScanner(object sender, EventArgs e)
        {
            if (!LeftToVote.voted)
                Application.Current.MainPage.Navigation.PushAsync(new ScannerPage());
            else
                DisplayAlert("Greška", "Već ste glasali", "Ok");
        }   
    }
}
