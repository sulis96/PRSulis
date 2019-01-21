using exambase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp.net_hari_3
{
    class soal9: logicbase
    {
        public soal9(int n)
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

            for (int b = 0; b < jumlahbaris; b++)
            {
                for (int k = 0; k < jumlahkolom; k++)
                {
                    //atas
                    if (b <= k && b + k <= jumlahbaris - 1 && b % 2 == 0)
                    {
                        //Garis bawah
                        Array2D[b, k] = fibo[b / 2].ToString();
                        //GARIS BAWAH - MIRROR
                        Array2D[jumlahbaris - 1 - b, k] = fibo[b / 2].ToString();
                    }
                    //kiri
                    else if (b >= k && b + k <= jumlahbaris - 1 && k % 2 == 0)
                    {
                        //Garis bawah
                        Array2D[b, k] = fibo[k / 2].ToString();
                        //GARIS BAWAH - MIRROR
                        Array2D[b, jumlahkolom - 1 - k] = fibo[k / 2].ToString();
                    }
                }
            }
        }
    }
}