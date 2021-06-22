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
    public partial class ConnectionControl : UserControl
    {
        public MainForm parentForm;
        public Connection connection { get; set; }
        public ConnectionControl()
        {
            InitializeComponent();
        }

        public void ShowLabel()
        {
            label1.Text = connection.Type;
            SetLocation();
        }
        public void SetLocation()
        {
            UserControl1 startCtrl = parentForm.panelDics[connection.StartControlID];
            UserControl1 endCtrl = parentForm.panelDics[connection.EndControlID];
            Location = new Point((startCtrl.Location.X + endCtrl.Location.X) / 2, (startCtrl.Location.Y + endCtrl.Location.Y) / 2);
        }

        private void 編集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEditConnectionForm();
        }

        private void OpenEditConnectionForm()
        {
            EditConnectionForm editConnectionForm = new EditConnectionForm();           
            editConnectionForm.parentControl = this;
            editConnectionForm.Show();
            editConnectionForm.ShowData();
        }

        private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parentForm.DeleteConnection(this);
        }
    }
}
