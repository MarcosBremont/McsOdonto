using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using McsOdonto.Modelo;
using Xamarin.Forms;

namespace McsOdonto
{
    public partial class FrmCitas : ContentPage
    {
        private static bool banderaClick;

        public FrmCitas()
        {
            InitializeComponent();
            Title = "Ejemplo ListView 2";
            banderaClick = true;
        }

        protected override async void OnAppearing()
        {
            LlenarMenu();
            await Task.Yield();
        }

        public async void LlenarMenu()
        {
            //ListView2 oEjemploListView1Model = new ListView2();
            //ListView22.ItemsSource = null;
            //ListView22.ItemsSource = oEjemploListView1Model.ObtenerMenuEjemplo1();
            //ListView22.ItemSelected += OnClickOpcionSeleccionada;
        }

        private async void OnClickOpcionSeleccionada(object sender, SelectedItemChangedEventArgs e)
        {
            if (banderaClick)
            {
                var item = e.SelectedItem as Pacientes;
                if ((item != null) && (item.Habilitado))
                {
                    var oSeleccionado = item.Nombre;
                    banderaClick = false;

                    await Task.Run(async () =>
                    {
                        await Task.Delay(500);
                        banderaClick = true;
                    });

                }
            } // fin banderaCL
        }
    }
}
