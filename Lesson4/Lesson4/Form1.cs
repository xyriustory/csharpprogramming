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
using System.Xml.Serialization;

namespace Lesson4
{
    public partial class Form1 : Form
    {
        public Bookshelf mybookshelf = new Bookshelf();
        public List<UserControl1> ctrlList1 = new List<UserControl1>();
        public List<UserControl2> ctrlList2 = new List<UserControl2>();
        public List<UserControl3> ctrlList3 = new List<UserControl3>();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        public UserControl1 AddControlToPanel(Book book)
        {
            UserControl1 ctrl1 = new UserControl1();
            ctrl1.textBox1.Text = book.Title;
            ctrl1.textBox2.Text = book.Author;
            ctrl1.textBox3.Text = book.Year.ToString();
            ctrlList1.Add(ctrl1);
            flowLayoutPanel1.Controls.Add(ctrl1);
            ctrl1.mainform = this;
            ctrl1.ctrlList1 = ctrlList1;
            ctrl1.bookshelf = mybookshelf;
            return ctrl1;
        }

        public UserControl2 AddControl2ToPanel(Thesis thesis)
        {
            UserControl2 ctrl2 = new UserControl2();
            ctrl2.textBox1.Text = thesis.Title;
            ctrl2.textBox2.Text = thesis.Author;
            ctrl2.textBox3.Text = thesis.Year.ToString();
            ctrl2.textBox4.Text = thesis.Citation.ToString();
            ctrlList2.Add(ctrl2);
            flowLayoutPanel1.Controls.Add(ctrl2);
            ctrl2.mainform = this;
            ctrl2.ctrlList2 = ctrlList2;
            ctrl2.bookshelf = mybookshelf;
            return ctrl2;
        }
        public UserControl3 AddControl3ToPanel(Magazine magazine)
        {
            UserControl3 ctrl3 = new UserControl3();
            ctrl3.textBox1.Text = magazine.Title;
            ctrl3.textBox2.Text = magazine.Author;
            ctrl3.textBox3.Text = magazine.Year.ToString();
            ctrl3.textBox4.Text = magazine.Publisher;
            ctrlList3.Add(ctrl3);
            flowLayoutPanel1.Controls.Add(ctrl3);
            ctrl3.mainform = this;
            ctrl3.ctrlList3 = ctrlList3;
            ctrl3.bookshelf = mybookshelf;
            return ctrl3;
        }

        public UserControl1 AddnewControlToPanel(UserControl1 ctrl1)
        {
            ctrl1.textBox1.Text = ctrl1.book.Title;
            ctrl1.textBox2.Text = ctrl1.book.Author;
            ctrl1.textBox3.Text = ctrl1.book.Year.ToString();
            ctrlList1.Add(ctrl1);
            mybookshelf.books.Add(ctrl1.book);
            flowLayoutPanel1.Controls.Add(ctrl1);
            ctrl1.mainform = this;
            ctrl1.ctrlList1 = ctrlList1;
            ctrl1.bookshelf = mybookshelf;
            return ctrl1;
        }

        public UserControl2 AddnewControl2ToPanel(UserControl2 ctrl2)
        {
            ctrl2.textBox1.Text = ctrl2.thesis.Title;
            ctrl2.textBox2.Text = ctrl2.thesis.Author;
            ctrl2.textBox3.Text = ctrl2.thesis.Year.ToString();
            ctrl2.textBox4.Text = ctrl2.thesis.Citation.ToString();
            ctrlList2.Add(ctrl2);
            mybookshelf.books.Add(ctrl2.thesis);
            flowLayoutPanel1.Controls.Add(ctrl2);
            ctrl2.mainform = this;
            ctrl2.ctrlList2 = ctrlList2;
            ctrl2.bookshelf = mybookshelf;
            return ctrl2;
        }
        public UserControl3 AddnewControl3ToPanel(UserControl3 ctrl3)
        {
            ctrl3.textBox1.Text = ctrl3.magazine.Title;
            ctrl3.textBox2.Text = ctrl3.magazine.Author;
            ctrl3.textBox3.Text = ctrl3.magazine.Year.ToString();
            ctrl3.textBox4.Text = ctrl3.magazine.Publisher;
            ctrlList3.Add(ctrl3);
            mybookshelf.books.Add(ctrl3.magazine);
            flowLayoutPanel1.Controls.Add(ctrl3);
            ctrl3.mainform = this;
            ctrl3.ctrlList3 = ctrlList3;
            ctrl3.bookshelf = mybookshelf;
            return ctrl3;
        }

        public void DeletePanel1(UserControl1 ctrl1)
        {
            flowLayoutPanel1.Controls.Remove(ctrl1);
        }
        public void DeletePanel2(UserControl2 ctrl2)
        {
            flowLayoutPanel1.Controls.Remove(ctrl2);
        }
        public void DeletePanel3(UserControl3 ctrl3)
        {
            flowLayoutPanel1.Controls.Remove(ctrl3);
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ファイルToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void 本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 論文ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 雑誌ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            UserControl1 ctrl1 = new UserControl1();
            AddnewControlToPanel(ctrl1);

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            UserControl2 ctrl2 = new UserControl2();
            AddnewControl2ToPanel(ctrl2);

        }

        private void 雑誌ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UserControl3 ctrl3 = new UserControl3();
            AddnewControl3ToPanel(ctrl3);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool flag = false;
            foreach(UserControl1 ctrl1 in ctrlList1)
            {

                if(ctrl1.book.Title == this.textBox1.Text)
                {
                    flag = true;
                    this.label1.Text = "種類";
                    this.label2.Text = "タイトル";
                    this.label3.Text = "著者";
                    this.label4.Text = "出版年";
                    this.label5.Text = "";
                    this.label7.Text = "本";
                    this.label8.Text = ctrl1.book.Title;
                    this.label9.Text = ctrl1.book.Author;
                    this.label10.Text = ctrl1.book.Year.ToString();
                    this.label12.Text = "";
                    this.label13.Text = "";
                } 
            }
            foreach(UserControl2 ctrl2 in ctrlList2)
            {

                if(ctrl2.thesis.Title == this.textBox1.Text)
                {
                    flag = true;
                    this.label7.Text = "論文";
                    this.label8.Text = ctrl2.thesis.Title;
                    this.label9.Text = ctrl2.thesis.Author;
                    this.label10.Text = ctrl2.thesis.Year.ToString();
                    this.label1.Text = "種類";
                    this.label2.Text = "タイトル";
                    this.label3.Text = "著者";
                    this.label4.Text = "出版年";
                    this.label5.Text = "引用数";
                    this.label12.Text = ctrl2.thesis.Citation.ToString();
                    this.label13.Text = "";
                } 
            }
            foreach(UserControl3 ctrl3 in ctrlList3)
            {

                if(ctrl3.magazine.Title == this.textBox1.Text)
                {
                    flag = true;
                    this.label7.Text = "雑誌";
                    this.label8.Text = ctrl3.magazine.Title;
                    this.label9.Text = ctrl3.magazine.Author;
                    this.label10.Text = ctrl3.magazine.Year.ToString();
                    this.label1.Text = "種類";
                    this.label2.Text = "タイトル";
                    this.label3.Text = "著者";
                    this.label4.Text = "出版年";
                    this.label5.Text = "出版社";
                    this.label12.Text = ctrl3.magazine.Publisher;
                    this.label13.Text = "";
                } 
            }
            if (!flag)
            {
                this.label13.Text = "検索結果はありません";
                this.label1.Text = "";
                this.label2.Text = "";
                this.label3.Text = "";
                this.label4.Text = "";
                this.label5.Text = "";
                this.label7.Text = "";
                this.label8.Text = "";
                this.label9.Text = "";
                this.label10.Text = "";
                this.label12.Text = "";
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int num = mybookshelf.books.Count;
            mybookshelf.Save(@"C:\Users\秋山怜穏\Desktop\sample.xml");
            System.Diagnostics.Debug.WriteLine("6:" + num);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ctrlList1.Clear();
            ctrlList2.Clear();
            ctrlList3.Clear();
          

            mybookshelf.Read(@"C:\Users\秋山怜穏\Desktop\sample.xml");
            int num = mybookshelf.books.Count;
        
            System.Diagnostics.Debug.WriteLine("4:" + num);
            for (int i = 0; i < num; i++)
            {

                //System.Diagnostics.Debug.WriteLine(mybookshelf.books[i].GetType());
                string type = mybookshelf.books[i].GetType().ToString();
                if (type == "Lesson4.Book")
                {
                    //System.Diagnostics.Debug.WriteLine(mybookshelf.books[i].Title);
                    AddControlToPanel(mybookshelf.books[i]);
                }
                else if (type == "Lesson4.Thesis")
                {
                    //System.Diagnostics.Debug.WriteLine(mybookshelf.books[i].Title);
                    AddControl2ToPanel((Thesis)mybookshelf.books[i]);
                }
                else if (type == "Lesson4.Magazine")
                {
                    //System.Diagnostics.Debug.WriteLine(mybookshelf.books[i].Title);
                    AddControl3ToPanel((Magazine)mybookshelf.books[i]);
                }
            }
            System.Diagnostics.Debug.WriteLine("5:" + num);
        }
    }
}