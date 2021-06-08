using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_collections
{
    //quan ly danh sach cac thanh pho trong cau truc List<>
    public class CityList
    {
        List<City> ds = new List<City>();

        //ham them 1 tp moi
        public void Create()
        {
            City c = new City();
            Input(c);   //nhap du lieu cho TP [c]

            ds.Add(c);  //luu doi tuong [c] vo [ds]
            Console.WriteLine("Da them TP moi vo he thong !");
        }

        public void Input(City newCity)
        {
            while (true)
            {
                try
                {
                    Console.Write("nhap ma TP: ");
                    newCity.pid = Console.ReadLine();
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
                    newCity.pname = Console.ReadLine();
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
                    newCity.parea = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi : {e.Message}");
                }
            }
        }

        //in toan bo danh sach TP ra man hinh
        public void Display()
        {
            if(ds.Count == 0)
            {
                Console.WriteLine(" >> HT chua co du lieu !");
                return;
            }

            Console.WriteLine(" === Danh sach cac TP === ");
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }
        }

        //tim va in ra thong tin cua TP theo ten yeu cau
        public void Display(string ten)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine(" >> HT chua co du lieu !");
                return;
            }

            int cntTen = 0;
            ten = ten.ToLower();
            foreach (var item in ds)
            {
                if (item.pname.ToLower().Contains(ten))
                {
                    cntTen++;
                    Console.WriteLine(item);
                }
            }

            if (cntTen == 0)
            {
                Console.WriteLine($" >> Ko tim thay TP co ten {ten} !");
            }
        }


    }
}
