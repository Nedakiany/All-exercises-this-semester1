using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Session_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle car = new Car ();
            car.Move();
            Vehicle bicycle = new Bicycle();
            bicycle.Move();
        }
    }
    public  interface IOperations
    {
        int Add(int a, int b);
        int Substract(int a, int b);
    }
    public class Calculator : IOperations
    {
        public int Add (int a, int b)
        {
            return a + b;
        }
        public int Substract(int a, int b)
        {
            return a - b;
        }
    }
    public abstract  class Vehicle
        {
            public abstract void Move();
        }
    public class Car : Vehicle
    {
        public override void Move()
        {
            MessageBox.Show("Car is moving");
        }
    }
    public class Bicycle : Vehicle
    {
        public override void Move()
        {
            MessageBox.Show("Bicycle is moving");
        }
    }
}
