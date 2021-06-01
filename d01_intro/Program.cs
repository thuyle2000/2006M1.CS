using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d01_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Nghia !");
            Console.WriteLine(@"Anh 2 \ ne !");

            demo();

            //Console.ReadKey();
        }

        static void demo()
        {           
            Console.Write("nhap ten sinh vien : ");
            string name = Console.ReadLine();
 
            Console.Write("nhap ngay sinh [yyyy-mm-dd] : ");
            DateTime dob = DateTime.Parse(Console.ReadLine().Trim());
            int age = DateTime.Now.Year - dob.Year;

            Console.Write("nhap diem : ");
            float mark= float.Parse(Console.ReadLine().Trim());

            Console.WriteLine("\n Thong tin sinh vien ");
            Console.WriteLine(" ten: {0}, diem: {1:0.00}, ngay sinh: {2:ddd, dd MMM yyyy}, tuoi: {3}", name, mark, dob, age);

        }
    }
}
