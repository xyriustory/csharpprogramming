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
    public partial class AddPartsForm : Form
    {
        public MainForm parentForm;
        public Panel parentPanel;
        public Parts parts;
        public string color;

        public AddPartsForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPartsToMainForm();
        }

        public void AddPartsToMainForm()
        {
            UserControl1 ctrl1 = new UserControl1();
            ctrl1.parentForm = parentForm;
            ctrl1.parts.Name = textBox1.Text;
            ctrl1.parts.Weight = int.Parse(textBox2.Text);
            ctrl1.parts.Type = comboBox1.Text;
            ctrl1.parts.Color = color; 
            ctrl1.parts.PanelPoint = ctrl1.Location;
            ctrl1.parts.panelID = Guid.NewGuid();
            parentForm.panelDics.Add(ctrl1.parts.panelID, ctrl1);
            ctrl1.parentPanel = parentPanel;
            parentPanel.Controls.Add(ctrl1);
            ctrl1.ShowName();
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
