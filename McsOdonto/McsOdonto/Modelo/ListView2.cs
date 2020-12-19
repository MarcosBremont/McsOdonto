using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace McsOdonto.Modelo
{
    public class ListView2
    {
        public ListView2()
        {

        }

        public ObservableCollection<Pacientes> ObtenerMenuEjemplo1()
        {
            ObservableCollection<Pacientes> oMenuPrincipal = new ObservableCollection<Pacientes>();

            oMenuPrincipal.Add(new Pacientes
            {
                Nombre = "Diego Armando Lira Rodríguez",
                Habilitado = true,
                Telefono = "809-574-5689",
                Celular = "809-985-9632",
                Direccion = "Medina, #46, Jarabacoa, Rep Dom.",
                FechaCita = "19/01/2020",
                HoraCita = "10:35 AM",
                TotalDinero = 35000,
                Abono = 3500,
            });

            oMenuPrincipal.Add(new Pacientes
            {
                Nombre = "Diego Armando Lira Rodríguez",
                Habilitado = true,
                Telefono = "809-574-6325",
                Celular = "829-325-1147",
                Direccion = "La Piña, #6, Jarabacoa, Rep Dom.",
                FechaCita = "20/02/2020",
                HoraCita = "09:35 AM",
                TotalDinero = 35000,
                Abono = 7500,
            });

            oMenuPrincipal.Add(new Pacientes
            {
                Nombre = "Diego Armando Lira Rodríguez",
                Habilitado = true,
                Telefono = "809-574-6325",
                Celular = "829-325-1147",
                Direccion = "La Piña, #6, Jarabacoa, Rep Dom.",
                FechaCita = "19/03/2020",
                HoraCita = "12:35 AM",
                TotalDinero = 35000,
                Abono = 1500,
            });

            oMenuPrincipal.Add(new Pacientes
            {
                Nombre = "Diego Armando Lira Rodríguez",
                Habilitado = true,
                Telefono = "809-574-6325",
                Celular = "829-325-1147",
                Direccion = "La Piña, #6, Jarabacoa, Rep Dom.",
                FechaCita = "19/04/2020",
                HoraCita = "11:35 AM",
                TotalDinero = 35000,
                Abono = 2000,
            });

            oMenuPrincipal.Add(new Pacientes
            {
                Nombre = "Diego Armando Lira Rodríguez",
                Habilitado = true,
                Telefono = "809-574-4751",
                Celular = "809-652-7541",
                Direccion = "Hato Viejo, #17, Jarabacoa, Rep Dom.",
                FechaCita = "19/05/2020",
                HoraCita = "05:30 PM",
                TotalDinero = 35000,
                Abono = 1500,
            });

            oMenuPrincipal.Add(new Pacientes
            {
                Nombre = "Diego Armando Lira Rodríguez",
                Habilitado = true,
                Telefono = "809-574-5689",
                Celular = "809-985-9632",
                Direccion = "Medina, #46, Jarabacoa, Rep Dom.",
                FechaCita = "19/06/2020",
                HoraCita = "04:35 PM",
                TotalDinero = 35000,
                Abono = 3500,
            });



            return oMenuPrincipal;


        } // Fin del método ObtenerMenu

    }
}
