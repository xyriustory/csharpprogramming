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
    public partial class EditConnectionForm : Form
    {
        public ConnectionControl parentControl;

        public EditConnectionForm()
        {
            InitializeComponent();
        }

        public void ShowData()
        {
            textBox1.Text = parentControl.connection.Type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentControl.connection.Type = textBox1.Text;
            parentControl.ShowLabel();
            Close();
        }
    }
}
