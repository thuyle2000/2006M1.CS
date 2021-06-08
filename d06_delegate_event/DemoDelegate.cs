using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_delegate_event
{
    public delegate void F(int a, int b);
    public class MyMath
    {
        internal void Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        internal static void Sub(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        internal void Mul(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        internal static void Div(int x, int y)
        {
            try
            {
                Console.WriteLine($"{x} / {y} = {x / y}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Loi: {e.Message}");       
            }
            
        }
    }
}
