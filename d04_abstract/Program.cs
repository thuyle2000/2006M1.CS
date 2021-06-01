using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d04_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCatalog sc = new ShapeCatalog();
            sc.Menu();
        }

        static void TestCase()
        {
            Circle c = new Circle();
            c.Input();
            Console.WriteLine(c);

            Rectangle r = new Rectangle();
            r.Input();
            Console.WriteLine(r);
        }
    }
}
