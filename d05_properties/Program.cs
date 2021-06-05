using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //testProperty();
            testIndexer();
        }

        static void testProperty()
        {
            Product p = new Product();

            p.id = "P01"; // ham setter cua property pid lam viec: "P01"=> value
            Console.WriteLine("Ma san pham: {0}" , p.id); //ham getter cua pid lam viec

            p.pname = "banh #abc";
            Console.WriteLine("Ten san pham: {0}", p.pname);

            p.pprice = 10001;
            Console.WriteLine("Don gia: {0}", p.pprice);


            //tao bien doi tuong Product p2 bang cu phap cua object initializer
            Product p2 = new Product { id="P02", pname="ga ran", pprice=10 };
            Console.WriteLine("Thong tin san pham : {0}", p2);
            //Console.WriteLine("id: {0}, ten: {1}, don gia: {2}", p2.id, p2.pname, p2.pprice);

        }

        static void testIndexer()
        {
            IndexerDemo demo = new IndexerDemo();

            //doc 5 so nguyen to dau tien tu indexer thu 1 cua mang a[] thuoc doi tuong IndexerDemo 
            Console.WriteLine(">> 5 so nguyen to dau tien: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($" {demo[i]} ");
            }

            //them 1 sinh vien vo ds cua doi tuong demo, thong qua write-only property pds
            Student sv = new Student { id = "S30", name="Minh Bui" };
            demo.pds = sv;

            //truy xuat thong tin co ma so "S30", thong qua read-only indexer
            string id = "S30";
            Console.WriteLine($"\n>>Ten cua sinh vien co ma so {id}: {demo[id]}");

        }
    }
}
