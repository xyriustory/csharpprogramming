using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
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

        public virtual void Register()
        {
            Console.WriteLine(">>本を登録します");
            Console.WriteLine(">>タイトルを入力してください");
            this.title = Console.ReadLine();
            Console.WriteLine(">>著者を入力してください");
            this.author = Console.ReadLine();
            Console.WriteLine(">>出版年を入力してください");
            this.year = int.Parse(Console.ReadLine());
            this.color = "白";
        }

        public virtual void Show()
        {
            Console.WriteLine(">>本を登録しました。");
            Console.WriteLine(">>タイトル：{0}", this.Title);
            Console.WriteLine(">>著者：{0}", this.Author);
            Console.WriteLine(">>出版年：{0}", this.Year);
            Console.WriteLine(">>紙の色：{0}", this.Color);
        }
    }

    class Thesis : Book
    {
        private int citation;
        public int Citation
        {
            get { return this.citation; }
            set { this.citation = value; }
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine(">>引用数を入力してください");
            this.Citation = int.Parse(Console.ReadLine());
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine(">>引用数：{0}", this.Citation);
        }
    }
    class Magazine : Book
    {
        private string publisher;
        public string Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine(">>出版社を入力してください");
            this.Publisher = Console.ReadLine();
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine(">>出版社：{0}", this.Publisher);
        }
    }
}
