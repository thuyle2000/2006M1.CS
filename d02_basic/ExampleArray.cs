using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d02_basic
{
    class ExampleArray
    {
        internal void demoFibo()
        {
            //day so fibonacci: 0,1,1,2,3,5,8,13 ...
            int n = 0;
            while (true)
            {
                Console.WriteLine("nhap so phan tu trong day Fibo (>3) : ");
                n = int.Parse(Console.ReadLine().Trim());
                if (n > 3) break;
            }

            int[] fibo = new int[n];
            fibo[0] = 0;
            fibo[1] = 1;
            for(int i=2; i<n; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }

            Console.WriteLine(">> day so fibonacci {0}-phan tu: ", n);
            foreach (var item in fibo)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }

        internal void demoAddMatrix()
        {
            Console.WriteLine("Cong 2 ma tran");
            Console.Write( "nhap so dong ma tran: ");
            int r = int.Parse(Console.ReadLine().Trim());
            Console.Write("nhap so cot ma tran: ");
            int c = int.Parse(Console.ReadLine().Trim());

            //khai bao ma tran thu nhat a[,], b[,] va c[,] co r dong va c cot
            int[,] a = new int[r, c];
            int[,] b = new int[r, c];
            int[,] sum = new int[r, c];

            //khoi tao gia tri ngau nhien cho cac phan tu trong ma tran a[,] va b[,]
            Random rand = new Random();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    a[i, j] = rand.Next(0, 120);
                    b[i, j] = rand.Next(0, 50);

                    sum[i, j] = a[i, j] + b[i, j]; 
                }
            }
            Console.WriteLine();

            //in ma tran a va b
            Console.WriteLine(" *** Ma tran A[,] + B[,] = C[,] *** \n");
            for (int i = 0; i < r; i++)
            {
                //cac cot cua ma tran A[,]
                Console.Write(" | ");
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0,4} ", a[i,j]);
                }
                Console.Write(" | ");

                //cac cot cua ma tran B[,]
                Console.Write(" | ");
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0,4} ", b[i, j]);
                }
                Console.Write(" | ");

                //cac cot cua ma tran Sum[,]
                Console.Write(" | ");
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0,4} ", sum[i, j]);
                }
                Console.Write(" | ");

                Console.WriteLine();
            }

            Console.WriteLine();
        }

    }
}
