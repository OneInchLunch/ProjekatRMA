using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjekatRMA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Final : ContentPage
    {
        public Final()
        {
            InitializeComponent();
            results.ItemsSource = LeftToVote.Rezultati;
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void Zavrsi_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SplashScreen());
        }
    }
}