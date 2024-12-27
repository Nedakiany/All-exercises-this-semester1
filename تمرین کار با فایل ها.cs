using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        private string filePath = "userData.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string age = textBox2.Text;

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{name},{age}");
                }
                MessageBox.Show("اطلاعات ذخیره شد");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"خطا در ذخیره اطلاعات:{ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    MessageBox.Show("اطلاعات بازیابی شد و در کنسول نمایش داده شد.");
                }
                else
                {
                    MessageBox.Show("فایل وجود ندارد");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بازیابی اطلاعات : {ex.Message }");
            } 
        }
    }
}
