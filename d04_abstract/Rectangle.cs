using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d04_abstract
{
    public class Rectangle : Shape
    {
        public float w, h;

        public override float Calc_Area()
        {
            return w*h;
        }

        public override float Calc_Peripheral()
        {
            return (w+h)*2;
        }

        public override string ToString()
        {
            return string.Format("W ={0:0.00}, H ={1:0.00}, Area ={2:0.00}, Per ={3:0.00}",w, h, Calc_Area(), Calc_Peripheral());
        }


        public void Input()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input Width W: ");
                    w = float.Parse(Console.ReadLine().Trim());
                    if (w <= 0)
                    {
                        throw new Exception("W cannot <= 0 !!!");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }


            while (true)
            {
                try
                {
                    Console.Write("Input Heigth H: ");
                    h = float.Parse(Console.ReadLine().Trim());
                    if (h <= 0)
                    {
                        throw new Exception("H cannot <= 0 !!!");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }
        }
    }
}
