using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lesson4
{
    public class Bookshelf
    {

        public List<Book> books = new List<Book>();
        
        public void AddBook(Book mybook)
        {
            books.Add(mybook);
        }
        public void AddThesis(Thesis mythesis)
        {
            books.Add(mythesis);
        }
        public void AddMagazine(Magazine mymagazine)
        {
            books.Add(mymagazine);
        }

        public void Save(string fileName)
        {

            var xsw = new XmlSerializer(typeof(List<Book>), new Type[] {typeof(Thesis), typeof(Magazine) });
            var sw = new StreamWriter(fileName, false, new UTF8Encoding());
            xsw.Serialize(sw, books);
            sw.Close();
        }

        public void Read(string fileName)
        {
            books.Clear();
            var xsr = new XmlSerializer(typeof(List<Book>), new Type[] { typeof(Thesis), typeof(Magazine) });
            var sr = new FileStream(fileName, FileMode.Open);
            books.Clear();
            books = (List<Book>)xsr.Deserialize(sr);
            sr.Close();
        }
    }
}
