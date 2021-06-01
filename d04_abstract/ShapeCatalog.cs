using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d04_abstract
{
    //Lop quan ly danh sach cac doi tuong hinh hoc
    public class ShapeCatalog
    {
        //tuong tu generic ArrayList java
        List<Shape> ds = new List<Shape>();
        
        //ham them 1 doi tuong hinh hoc voi bien [ds]
        public void Insert(Shape sh)
        {
            ds.Add(sh);
            Console.WriteLine("Insert succeeded !");
        }

        //ham in ra danh sach cac doi tuong hinh hoc da luu trong ht [ds]
        public void Display()
        {
            if(ds.Count == 0)
            {
                Console.WriteLine("No Data !");
                return;
            }

            Console.WriteLine("\n List of Shapes: ");
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }

        }

        //ham in ra danh sach cac hinh tron
        public void DisplayCircle()
        {
            if(ds.Count == 0)
            {
                Console.WriteLine("No data !");
                return;
            }

            int cntCircle = 0;
            foreach (var item in ds)
            {
                if(item is Circle)
                {
                    Console.WriteLine(item);
                    cntCircle++;
                }
            }//ket thuc for

            if (cntCircle == 0)
            {
                Console.WriteLine("Not found CirCle !!!");
            }
        }


        public void Menu()
        {
            string op = null;
            while (true)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Insert Circle");
                Console.WriteLine("2. Insert Rectangle" );
                Console.WriteLine("3. Display all Shapes");
                Console.WriteLine("4. Display all Circles");
                Console.WriteLine("5. Quit");

                Console.Write("Plz enter your choice [1-5]: ");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        Circle c = new Circle();
                        c.Input();
                        Insert(c);
                        break;
                    case "2":
                        Rectangle r = new Rectangle();
                        r.Input();
                        Insert(r);
                        break;
                    case "3":
                        Display();
                        break;
                    case "4":
                        DisplayCircle();
                        
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice !!!");
                        break;
             
                }

            }
        }


    }
}
