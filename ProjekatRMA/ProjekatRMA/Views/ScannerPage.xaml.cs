using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjekatRMA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScannerPage : ContentPage
    {
        public ScannerPage()
        {
            InitializeComponent();
        }
        private void GetIp()
        {
            ipAddress.Text = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
        }
        private void ToFormView(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FormView());
        }


        private void OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() => {
                GetIp();
                scanResultText.Text = result.Text + " (type: " + result.BarcodeFormat + ")";
                Navigation.PushAsync(new FormView());
            });

        }
    }
}