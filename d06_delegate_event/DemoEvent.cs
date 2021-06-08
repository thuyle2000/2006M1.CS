using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace d06_delegate_event
{

    //1. dinh nghia delegate 
    public delegate void DelegateValidation(string errorMessage);


    public class City
    {
        string id, name;  // id va name co access modifier = private !!!
        int area;

        //2. dinh nghia event lien quan den viec gan du lieu ko hop le cho cac properties.
        public event DelegateValidation onValidation;

        //3. dinh nghia ham xu ly event.
        public void abc(string s)
        {
            throw new FormatException(s);
        }

        public City()
        {
            //4. dang ky ham abc() se xu ly event onValidation
            onValidation = new DelegateValidation(abc);
        }

        //property cho id
        public string pid
        {
            get { return id; }
            set
            {
                //ma thanh pho la chuoi tu 2-3 ky tu chu
                if(Regex.IsMatch(value, "^[a-zA-Z]{2,3}$"))
                {
                    id = value; //gan gia tri value cua property [pid] cho bien id
                }
                else
                {
                    //throw new FormatException("Ma TP ko hop le ! (phai la 2-3 ky tu chu).");

                    //5. kich hoat event khi property bi gan du lieu ko hop le
                    onValidation("Ma TP ko hop le ! (phai la 2-3 ky tu chu).");
                }

            }
        }

        //property cho name
        public string pname
        {
            get { return name; }
            set
            {
                if (value.Trim().Length >= 2)
                {
                    name = value;
                }
                else
                {
                    //throw new FormatException("Ten TP ko hop le ! (phai tren 2 ky tu).");
                    //5. kich hoat event khi property bi gan du lieu ko hop le
                    onValidation("Ten TP ko hop le ! (phai tren 2 ky tu).");
                }
            }
        }

        //property cho area
        public int parea
        {
            get { return area; }
            set
            {
                if(value >= 100)
                {
                    area = value;
                }
                else
                {
                    //throw new FormatException("Dien tich ko hop le ! (phai >= 100km2).");
                    //5. kich hoat event khi property bi gan du lieu ko hop le
                    onValidation("Dien tich ko hop le ! (phai >= 100km2).");

                }
            }
        }


        public override string ToString()
        {
            return string.Format($"{id}, {name}, {area}");
        }

    }


    public class DemoEvent
    {
        internal void demo()
        {
            City c = new City();

            while (true)
            {
                try
                {
                    Console.Write("nhap ma TP: ");
                    c.pid = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi : {e.Message}");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("nhap ten TP: ");
                    c.pname= Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi : {e.Message}");
                }
            }


            while (true)
            {
                try
                {
                    Console.Write("nhap dien tich TP (km2): ");
                    c.parea = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi : {e.Message}");
                }
            }


            Console.WriteLine($"Thong tin TP: {c}");
        }

    }
}
