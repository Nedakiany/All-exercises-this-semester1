using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Session_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car();
                {
                    car.brand = "Toyota";
                    car.speed = 150;
                }
                car.PrintInfo();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show (ex .Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
    public class Car
    {
        public  string brand;
        public int speed;
        public int MaxSpeed = 200;
        public int MinSpeed = 0;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }

        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if(value >= MinSpeed && value <= MaxSpeed)
                {
                    speed = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Speed must be between 0 and 200");
                }
            }
        }
        public void PrintInfo()
        {
            MessageBox.Show($"Brand:{Brand},Speed:{Speed}");
        }
    }
}
