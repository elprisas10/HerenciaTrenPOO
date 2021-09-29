using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTrenPOO
{
    //INTEGRANTES: Wilber Jose Jimenez Ramirez-SMIS058221 y Jonathan Elias Gamez Larin-SMIS017821
    class Freght :Train
    {
        public string Capacity { get; set; }

        public int Carriages { get; set; }

        public Boolean Hazardous { get; set; }

        public string Speed { get; set; }

        public string Set_Hazardous()
        {
            var Integridad = "";
            if (Hazardous == true)
            {
                Integridad = "El tren es seguro ";
            }
            else
            {
                Integridad = "El tren no es seguro ";

            }

            return "La capacidad que tiene el tren es indicada y " + Capacity + Carriages + " vagones " + Integridad + Speed;
        }



    }
}
