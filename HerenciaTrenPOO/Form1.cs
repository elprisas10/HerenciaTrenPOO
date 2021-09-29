using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaTrenPOO
{

    //INTEGRANTES: Wilber Jose Jimenez Ramirez-SMIS058221 y Jonathan Elias Gamez Larin-SMIS017821
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Freght freght = new Freght();

            freght.Starting_From = "El tren comenzo a andar desde Sonsonate ";
            freght.Terminating = "y termino su recorrido en Aclajuta ";
            freght.Journey_time = "y tardo 40 minutos ";

            freght.Capacity = "Tiene una capacidad de 50 personas y de ";
            freght.Carriages = 5;
            freght.Hazardous = true;
            freght.Speed = " y tiene una velocidad 200 km/h";

            Passenger passenger = new Passenger();

            passenger.First_class = " Subieron 34 pasajeros ";
            passenger.Carriages = " Bajaron 22 pasajeros ";
            passenger.Catering = true;
            passenger.Money = 3;


            MessageBox.Show(freght.Set_start());
            MessageBox.Show(freght.Get_start());
            MessageBox.Show(freght.Get_Journey_time());
            MessageBox.Show(freght.getInfo());
            MessageBox.Show(freght.Set_Hazardous());
            MessageBox.Show(passenger.get_first_class());



        }
    }
}
