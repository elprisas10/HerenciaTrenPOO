using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTrenPOO
{
    //INTEGRANTES: Wilber Jose Jimenez Ramirez-SMIS058221 y Jonathan Elias Gamez Larin-SMIS017821
    class Passenger
    {
        public string First_class { get; set; }

        public string Carriages { get; set; }

        public Boolean Catering { get; set; }

        public int Money { get; set; }

        public string get_first_class()
        {
            var Pasajeros = "";
            if (Catering == true)
            {
                Pasajeros = "Hay pasajeros en este tren, ";
            }
            else
            {
                Pasajeros = "No hay pasajeros en este tren ";
            }
            return "Hay espacio para los pasajeros, " + First_class + Carriages + Pasajeros + " y Deberan pagar " + Money + " $ por el viaje " ;

        }

    }
}
