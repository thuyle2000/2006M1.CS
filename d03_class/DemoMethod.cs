using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_class
{
    class DemoMethod
    {
        internal void fn1(int a, int b, int r1, int r2, int r3 )
        {
            r1 = a + b;
            r2 = a - b;
            r3 = a * b;
        }

        internal void fn2(int a, int b, ref int r1, ref int r2, ref int r3)
        {
            r1 = a + b;
            r2 = a - b;
            r3 = a * b;
        }

        internal void fn3(int a, int b, out int r1, out int r2, out int r3)
        {
            r1 = a + b;
            r2 = a - b;
            r3 = a * b;
        }


        //demo overloading method
        internal void fnAdd(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2} ",a,b, a+b);
        }

        internal void fnAdd(int a, int b, int c)
        {
            Console.WriteLine("{0} + {1} +{2}= {3} ", a, b, c, a + b + c);
        }

        internal void fnAdd(string a, string b)
        {
            Console.WriteLine("{0} + {1} = {2} ", a, b , a + ", "+ b);
        }

    }
}
