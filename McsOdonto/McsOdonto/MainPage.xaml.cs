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
            Opacity = 0.5;
            await Navigation.PushModalAsync(new FrmPagos());
            Opacity = 1;
        }


        private async void BtnCitas_Clicked(object sender, EventArgs e)
        {
            Opacity = 0.5;
            await Navigation.PushModalAsync(new FrmCitas());
            Opacity = 1;
        }
    }
}
