using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Session_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle myCar = new Vehicle();
            myCar.Start();
            Vehicle myBike = new Vehicle();
            myBike.Start();
        }
    }
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is driving");
        }
    }
    public class Car : Vehicle
    {
        public override void Start()
        {
            MessageBox.Show("Car is driving");
        }
    }
    public class Bike : Vehicle 
    {
        public override void Start()
        {
            MessageBox.Show("Bike is driving");
        }
    }
}
