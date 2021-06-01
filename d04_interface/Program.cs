using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d04_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Input();

            Employee e2 = new Employee();
            e2.Input();

            Console.WriteLine(e1);
            Console.WriteLine(e2);
        }
    }
}
