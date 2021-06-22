using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson4
{
    public class Thesis : Book
    {
        private int citation;
        public int Citation
        {
            get { return this.citation; }
            set { this.citation = value; }
        }
    }
}
