using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


namespace Lesson3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine("test");
        }

        public class SampleClass
        {
            private List<int> month = new List<int>();
            private List<int> day = new List<int>();
            private List<int> price = new List<int>();
            private List<string> itm =  new List<string>();
            private List<string> income = new List<string>();
            private List<string> comment = new List<string>();

            public List<int> Month
            {
                set { this.month = value; }
                get { return this.month; }
            }
            public List<int> Day
            {
                set { this.day = value; }
                get { return this.day; }
            }
            public List<int> Price
            {
                set { this.price = value; }
                get { return this.price; }
            }
            public List<string> Itm
            {
                set { this.itm = value; }
                get { return this.itm; }
            }
            public List<string> Income
            {
                set { this.income = value; }
                get { return this.income; }
            }
            public List<string> Comment
            {
                set { this.comment = value; }
                get { return this.comment; }
            }
        }

        private void 読込ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                while(dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
                SampleClass obj = new SampleClass();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SampleClass));
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                obj = (SampleClass)xmlSerializer.Deserialize(fileStream);
                fileStream.Close();
                
                int i;
                for(i = 0; i < obj.Month.Count; i++)
                {
                    if(obj.Month[i] == null)
                    {
                        obj.Month[i] = 0;
                    }
                    if (obj.Day[i] == null)
                    {
                        obj.Day[i] = 0;
                    }
                    if (obj.Price[i] == null)
                    {
                        obj.Price[i] = 0;
                    }
                    if (obj.Itm[i] == null)
                    {
                        obj.Itm[i] = "";
                    }
                    if (obj.Income[i] == null)
                    {
                        obj.Income[i] = "";
                    }
                    if (obj.Comment[i] == null)
                    {
                        obj.Comment[i] = "";
                    }
                    dataGridView1.Rows.Add(obj.Month[i], obj.Day[i], obj.Price[i], obj.Itm[i], obj.Income[i], obj.Comment[i]);
                }
            }
        }

        public void dataToObj(SampleClass obj)
        {
            int i;
            
            for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1[0, i].Value != null)
                {
                    obj.Month.Add(Convert.ToInt32(dataGridView1[0, i].Value));
                }
                else
                {
                    obj.Month.Add(0);
                }
                if (dataGridView1[1, i].Value != null)
                {
                    obj.Day.Add(Convert.ToInt32(dataGridView1[1, i].Value));
                }
                else 
                {
                    obj.Day.Add(0);
                }
                if (dataGridView1[2, i].Value != null)
                {
                    obj.Price.Add(Convert.ToInt32(dataGridView1[2, i].Value));
                }
                else
                {
                    obj.Price.Add(0);
                }
                if (dataGridView1[3, i].Value != null)
                {
                    obj.Itm.Add((dataGridView1[3, i].Value).ToString());
                }
                else
                {
                    obj.Itm.Add("");
                }
                if (dataGridView1[4, i].Value != null)
                {
                    obj.Income.Add((dataGridView1[4, i].Value).ToString());
                }
                else
                {
                    obj.Income.Add("");
                }
                if (dataGridView1[5, i].Value != null)
                {
                    obj.Comment.Add((dataGridView1[5, i].Value).ToString());
                }
                else
                {
                    obj.Comment.Add("");
                }
                
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xmlファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SampleClass obj = new SampleClass();
                dataToObj(obj);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SampleClass));
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                xmlSerializer.Serialize(fileStream, obj);
                fileStream.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SampleClass obj = new SampleClass();
            dataToObj(obj);

            List<int> sum = new List<int>();
            for (int i = 0; i < 12; i++)
            {
                sum.Add(0);
            }
            for (int i = 0; i < obj.Month.Count; i++)
            {
                switch (obj.Month[i])
                {
                    case 0:
                        sum[0] += obj.Price[i];
                        break;
                    case 1:
                        sum[1] += obj.Price[i];
                        break;
                    case 2:
                        sum[2] += obj.Price[i];
                        break;
                    case 3:
                        sum[3] += obj.Price[i];
                        break;
                    case 4:
                        sum[4] += obj.Price[i];
                        break;
                    case 5:
                        sum[5] += obj.Price[i];
                        break;
                    case 6:
                        sum[6] += obj.Price[i];
                        break;
                    case 7:
                        sum[7] += obj.Price[i];
                        break;
                    case 8:
                        sum[8] += obj.Price[i];
                        break;
                    case 9:
                        sum[9] += obj.Price[i];
                        break;
                    case 10:
                        sum[10] += obj.Price[i];
                        break;
                    case 11:
                        sum[11] += obj.Price[i];
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < 12; i++)
            {
                dataGridView2[i, 0].Value = sum[i];
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SampleClass obj = new SampleClass();
            dataToObj(obj);

            List<int> sum = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                sum.Add(0);
            }
            for (int i = 0; i < obj.Itm.Count; i++)
            {
                switch (obj.Itm[i])
                {
                    case "食費":
                        sum[0] += obj.Price[i];
                        break;
                    case "通信費":
                        sum[1] += obj.Price[i];
                        break;
                    case "交通費":
                        sum[2] += obj.Price[i];
                        break;
                    case "その他":
                        sum[3] += obj.Price[i];
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                dataGridView3[i, 0].Value = sum[i];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
