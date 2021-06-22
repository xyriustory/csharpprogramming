using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson4
{
    public class Magazine : Book
    {
        private string publisher;
        public string Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }
    }
}
