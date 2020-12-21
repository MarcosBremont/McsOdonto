using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace McsOdonto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btnpagos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FrmPagos());
        }

        private async void BtnCitas_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FrmCitas());
        }
    }
}
