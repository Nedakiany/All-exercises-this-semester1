using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            int charCount = userInput.Length;
            label1.Text = $"تعداد کاراکتر ها :{charCount}";

            if (userInput.Contains("CSharp"))
            {
                MessageBox.Show("رشته شامل 'CSharp' است");
            }
            else
            {
                MessageBox.Show("رشته شامل 'CSharp' نیست");
            }
            char[] chars = userInput.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            MessageBox.Show($"رشته معکوس :{reversed }");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
