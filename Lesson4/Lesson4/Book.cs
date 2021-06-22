using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson4
{
    public class Book
    {
        private string title;
        private string author;
        private int year;
        private string color;
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
    }
}
