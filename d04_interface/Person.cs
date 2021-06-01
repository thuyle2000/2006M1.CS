using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d04_interface
{
    public class Person
    {
        public string id, name, address;
        public int salary;


        public virtual void Input()
        {
            Console.WriteLine("Input id: "); id = Console.ReadLine().Trim();
            Console.WriteLine("Input name: "); name = Console.ReadLine().Trim();
            Console.WriteLine("Input address: "); address = Console.ReadLine().Trim();
            while (true)
            {
                try
                {
                    Console.WriteLine("Input salary >0 :");
                    salary = int.Parse(Console.ReadLine().Trim());
                    if (salary > 0) break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }

        }
    }
}
