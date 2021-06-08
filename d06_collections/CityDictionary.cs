using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_collections
{
    public class CityDictionary
    {
        Dictionary<string, City> ds = new Dictionary<string, City>();

        //ham them 1 tp moi
        public void Create()
        {
            City c = new City();
            Input(c);   //nhap du lieu cho TP [c]

            ds.Add(c.pid, c);  //luu doi tuong [c] vo [ds]
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

                    //kiem tra ma so cua TP moi co ton tai trong HT chua ?
                    if( ds.ContainsKey(newCity.pid) )
                    {
                        Console.WriteLine(" >> Ma TP da ton tai. Vui long nhap lai !!!");
                        continue;
                    }
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
            if (ds.Count == 0)
            {
                Console.WriteLine(" >> HT chua co du lieu !");
                return;
            }

            Console.WriteLine(" === Danh sach cac TP === ");
            ds.Values.ToList().ForEach(item => Console.WriteLine(item));
        }

        //tim va in ra thong tin cua TP theo ten yeu cau
        public void Display(string ten)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine(" >> HT chua co du lieu !");
                return;
            }

            int cntTen = ds.Values.Where(item => item.pname.ToLower().Contains(ten)).Count();
            if(cntTen == 0)
            {
                Console.WriteLine($" >> Ko tim thay TP co ten [{ten}] !");
                return;
            }

            Console.WriteLine($" >>  Da tim thay {cntTen} TP co ten [{ten}] : ");
            ds.Values.Where(item => item.pname.ToLower().Contains(ten)).ToList().ForEach(item => Console.WriteLine(item));

        }

        //tim va in ra thong tin cac TP co dien tich > gia tri dc yeu cau
        public void Display(int dt)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine(" >> HT chua co du lieu !");
                return;
            }

            int cntDT = ds.Values.Where(item => item.parea>=dt).Count();
            if (cntDT == 0)
            {
                Console.WriteLine($" >> Ko tim thay TP co dien tich >= [{dt}] !");
                return;
            }

            Console.WriteLine($" >>  Da tim thay {cntDT} TP co dien tich >= [{dt}] : ");
            ds.Values.Where(item => item.parea >= dt).ToList().ForEach(item => Console.WriteLine(item));

        }



    }
}
