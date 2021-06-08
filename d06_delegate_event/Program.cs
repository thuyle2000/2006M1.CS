using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_delegate_event
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDelegate();
            TestEvent();
        }

        static void TestDelegate()
        {
            int n1, n2;
            while (true)
            {
                try
                {
                    Console.Write("Nhap so nguyen thu 1: ");
                    n1 = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e )
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhap so nguyen thu 2: ");
                    n2 = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }


            MyMath m = new MyMath();

            //khoi tao delegate F, va gan dia chi ham cong 2 so cho delegate nay
            F myDelegate = new F(m.Add);
            //myDelegate(n1, n2);

            //myDelegate = m.Mul;
            //myDelegate(n1, n2);

            myDelegate += m.Mul;
            myDelegate += MyMath.Sub;
            myDelegate += MyMath.Div;

            myDelegate(n1, n2);   // thuc hien 4 ham cong, nhan, tru va chia
            Console.WriteLine("==============================");

            //rut dia chi ham nhan va tru ra khoi [myDelegate]
            myDelegate -= m.Mul;
            myDelegate -= MyMath.Sub;
            myDelegate(n1, n2);    // thuc hien 2 ham cong va chia





        }

        static void TestEvent()
        {
            DemoEvent o = new DemoEvent();
            o.demo();
        }
    }
}
