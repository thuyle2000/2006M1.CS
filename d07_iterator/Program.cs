using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d07_iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        // Menu chuc nang quan ly danh sach san pham
        static void Menu()
        {
            ProductCatalog pc = new ProductCatalog();
            string op= null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" *** MENU ***");
                Console.WriteLine("1. in danh sach san pham");
                Console.WriteLine("2. them san pham moi");
                Console.WriteLine("3. xoa san pham theo ma so");
                Console.WriteLine("4. tim san pham theo ten");
                Console.WriteLine("5. tim san pham theo don gia");
                Console.WriteLine("6. Liet ke cac sp co don gia tu 2-10$");


                Console.WriteLine("7. ket thuc ung dung");
                Console.Write("Vui long nhap ma chuc nang [1-7]: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1": pc.Display(); break;
                    case "2": pc.Create(); break;
                    case "3":
                        Console.Write("\n Nhap ma so san pham muon xoa: ");
                        pc.Delete(Console.ReadLine().Trim());
                        break;

                    case "4":
                        Console.Write("\n Nhap ten san pham muon tim: ");
                        string tenSP = Console.ReadLine().Trim().ToLower();

                        pc.Where(item => item.name.ToLower().Contains(tenSP)).
                            ToList().ForEach(item => Console.WriteLine(item));
                        break;


                    case "5":
                        Console.Write("\n Nhap don gia san pham : ");
                        try
                        {
                            int gia = int.Parse(Console.ReadLine().Trim());

                            pc.Where(item => item.price>=gia).
                                ToList().ForEach(item => Console.WriteLine(item));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Loi: " + e.Message);
                        }                    

                        break;

                    case "6":
                        Console.WriteLine("\n -- Danh sach san pham co don gia tu 2-10$ ");
                        pc.GetProducts2_10().ToList().ForEach(item => Console.WriteLine(item));

                        break;

                    case "7":
                        return;
                }

                //cho man hinh dung lai, de xem ket qua xu ly
                Console.Write("\n  >> nhap phim bat ky de tiep tuc chuong trinh ... ");
                Console.ReadKey();
            }


        }
    }
}
