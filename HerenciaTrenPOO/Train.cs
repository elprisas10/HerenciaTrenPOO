using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTrenPOO
{
    //INTEGRANTES: Wilber Jose Jimenez Ramirez-SMIS058221 y Jonathan Elias Gamez Larin-SMIS017821
    class Train
    {
        public string Starting_From { get; set; }

        public string Terminating { get; set; }

        public string Journey_time { get; set; }

       public string getInfo()
        {
            return Starting_From + Terminating + Journey_time;
        }


        public string Set_start()
        {
            return "El transporte que fue utilizado fue un tren";
        }

        public string Get_start()
        {
            return "Y este viaja directamente hasta Aclajuta";
        }

        public string Get_Journey_time()
        {
            return "y el tiempo de viaje estimado que se toma es de 40 minutos";
        }
    }

 
  
}
