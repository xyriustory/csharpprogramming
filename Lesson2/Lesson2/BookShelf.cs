using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Lesson2
{
    class BookShelf
    {
        List<Book> books = new List<Book>();
        private int num;
        public int Num
        {
            get { return this.num; }
            set { this.num = value; }
        }
        public void Action()
        {
            Console.WriteLine(">>操作番号を入力してください");
            Console.WriteLine(">>1. 追加　2. 削除　3. 検索　4. 保存　5. 読み込み");
            this.Num = int.Parse(Console.ReadLine());

            switch(this.Num)
            {
                case 1:
                    Console.WriteLine(">>1. 追加");
                    Book mybook = new Book();
                    mybook.Register();
                    books.Add(mybook);
                    break;

                case 2:
                    Console.WriteLine(">>2. 削除");
                    Console.WriteLine(">>削除する本の番号を入力してください");
                    int delnum;
                    delnum = int.Parse(Console.ReadLine()) + 1; // 削除する本のインデックス
                    books.RemoveAt(delnum);
                    break;

                case 3:
                    Console.WriteLine(">>3. 検索");
                    Console.WriteLine(">>検索する本のタイトルを入力してください");
                    string searchtitle;
                    searchtitle = Console.ReadLine();
                    var foundbooks = books.FindAll(book => book.Title == searchtitle);
                    Console.WriteLine(">>検索結果は以下の{0}件です",foundbooks.Count);
                    if (foundbooks.Count != 0)
                    {
                        var i = 1;
                        foreach(Book foundbook in foundbooks)
                        {
                            Console.Write(i + "：");
                            Console.WriteLine(foundbook.Title);
                            Console.WriteLine("   著者：" + foundbook.Author);
                            i++;
                        }
                    } else
                    {
                        Console.WriteLine("見つかりませんでした");
                    }
                    break;

                case 4:
                    Console.WriteLine(">>4. 保存");
                    string wfileName = @"C:\Users\秋山怜穏\Desktop\sample.xml";
                    var xsw = new XmlSerializer(typeof(List<Book>));
                    var sw = new StreamWriter(wfileName, false, new UTF8Encoding(false));
                    xsw.Serialize(sw, books);
                    sw.Close();
                    Console.WriteLine("保存が完了しました");
                    break;

                case 5:
                    Console.WriteLine(">>5. 読み込み");
                    string rfileName = @"C:\Users\秋山怜穏\Desktop\sample.xml";
                    var xsr = new XmlSerializer(typeof(List<Book>));
                    var sr = new FileStream(rfileName, FileMode.Open);
                    List<Book> bs = new List<Book>();
                    bs = (List<Book>)xsr.Deserialize(sr);
                    sr.Close();
                    foreach(Book book in bs)
                    {
                        book.Show();
                    }
                    Console.WriteLine("読み込みが完了しました");

                    break;
            }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine(">>現在の本棚");
            var i = 1;
            foreach(Book book in books)
            {
                Console.Write(i + "：");
                Console.WriteLine(book.Title);
                i++;
            }
            Console.WriteLine("---------------------------------\n");
        }

    }
}
