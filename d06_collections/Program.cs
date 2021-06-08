using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //MenuCityList();
            MenuCityDictionary();
        }


        static void MenuCityList()
        {
            CityList cList = new CityList();
            string op = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" *** MENU ***");
                Console.WriteLine("1. in danh sach thanh pho");
                Console.WriteLine("2. them thanh pho moi");
                Console.WriteLine("3. tim thanh pho theo ten");
                Console.WriteLine("4. ket thuc ung dung");
                Console.Write("Vui long nhap ma chuc nang [1-4]: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1": cList.Display(); break;
                    case "2": cList.Create(); break;
                    case "3":
                        Console.Write("\n Nhap ten TP muon tim : ");
                        cList.Display(Console.ReadLine().Trim());
                        break;
                    case "4":
                        return;
                }

                //cho man hinh dung lai, de xem ket qua xu ly
                Console.Write("\n nhap phim bat ky de tiep tuc chuong trinh");
                Console.ReadKey();
            }
        }


        static void MenuCityDictionary()
        {
            CityDictionary cList = new CityDictionary();
            string op = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" *** MENU (DICTIONARY) ***");
                Console.WriteLine("1. in danh sach thanh pho");
                Console.WriteLine("2. them thanh pho moi");
                Console.WriteLine("3. tim thanh pho theo ten");
                Console.WriteLine("4. tim thanh pho theo dien tich");
                Console.WriteLine("5. ket thuc ung dung");
                Console.Write("Vui long nhap ma chuc nang [1-5]: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1": cList.Display(); break;
                    case "2": cList.Create(); break;
                    case "3":
                        Console.Write("\n Nhap ten TP muon tim : ");
                        cList.Display(Console.ReadLine().Trim());
                        break;
                    case "4":
                        Console.Write("\n Nhap dien tich muon tim : ");
                        try
                        {
                            cList.Display(int.Parse(Console.ReadLine().Trim()));                           
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Loi {0}", e.Message );
                        }
                        break;

                    case "5":
                        return;
                }

                //cho man hinh dung lai, de xem ket qua xu ly
                Console.Write("\n nhap phim bat ky de tiep tuc chuong trinh");
                Console.ReadKey();
            }

        } 
    }
}
