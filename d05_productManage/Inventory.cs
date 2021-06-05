using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductDetails;

namespace ProductManagement
{
    class Inventory
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            ProductCatalog pc = new ProductCatalog();
            string op = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" *** MENU ***");
                Console.WriteLine("1. in danh sach san pham");
                Console.WriteLine("2. them san pham moi");
                Console.WriteLine("3. tim san pham theo don gia");
                Console.WriteLine("4. xoa san pham theo ma so");
                Console.WriteLine("5. ket thuc ung dung");
                Console.Write("Vui long nhap ma chuc nang [1-5]: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1": pc.display(); break;
                    case "2": pc.create(); break;
                    case "3":
                        Console.Write("\n Nhap don gia : ");
                        int dg = int.Parse(Console.ReadLine().Trim());
                        pc.display(dg);
                        break;
                    case "4":
                        Console.Write("\n Nhap id: ");
                        pc.delete(Console.ReadLine().Trim());
                        break;
                    case "5":return;
                }

                //cho man hinh dung lai, de xem ket qua xu ly
                Console.Write("\n nhap phim bat ky de tiep tuc chuong trinh");
                Console.ReadKey();
            }
        }
    }
}
