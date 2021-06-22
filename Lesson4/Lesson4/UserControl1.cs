using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4
{
    public partial class UserControl1 : UserControl
    {
        public Form1 mainform;
        public Book book;
        public Bookshelf bookshelf;
        public List<UserControl1> ctrlList1;



        public UserControl1()
        {
            InitializeComponent();
            book = new Book();
            book.Title = "";
            book.Author = "";
            book.Year = 0;
            book.Color = "白";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            book.Title = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainform.DeletePanel1(this);
            bookshelf.books.Remove(this.book);
            ctrlList1.Remove(this);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            book.Author = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            book.Year = int.Parse(textBox3.Text);
        }
    }
}
