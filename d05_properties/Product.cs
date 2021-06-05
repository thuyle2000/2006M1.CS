using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace d05_properties
{
    public class Product
    {
        private string name;
        private int price;

        //dinh nghia auto-property [id] 
        public string id { get; set; }

        //dinh nghia 1 property [pname] cho field name
        public string pname
        {
            get
            {
                return name;
            }
            set
            {
                //ten 1 san pham phai tu [3-20] ky tu (a-z, 0-9)
                if (Regex.IsMatch(value, "^[a-z A-Z0-9]{3,20}$"))
                {
                    name = value;  //cat gia tri cua property -> name
                }
                else
                {
                    throw new Exception("loi: du lieu ko hop le ! (chuoi tu 3-20 ky tu chu hoac so !)");
                }
            }
        }


        //dinh nghia property [pprice] cho field price
        public int pprice
        {
            get
            {
                return price;
            }
            set
            {
                //don gia phai co gia tri [0-10000]
                if(value>=0 && value <= 10000)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Loi: du lieu ko hop le ([0-10000]) !");
                }
            }
        }

        public override string ToString()
        {
            //return string.Format("{0}, {1}, {2}", id, pname, pprice);
            return string.Format($"{id}, {pname}, {pprice}");
        }
    }
}
