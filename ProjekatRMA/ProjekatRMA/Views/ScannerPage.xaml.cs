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

        bool qrScanned = false;
        private void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                string varText = result.Text;
                if (!qrScanned && varText == "http://en.m.wikipedia.org")
                {
                    qrCode.Text = "QR kod: OK";
                    qrScanned = true;
                }
                else if (!qrScanned)
                    qrCode.Text = "QR kod: Not OK";
                else if (qrScanned && varText != "0000000000000")
                    barCode.Text = "Bar kod: Skenirajte bar kod na vašoj ličnoj karti";
                else if (qrScanned && varText == "0000000000000")
                {
                    Navigation.PushAsync(new FormView());
                    Navigation.RemovePage(this);
                }
            });
        }
    }
}