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
    public partial class UserControl2 : UserControl
    {
        public Form1 mainform;
        public Thesis thesis;
        public Bookshelf bookshelf;
        public List<UserControl2> ctrlList2;
        public bool addPanel = false;
        public UserControl2()
        {
            InitializeComponent();
            thesis = new Thesis();
            thesis.Title = "";
            thesis.Author = "";
            thesis.Year = 0;
            thesis.Citation = 0;
            thesis.Color = "白";

        }
        public Thesis GetThesis()
        {
            thesis.Title = textBox1.Text;
            thesis.Author = textBox2.Text;
            thesis.Year = int.Parse(textBox3.Text);
            thesis.Citation = int.Parse(textBox4.Text);

            return thesis;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            thesis.Citation = int.Parse(textBox4.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            thesis.Year = int.Parse(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            thesis.Author = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            thesis.Title = textBox1.Text;
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

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainform.DeletePanel2(this);
            ctrlList2.Remove(this);
            bookshelf.books.Remove(this.thesis);
        }
    }
}
