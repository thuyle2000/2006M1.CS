using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d07_iterator
{
    public class Product
    {
        public string id, name;
        public int price;

        public override string ToString()
        {
            return string.Format($"id: {id}, ten san pham: {name}, don gia: {price}");
        }
    }


    //lop quan ly danh sach cac san pham trong List<>, bao gom chuc nang CRUD
    public class ProductCatalog:IEnumerable<Product>
    {
        List<Product> ds = new List<Product>();  //pham vi truy cap: private

        //ham them 1 san pham moi vo [ds]
        public void Create()
        {
            Product p = new Product();

            //nhap id cho san pham moi
            Console.Write("Nhap id: ");
            p.id = Console.ReadLine().Trim();

            //nhap ten sp
            Console.Write("Nhap ten san pham: ");
            p.name = Console.ReadLine().Trim();

            //nhap don gia sp
            while (true)
            {
                try
                {
                    Console.Write("Nhap don gia: ");
                    p.price = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi : " + e.Message);
                }
            }


            // luu san pham moi [p] vo [ds]
            ds.Add(p);

            Console.WriteLine(" >> Da them san pham vo HT thanh cong.");
        }

        //ham in toan bo danh sach san pham ra man hinh
        public void Display()
        {
            if(ds.Count == 0)
            {
                Console.WriteLine(" >>> HT chua co du lieu !");
                return;
            }

            Console.WriteLine("\n  Danh sach san pham ");
            ds.ForEach(item => Console.WriteLine(item));
        }

        //ham xoa 1 san pham theo ma so [ms]
        public void Delete(string ms)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine(" >>> HT chua co du lieu !");
                return;
            }

            var sp = ds.FirstOrDefault(item => item.id == ms);
            if (sp == null)
            {
                Console.WriteLine($" >>> Ko tim thay san pham co ma so {ms} ! ");
                return;
            }
            //xoa san pham co ma so = [ms]
            ds.Remove(sp);
            Console.WriteLine($"  *** Da xoa san pham co ma so [{ms}] *** ");
            
        }

        public IEnumerator<Product> GetEnumerator()
        {
            if (ds.Count == 0)
            {
                yield break;
            }
            foreach (var item in ds)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (ds.Count == 0)
            {
                yield break;
            }
            foreach (var item in ds)
            {
                yield return item;
            }
        }


        //named iterator.
        public IEnumerable<Product> GetProducts2_10()
        {
            if (ds.Count == 0)
            {
                yield break;
            }
            foreach (var item in ds)
            {
                if(item.price>=2 && item.price<=10) yield return item;
            }
        }


    }


}
