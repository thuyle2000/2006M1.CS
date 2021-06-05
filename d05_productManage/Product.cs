using System;
using RE = System.Text.RegularExpressions.Regex;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails
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
                if (RE.IsMatch(value, "^[a-z A-Z0-9]{3,20}$"))
                {
                    name = value;  //cat gia tri cua property -> name
                }
                else
                {
                    Console.WriteLine("loi: du lieu ko hop le ! (chuoi tu 3-20 ky tu chu hoac so !)");
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
                if (value >= 0 && value <= 10000)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Loi: du lieu ko hop le ([0-10000]) !");
                }
            }
        }

        public override string ToString()
        {
            return string.Format($"{id}, {pname}, {pprice}");
        }
    }


    //lop chua danh sach cac san pham, thuc hien chuc nang them, xoa, sua, tim kiem... sp
    public class ProductCatalog
    {
        List<Product> ds = new List<Product>();

        public void create()
        {
            Product p = new Product();

            while (true)
            {
                Console.Write("nhap id: ");
                p.id = Console.ReadLine().Trim();
                if (p.id.Length==0 || checkID(p.id)) {
                    Console.WriteLine($"Ma so {p.id} da ton tai. Vui long nhap lai !");
                    continue;
                }
                break;
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("nhap ten san pham: ");
                    p.pname = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); 
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("nhap don gia san pham: ");
                    p.pprice = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            ds.Add(p);
            Console.WriteLine("Them san pham moi thanh cong !");

        }

        public bool checkID(string cid)
        {
            return ds.Where(item => item.id == cid).Count()>0;
        }

        public void display()
        {
            if(ds.Count == 0)
            {
                Console.WriteLine(">>> HT chua co du lieu !");
                return;
            }

            Console.WriteLine(" *** Danh sach san pham ***");
            ds.ForEach(item => Console.WriteLine(item));
        }

        //ham xoa san pham theo ma so
        public void delete(string did)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine(">>> HT chua co du lieu !");
                return;
            }

            Product p = ds.Find(item => item.id == did);
            if(p != null)
            {
                ds.Remove(p);
                Console.WriteLine($" *** Da xoa sp cua ma so {did} thanh cong !");
            }
            else
            {
                Console.WriteLine($">>> ko tim thay san pham co ma so {did} !!!");
            }
        }

        //ham in ra ds san pham co don gia lon hon gia tri duoc yeu cau
        public void display(int rprice)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine(">>> HT chua co du lieu !");
                return;
            }

            if(ds.Where(item => item.pprice >= rprice).Count() == 0)
            {
                Console.WriteLine($">>> Ko tim thay san pham co don gia >= {rprice} !");
                return;
            }

            Console.WriteLine(" *** Danh sach san pham ***");           
            ds.Where(item=> item.pprice>=rprice).ToList().ForEach(item => Console.WriteLine(item));
        }

    }
}
