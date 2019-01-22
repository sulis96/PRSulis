using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Logic5
{
    class posttes : logicbase
    {
        public posttes(int n)
        {
            jumlahbaris = n;
            jumlahkolom = n;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            int a = 0;
            bool kanan = true;
            int[] fibo = FunctionBase.Fibonacci(jumlahbaris * jumlahkolom);
            //baris
            for (int b=0; b < n; b++)
            {
                //kolom
                for(int k = 0; k < n; k++)
                {
                    if (kanan)
                    {
                        if (b % 2 == 0)
                            Array2D[b, k] = fibo[a++].ToString();
                        else
                            Array2D[b, n - 1] = fibo[a++].ToString();
                    }
                    //else if (b % 2 == 0)
                    //{
                    //    Array2D[b, n - 1 - k] = fibo[a++].ToString();
                    //}
                    //else
                    //    Array2D[b, 0] = fibo[a++].ToString();
                }
                kanan = !kanan;
                Console.WriteLine();
            }
        }
    }
}
