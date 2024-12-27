using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic_Session_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            IShape ishape = null;
            if (radioButton1.Checked)
            {
                double radius;
                if(double .TryParse (textBox1.Text, out radius))
                {
                    ishape = new Circle(radius);
                }
                else
                {
                    MessageBox.Show("لطفا شعاع معتبر وارد کنید");
                    return;
                }
            }
            else if (radioButton2.Checked)
            {
                double width, height;
                if (double .TryParse (textBox2.Text,out width)&& double .TryParse (textBox3.Text,out height))
                {
                    ishape = new Rectangle(width, height);
                }
                else
                {
                    MessageBox.Show("لطفا عرض و ارتفاع معتبر وارد کنید");
                    return;
                }
            }
            if (ishape != null)
            {
                double area = ishape.CalculateArea();
                label1.Text = $"مساحت:{area}";
            }
            else
            {
                MessageBox.Show("لطفا نوع شکل را انتخاب کنید");
            }
        }

    }
    public interface IShape 
    {
        double CalculateArea();
    }
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle (double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
        public Rectangle (double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
