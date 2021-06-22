using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Microsoft.VisualBasic.PowerPacks;

namespace Lesson5
{
    public class Connection
    {
        public string Type { get; set; }
        public Guid StartControlID { get; set; }
        public Guid EndControlID { get; set; }
        
    }
}
