using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            var sortedEvenNumbers = evenNumbers.OrderBy(n => n);

            var groupedNumbers = sortedEvenNumbers.GroupBy(n => n / 2);

            لیست.Items.Clear();foreach (var group in groupedNumbers)
            {
                لیست.Items.Add($" گروه:{group.Key }");
            }
            لیست.Items.Add(numbers);
        }
    }
}
