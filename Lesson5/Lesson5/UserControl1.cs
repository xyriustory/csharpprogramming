using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace Lesson5
{
    public partial class UserControl1 : UserControl
    {
        public MainForm parentForm;
        public Panel parentPanel;
        public Parts parts;

        public UserControl1()
        {
            InitializeComponent();
            parts = new Parts();
        }

        public void ShowName()
        {
            label1.Text = parts.Name;
            label1.BackColor = ColorTranslator.FromHtml(parts.Color);
            BackColor = ColorTranslator.FromHtml(parts.Color);
        }

        private void 編集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEditPartsForm();
        }

        public void OpenEditPartsForm()
        {
            EditPartsForm editPartsForm = new EditPartsForm();
            editPartsForm.parentControl = this;
            editPartsForm.Show();
            editPartsForm.ShowData();
        }
        private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteParts();
        }

        private void DeleteParts()
        {
            foreach (Guid startlineid in parts.StartLineIDs)
            {
                parentForm.lineDics[startlineid].Dispose();
            }
            foreach (Guid endlineid in parts.EndLineIDs)
            {
                parentForm.lineDics[endlineid].Dispose();
            }
            parentPanel.Controls.Remove(this);
        }

        private void コピーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyParts();
        }
        
        private void CopyParts()
        {
            UserControl1 ctrl1 = new UserControl1();
            ctrl1.parts.Name = parts.Name;
            ctrl1.parts.Weight = parts.Weight;
            ctrl1.parts.Type = parts.Type;
            ctrl1.parts.Color = parts.Color;
            ctrl1.parentPanel = parentPanel;
            ctrl1.parentForm = parentForm;
            ctrl1.parts.panelID = Guid.NewGuid();
            parentForm.panelDics.Add(ctrl1.parts.panelID, ctrl1);
            parentPanel.Controls.Add(ctrl1);
            ctrl1.ShowName();
        }
        static bool isDraggable = false;
        static Point MousePoint;
        private void UserControl1_MouseDown(object sender, MouseEventArgs e)
        {
            UserControl1 ctrl1 = (UserControl1)sender;
            if (e.Button == MouseButtons.Left)
            {
                isDraggable = true;
                MousePoint = e.Location;
                SetLineLocation(ctrl1);
                SetLabelLocation(ctrl1);
            }
        }

        private void UserControl1_MouseMove(object sender, MouseEventArgs e)
        {
            UserControl1 ctrl1 = (UserControl1)sender;
            if (isDraggable)
            {
                ctrl1.Location = new Point(ctrl1.Left + e.X - MousePoint.X, ctrl1.Top + e.Y - MousePoint.Y);
            }
            SetLineLocation(ctrl1);
            SetLabelLocation(ctrl1);
        }

        private void UserControl1_MouseUp(object sender, MouseEventArgs e)
        {
            UserControl1 ctrl1 = (UserControl1)sender;
            if (e.Button == MouseButtons.Left)
            {
                isDraggable = false;
                ctrl1.parts.PanelPoint = ctrl1.Location;
            }
            SetLineLocation(ctrl1);
            SetLabelLocation(ctrl1);
        }

        private void SetLineLocation(UserControl1 ctrl1)
        {
            foreach (Guid guid in ctrl1.parts.StartLineIDs)
            {
                parentForm.lineDics[guid].StartPoint = ctrl1.Location + new Size(44, 22);
            }
            foreach (Guid guid in ctrl1.parts.EndLineIDs)
            {
                parentForm.lineDics[guid].EndPoint = ctrl1.Location + new Size(44, 22);
            }
        }

        private void SetLabelLocation(UserControl1 ctrl1)
        {
            foreach(Control ctrl in parentPanel.Controls)
            {
                if(ctrl.GetType() == typeof(ConnectionControl))
                {
                    ConnectionControl connectionControl = (ConnectionControl)ctrl;
                    UserControl1 startCtrl = connectionControl.parentForm.panelDics[connectionControl.connection.StartControlID];
                    UserControl1 endCtrl = connectionControl.parentForm.panelDics[connectionControl.connection.EndControlID];
                    if (startCtrl == ctrl1)
                    {
                        connectionControl.Location = new Point((ctrl1.Location.X +endCtrl.Location.X) / 2, (ctrl1.Location.Y + endCtrl.Location.Y) / 2);

                    }
                    if(endCtrl == ctrl1)
                    {
                        connectionControl.Location = new Point((ctrl1.Location.X +startCtrl.Location.X) / 2, (ctrl1.Location.Y + startCtrl.Location.Y) / 2);
                    }
                    connectionControl.BringToFront();
                }
            }
        }
        private void 線の始点にするToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStartControl();
        }
        private void SetStartControl()
        {
            parentForm.StartControl = this;
        }

        private void 線の終点にするToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SetEndControl();
        }

        private void SetEndControl()
        {
            parentForm.EndControl = this;
            if(parentForm.StartControl != null)
            {
                parentForm.Connect();
            }
            parentForm.StartControl = null;
        }
    }
}
