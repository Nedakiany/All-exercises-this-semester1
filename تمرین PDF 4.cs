using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Session_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Brand ="Toyota";
            car.Speed =150;
        }
    }
    public class Car
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public Car(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
            MessageBox.Show("Car created : Brand - " + Brand + ", Speed : - " + Speed + " km/h");
        }

        public Car()
        {
        }

        ~Car()
        {
            MessageBox.Show("Car desrtoyed : Brand - " + Brand + ", Speed - " + Speed + "km/h");
        }
    }
}
