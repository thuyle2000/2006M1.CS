using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace d04_interface
{
    public class Employee : Person, ICalculate
    {
        public string level;
        public int wday;

        public override void Input()
        {
            base.Input();

            while (true)
            {
                Console.WriteLine("Input level [A|B|C]: ");
                level = Console.ReadLine().Trim().ToUpper();
                if (Regex.IsMatch(level,"^(A|B|C)$"))
                {
                    break;
                }
            }


            while (true)
            {
                Console.WriteLine("Input worked days [0-30]: ");
                wday = int.Parse(Console.ReadLine().Trim());
                if (wday>=0 && wday<=30)
                {
                    break;
                }
            }
        }

        public float getAllowance()
        {
            float allowance = 100;
            switch (level)
            {
                case "A": allowance = 500; break;
                case "B": allowance = 800; break;
                case "C": allowance = 1000; break;

            }
            return allowance;
        }



        public float getSalary()
        {
            return salary * wday / 26.0f;
        }

        public override string ToString()
        {
            return string.Format("id={0}, name={1}, base-salary={2}, level={3}, worked-days={4}, net-salary={5}", id, name, salary, level, wday, getSalary()+getAllowance());
        }
    }
}
