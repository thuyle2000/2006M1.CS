using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_class
{
    //lop con Student
    class Student : Person
    {
        public int mark;

        public Student() : base(){
            mark = 40;
        }

        public Student(string id, string name, DateTime dob, int mark): base(id, name, dob)
        {
            this.mark = mark;
        }


        public override void Input()
        {
            base.Input();
            Console.Write(" nhap diem thi: ");
            mark = Convert.ToInt32(Console.ReadLine().Trim());
        }

        public override string ToString()
        {
            return string.Format("id={0}, ten={1}, ngay sinh={2:dd-MMM-yyyy}, diem={3}", id, name, dob, mark);
        }

    }
}
