using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_class
{
    class Person
    {
        public string id, name;
        public DateTime dob;

        public Person()
        {
            id = "P01";
            name = "Nghia";
            dob = new DateTime(2000, 9, 20); //yyyy-MM-dd
        } 

        public Person(string id, string name, DateTime birthday)
        {
            this.id = id;
            this.name = name;
            dob = birthday;
        }

        public virtual void Input()
        {
            Console.Write(" Nhap id: ");
            id = Console.ReadLine().Trim();
            Console.Write(" Nhap ten: ");
            name = Console.ReadLine().Trim();
            Console.Write(" Nhap ngay sinh [yyyy-MM-dd]: ");
            dob = DateTime.Parse(Console.ReadLine().Trim());
        }

        //private void Output()
        void Output()
        {
            Console.WriteLine("Thong tin ca nhan");
            Console.WriteLine(" id : {0}", id);
            Console.WriteLine(" ho ten : {0}", name);
            Console.WriteLine(" ngay sinh : {0}", dob);
        }

    }
}
