using System;
using System.Collections.Generic;


namespace d05_properties
{
    public class IndexerDemo
    {
        private int[] a = { 2, 3, 5, 7, 11, 13, 17, 29 };
        private SortedList<string, string> ds = new SortedList<string, string>
        {
            {"s1","xuan phat" },
            {"s2","truong thinh" },
            {"s5","van chien"},
            {"s4","pham hien" },
            {"s8","minh nhut" },
            {"s6","minh vinh" }
        };

        //dinh nghia indexer thu nhat cho mang a[]
        public int this[int i]
        {
            get {
                if(i<0 || i>=a.Length) {
                    throw new Exception($"Loi: index ko hop le ![0-{a.Length}]");
                }
                return a[i];
            }
            set {
                if (i < 0 || i >= a.Length)
                {
                    throw new Exception($"Loi: index ko hop le ![0-{a.Length}]");
                }
                a[i] = value;
            }
        }


        //dinh nghia indexer thu 2 cho sortedlist ds, de lay ten sinh vien khi biet ma so
        public string this[string id]
        {
            get
            {
                return ds[id];
            }
        }

        //dinh nghia read-only property cho sortedlist ds, de luu 1 bo du lieu moi: ma so va ten sv
        public Student pds
        {
            set
            {
                ds.Add(value.id, value.name);
            }
        }

    }

    public class Student
    {
        public string id, name;
    }
}
