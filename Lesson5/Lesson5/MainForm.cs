using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Microsoft.VisualBasic.PowerPacks;

namespace Lesson5
{
    public partial class MainForm : Form
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public UserControl1 StartControl { get; set; }
        public UserControl1 EndControl { get; set; }
        public Dictionary<Guid, LineShape> lineDics { get; set; }
        public Dictionary<Guid, UserControl1> panelDics { get; set; }
        public MainForm()
        {
            InitializeComponent();
            lineDics = new Dictionary<Guid, LineShape>();
            panelDics = new Dictionary<Guid, UserControl1>();
            ShapeContainer Canvas = new ShapeContainer();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void 部品追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddPartsForm();
        }

        public void OpenAddPartsForm()
        {
            AddPartsForm addPartsForm = new AddPartsForm();
            addPartsForm.parentPanel = mainPanel;
            addPartsForm.parentForm = this;
            addPartsForm.Show();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            List<Parts> partsList = new List<Parts>();
            List<Connection> connectionList = new List<Connection>();
            foreach(Control ctrl in mainPanel.Controls)
            {
                if (ctrl.GetType() == typeof(UserControl1))
                {
                    UserControl1 ctrl1 = (UserControl1)ctrl;
                    partsList.Add(ctrl1.parts);
                }
            }
            foreach (Control ctrl in mainPanel.Controls)
            {
                if (ctrl.GetType() == typeof(ConnectionControl))
                {
                    ConnectionControl connectionControl = (ConnectionControl)ctrl;
                    connectionList.Add(connectionControl.connection);
                }
            }
            AllList allList = new AllList();
            allList.partsList = partsList;
            allList.connectionList = connectionList;
            string fileName = @"C:\Users\秋山怜穏\Desktop\PartsConnection.xml";
            var xsw = new XmlSerializer(typeof(AllList));
            var sw = new StreamWriter(fileName, false, new UTF8Encoding());
            xsw.Serialize(sw, allList);
            sw.Close();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            panelDics.Clear();
            lineDics.Clear();
            string fileName = @"C:\Users\秋山怜穏\Desktop\PartsConnection.xml";
            var xsr = new XmlSerializer(typeof(AllList));
            var sr = new FileStream(fileName, FileMode.Open);
            AllList allList = new AllList();
            allList = (AllList)xsr.Deserialize(sr);
            foreach(Parts parts in allList.partsList)
            {
                UserControl1 ctrl1 = new UserControl1();
                ctrl1.parts.Name = parts.Name;
                ctrl1.parts.Weight = parts.Weight;
                ctrl1.parts.Type = parts.Type;
                ctrl1.parts.Color = parts.Color;
                ctrl1.parts.PanelPoint = parts.PanelPoint;
                ctrl1.parts.panelID = parts.panelID;
                ctrl1.parentPanel = mainPanel;
                ctrl1.parentForm = this;
                panelDics.Add(ctrl1.parts.panelID, ctrl1);
                mainPanel.Controls.Add(ctrl1);
                ctrl1.Location = ctrl1.parts.PanelPoint;
                ctrl1.ShowName();
            }
            foreach(Connection connection in allList.connectionList)
            {
                ShapeContainer Canvas = new ShapeContainer();
                Canvas.Parent = mainPanel;
                LineShape lineShape = new LineShape();
                lineShape.Parent = Canvas;
                lineShape.StartPoint = panelDics[connection.StartControlID].Location + new Size(44, 22);
                lineShape.EndPoint = panelDics[connection.EndControlID].Location + new Size(44, 22);
                
                Guid ID = Guid.NewGuid();
                panelDics[connection.StartControlID].parts.StartLineIDs.Add(ID);
                panelDics[connection.EndControlID].parts.EndLineIDs.Add(ID);
                lineDics.Add(ID, lineShape);
                
                ConnectionControl connectionctrl = new ConnectionControl();
                connectionctrl.connection = connection;
                connectionctrl.parentForm = this;
                mainPanel.Controls.Add(connectionctrl);
                connectionctrl.ShowLabel();
            }
            sr.Close();
        }

        public void Connect()
        {
            Connection connection = new Connection();
            ShapeContainer Canvas = new ShapeContainer();
            Canvas.Parent = mainPanel;
            LineShape lineShape = new LineShape();
            lineShape.Parent = Canvas;
            connection.StartControlID = StartControl.parts.panelID;
            connection.EndControlID = EndControl.parts.panelID;
            connection.Type = "接続関係";
            lineShape.StartPoint = panelDics[connection.StartControlID].Location + new Size(44, 22);
            lineShape.EndPoint = panelDics[connection.EndControlID].Location + new Size(44, 22);
            Guid ID = Guid.NewGuid();
            StartControl.parts.StartLineIDs.Add(ID);
            EndControl.parts.EndLineIDs.Add(ID);
            lineDics.Add(ID, lineShape);
            ConnectionControl connectionctrl = new ConnectionControl();
            connectionctrl.connection = connection;
            connectionctrl.parentForm = this;
            mainPanel.Controls.Add(connectionctrl);
            connectionctrl.ShowLabel();
        }

        public void DeleteConnection(ConnectionControl ctrl)
        {
            mainPanel.Controls.Remove(ctrl);
        }
    }
}
