using exambase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp.net_hari_3
{
    class soal10 : logicbase
    {
        public soal10(int n)
        {
            jumlahbaris = n;
            jumlahkolom = n;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int[] fibo = FunctionBase.Fibonacci(jumlahbaris / 2);
            int ascii = 64;
            for (int b = 0; b < jumlahbaris; b++)
            {
                for (int k = 0; k < jumlahkolom; k++)
                {
                    //atas
                    if (b <= k && b + k <= jumlahbaris - 1)
                    {
                        //if (b % 2 == 0)
                        //{
                        //    Array2D[b, k] = fibo[b / 2].ToString();
                        //    Array2D[JmlhBaris - 1 - b, k] = fibo[b / 2].ToString();
                        //}
                        //else
                        //{
                        //    Array2D[b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                        //    Array2D[JmlhBaris - 1 - b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                        //}
                        Array2D[b, k] =
                            b % 2 == 0 ? fibo[b / 2].ToString() :
                            ((char)(ascii + (b + 1) / 2)).ToString();
                        Array2D[jumlahbaris - 1 - b, k] =
                            b % 2 == 0 ? fibo[b / 2].ToString() :
                            ((char)(ascii + (b + 1) / 2)).ToString();
                    }
                    //kiri
                    else if (b >= k && b + k <= jumlahbaris - 1)
                    {
                        //Array2D[b, k] = fibo[k / 2].ToString();
                        //Array2D[b, JmlhKolom - 1 - k] = fibo[k / 2].ToString();
                        Array2D[b, k] =
                            k % 2 == 0 ? fibo[k / 2].ToString() :
                            ((char)(ascii + (k + 1) / 2)).ToString();
                        Array2D[b, jumlahkolom - 1 - k] =
                            k % 2 == 0 ? fibo[k / 2].ToString() :
                            ((char)(ascii + (k + 1) / 2)).ToString();
                    }
                }
            }
        }
    }
}