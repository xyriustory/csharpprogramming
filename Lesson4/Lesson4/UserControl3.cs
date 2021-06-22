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
    public partial class UserControl3 : UserControl
    {
        public Form1 mainform;
        public Magazine magazine;
        public Bookshelf bookshelf;
        public List<UserControl3> ctrlList3;

        public UserControl3()
        {
            InitializeComponent();
            magazine = new Magazine();
            magazine.Title = "";
            magazine.Author = "";
            magazine.Year = 0;
            magazine.Publisher = "";
            magazine.Color = "白";
        }
        public void GetMagazine()
        {
            magazine.Title = textBox1.Text;
            magazine.Author = textBox2.Text;
            magazine.Year = int.Parse(textBox3.Text);
            magazine.Publisher = textBox4.Text;

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            magazine.Publisher = textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            magazine.Year = int.Parse(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            magazine.Author = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            magazine.Title = textBox1.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainform.DeletePanel3(this);
            ctrlList3.Remove(this);
            bookshelf.books.Remove(this.magazine);
        }
    }
}
