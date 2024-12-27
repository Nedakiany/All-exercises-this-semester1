using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            {
                book.Title = "Dark Psycholgy";
                book.Author = " Wiliam james";
                book.Year = 1965;
                book.ISBN = 97862256;
            }
            book.PrintInfo();

            Member member = new Member();
            {
            member.MemberID = 1234;
            member.Name = "neda";
            member.Phone = 91640748;
            }
            member.PrintMemberInfo();
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int ISBN { get; set; }

        public Book(string title, string author, int year, int isbn)
        {
            Title = title;
            Author = author;
            Year = year;
            ISBN = isbn;
        }

        public Book()
        {
        }

        public void PrintInfo()
        {
            MessageBox.Show($"Title : {Title}\n Author : {Author}\n Year : {Year}\n ISBN : {ISBN}");
        }
    }
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }

        public Member(int memberID, string name, int phone)
        {
            MemberID = memberID;
            Name = name;
            Phone = phone;
        }

        public Member()
        {
        }

        public void PrintMemberInfo()
        {
            MessageBox.Show($"MemberID:{MemberID}\n Name:{Name}\n Phone:{Phone}");
        }
    }
}
