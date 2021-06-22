using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Microsoft.VisualBasic.PowerPacks;

namespace Lesson5
{
    public class Parts
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public Point PanelPoint { get; set; }
        public List<Guid> StartLineIDs { get; set; }
        public List<Guid> EndLineIDs { get; set; }
        
        public Guid panelID { get; set; }
        public Parts()
        {
            StartLineIDs = new List<Guid>();
            EndLineIDs = new List<Guid>();
            panelID = Guid.NewGuid();

        }

    }
}
