using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5
{
    public partial class EditPartsForm : Form
    {
        public UserControl1 parentControl;
        public string color;
        public EditPartsForm()
        {
            InitializeComponent();
        }

        private void EditPartsForm_Load(object sender, EventArgs e)
        {

        }

        public void ShowData()
        {
            textBox1.Text = parentControl.parts.Name;
            textBox2.Text = parentControl.parts.Weight.ToString();
            comboBox1.Text = parentControl.parts.Type;
            color = parentControl.parts.Color;
            button2.BackColor = ColorTranslator.FromHtml(parentControl.parts.Color);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentControl.parts.Name = textBox1.Text;
            parentControl.parts.Weight = int.Parse(textBox2.Text);
            parentControl.parts.Type = comboBox1.Text;
            parentControl.parts.Color = color;
            parentControl.ShowName();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Button colorbutton = (Button)sender;
                Color c = colorDialog1.Color;
                color = String.Format("#{0:X2}{1:X2}{2:X2}", c.R, c.G, c.B);
                colorbutton.BackColor = ColorTranslator.FromHtml(color);
            }
        }
    }
}
