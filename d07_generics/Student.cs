using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d07_generics
{
    //dinh nghia Student la class generic co 2 tham so kieu: A ap dung cho id, B ap dung cho mark
    public class Student<A, B>
    {
        public A id;
        public string name;
        public B mark;

        public override string ToString()
        {
            return string.Format($"id={id}, ho ten={name}, diem kq ={mark}");
        }
    }


    //su dung lop generic
    public class DemoGeneric
    {
        public void test()
        {
            Student<int, int> sv1 = new Student<int, int> { id = 100, name = "thanh sang", mark = 99 };
            Student<int, string> sv2 = new Student<int, string> { id = 101, name = "hoang duy", mark = "B+" };
            Student<string, float> sv3 = new Student<string, float> { id = "sv12", name = "xuan phat", mark = 99.9f };

            Console.WriteLine("Thong tin sinh vien: ");
            Console.WriteLine(sv1);
            Console.WriteLine(sv2);
            Console.WriteLine(sv3);
        }

        public void testMethodGeneric()
        {

            List<string> ds1 = new List<string> { "hien", "nghia", "sang", "duy", "thinh", "phat", "nhan", "chien", "vinh" };
            List<Student<int, int>> ds2 = new List<Student<int, int>> {
                new Student<int, int>{id=100, name="minh nhut", mark=60},
                new Student<int, int>{id=101, name="vuong", mark=90},
                new Student<int, int>{id=102, name="minh", mark=67},
                new Student<int, int>{id=200, name="nam", mark=50}
             };

            int[] ds3 = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };

            MyLib lib = new MyLib();

            //lib.display(ds3, "Cac so nguyen to dau tien");
            //lib.display(ds2);
            //lib.display(ds1,"Danh sach thanh vien");

            lib.show(ds3, "\n * Day so nguyen to *");
            lib.show(ds2, "\n * Danh sach sinh vien *");
            lib.show(ds1, "\n * Danh sach nhan vien *");
        }
    }


    public class MyLib
    {
        //public void display(List<string> ds, string title = "Danh sach ten nhan vien")
        //{
        //    Console.WriteLine(title);
        //    foreach (var item in ds)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public void display(List<Student<int, int>> ds, string title = "Danh sach sinh vien")
        //{
        //    Console.WriteLine(title);
        //    foreach (var item in ds)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public void display(int[] ds, string title = "Day so nguyen to")
        //{
        //    Console.WriteLine(title);
        //    foreach (var item in ds)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}


        //gom 3 phuong thuc overload tren thanh 1 phuong thuc generic
        public void show<T> (T ds, string title) where T:System.Collections.IEnumerable
        {
            Console.WriteLine(title);
            foreach (var item in ds)
            {
                Console.WriteLine($"\t {item}");
            }
        }

    }
}
