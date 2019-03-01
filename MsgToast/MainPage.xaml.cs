using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Widget;
using Xamarin.Forms;

namespace MsgToast
{
    public partial class MainPage : ContentPage , IMensagem
    {
        void cliqueCurto(object sender, System.EventArgs e)
        {
            Shorttime("Testando tempo curto");
        }

        void cliqueLongo(object sender, System.EventArgs e)
        {
            Longtime("Testando tempo longo");
        }

        public void Longtime(string msg)
        {
            Toast.MakeText(Android.App.Application.Context, msg, ToastLength.Long).Show();
        }

        public void Shorttime(string msg)
        {
            Toast.MakeText(Android.App.Application.Context, msg, ToastLength.Short).Show();
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
