using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.demo2();


        }

        void demo1()
        {
            DemoMethod d1 = new DemoMethod();
            int a = 30, b = 20;
            int r1 = 0, r2 = 0, r3 = 0;

            Console.WriteLine("a={0}, b={1}, r1={2}, r2={3}, r3={4} \n", a, b, r1, r2, r3);

            d1.fn1(a, b, r1, r2, r3);
            Console.WriteLine("After call fn1(): r1={0}, r2={1}, r3={2} \n", r1, r2, r3);


            d1.fn2(a, b, ref r1, ref r2, ref r3);
            Console.WriteLine("After call fn2(): r1={0}, r2={1}, r3={2} \n", r1, r2, r3);

            int z1, z2, z3;
            d1.fn3(a, b, out z1, out z2, out z3);
            Console.WriteLine("After call fn3(): z1={0}, z2={1}, z3={2} \n", z1, z2, z3);

            d1.fnAdd(a, b);
            d1.fnAdd(a, b, 30);
            d1.fnAdd("Nguyen", "The Hien");
            Console.WriteLine();
        }

        void demo2()
        {
            Student sv1 = new Student();
            Student sv2 = new Student("SV01", "Nguyen Hoang Duy", new DateTime(2005, 2, 25), 70);
            Student sv3 = new Student();
            sv3.Input();

            Console.WriteLine("Sinh vien 1: {0}", sv1);
            Console.WriteLine("Sinh vien 2: {0}", sv2);
            Console.WriteLine("Sinh vien 3: {0}", sv3);
        }
    }

}
