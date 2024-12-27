using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Session_5
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
            car.Drive();
        }
    }
    public class Vehicle
    {
        public virtual void Drive()
        {
           Console.WriteLine("Vehicle is driving");
        }
    }
    public class Car : Vehicle
    {
        public override void Drive()
        {
            MessageBox.Show("Car is driving");
        }
    }
 
}
