using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace d02_basic
{
    class Example
    {
        internal void demoSwitch()
        {
            Console.WriteLine("Demo SWITCH");
            Console.WriteLine("===========");
            Console.Write(" nhap 1 so nguyen [1-7]:  ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("From Wednesday to Friday");
                    break;
                case 6:
                case 7: Console.WriteLine("Weekend !"); break;
                default: Console.WriteLine("UNKNOWN !!!"); break;
            }
        }

        internal void demoFOR()
        {
            /* In ra khoi so nhu ben duoi
             * 
             * 54341 : dong i=0, in j=5 so (5->1) , j= 5-0 = 5-i
             * 4321  : dong i=1, in j=4 so (4->1) , j= 5-1 = 5-i
             * 321   : dong i=2, in 3 so
             * 21    : dong i=3, in 2 so
             * 1     : dong i=4, in 1 so
             * 
             * 12345
             * 2345
             * 345
             * 45
             * 5
             * 
             */

            for (int i = 0; i < 5; i++)            {                for (int j = 5 - i; j > 0; j--)                {                    Console.Write(j);                }                Console.WriteLine();            }
            Console.WriteLine();


            for (int i = 0; i <= 5; i++)            {                for (int j = 1 + i; j <= 5; j++)                {                    Console.Write(j);                }                Console.WriteLine();            }            Console.ReadLine();



        }


        internal void demoDOWHILE()
        {
            //kiem tra ma so sv co hop le ko ? (ST-xxxx)
            string id = null;
            do {
                Console.Write("nhap ma so sinh vien (ST-xxxx) : ");
                id = Console.ReadLine().Trim();

                if(Regex.IsMatch(id, "^ST-\\d{4}$"))
                {
                    break;  // nhap dung dinh dang -> thoat vong lap
                }
                Console.WriteLine("Ma so ko hop le, vui long nhap lai !!!");
            } while (true);

            Console.WriteLine(">> Ma so sinh vien : {0}", id);

        }


        internal void demoWHILE()
        {
            // kiem tra diem thi duoc nhap co hop le ko [0-100] ?
            int mark = 0;
            while (true)
            {
                try
                {
                    Console.Write("Nhap diem thi [0-100]: ");
                    mark = Convert.ToInt32(Console.ReadLine().Trim());
                    if (mark < 0 || mark > 100)
                    {
                        throw new Exception("Diem ko hop le !!!");                      
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }              
            }
            Console.WriteLine(" >> Diem thi : {0}", mark);
            
        }
    }

}
