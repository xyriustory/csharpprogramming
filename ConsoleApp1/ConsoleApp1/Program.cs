using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        private string title; // タイトル
        private string author; // 著者
        private string year; // 出版年
        private string color; // 色

        public Book()
        {
            this.color = "白";
        }
        public string Title
        {
            set { this.title = value; }
            get { return this.title;  }
        }

        public string Author
        {
            set { this.author = value; }
            get { return this.author; }
        }

        public string Year
        {
            set { this.year = value; }
            get { return this.year; }
        }

        public string Color
        {
            set { this.color = value; }
            get { return this.color; }
        }

    }

    class MainClass
    {
        static void Main()
        {
            Book mybook = new Book();
            Console.WriteLine(">>本を登録します");
            Console.WriteLine(">>タイトルを入力してください");
            mybook.Title = Console.ReadLine();
            Console.WriteLine(">>著者を入力してください");
            mybook.Author = Console.ReadLine();
            Console.WriteLine(">>出版年を入力してください");
            mybook.Year = Console.ReadLine();

            Console.WriteLine("\n>>本を登録しました。");
            Console.WriteLine(">>タイトル：" + mybook.Title);
            Console.WriteLine(">>著者：" + mybook.Author);
            Console.WriteLine(">>出版年：" + mybook.Year);
            Console.WriteLine(">>紙の色：" + mybook.Color);
        }
        
    }

    
        

}
