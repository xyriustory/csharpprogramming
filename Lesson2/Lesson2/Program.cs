using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book mybook1 = new Book();
            //mybook1.Register();
            //Console.WriteLine("");
            //mybook1.Show();

            //Book mybook2 = new Thesis();
            //mybook2.Register();
            //Console.WriteLine("");
            //mybook2.Show();

            //Book mybook3 = new Magazine();
            //mybook3.Register();
            //Console.WriteLine("");
            //mybook3.Show();

            BookShelf mybookshelf = new BookShelf();
            while (true)
            {
                mybookshelf.Action();

                mybookshelf.Show();
            }



        }
    }
}
