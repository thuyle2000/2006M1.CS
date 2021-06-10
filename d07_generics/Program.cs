using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d07_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            testGeneric();
        }

        static void testGeneric()
        {
            DemoGeneric dg = new DemoGeneric();
            //dg.test();
            dg.testMethodGeneric();

        }
    }
}
