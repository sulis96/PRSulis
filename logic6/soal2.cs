using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic6
{
    class soal2 : logicbase
    {
        public soal2(int n)
        {
            jumlahbaris = n * n;
            if (n == 1)
            {
                jumlahkolom = 1;
            }
            else
            {
                jumlahkolom = (n * 2 - 1) * 2;
            }
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(jumlahkolom * jumlahkolom);
            for (int bgn = 0; bgn < n; bgn++)
            {
                int StrBaris = n * bgn;
                int StrKolom = bgn % 2 * (n * 2 - 1);
                int EndBaris = StrBaris + n - 1;
                int EndKolom = StrKolom + 2 * (n - 1);

                int angka = 0;

                for (int b = StrBaris; b <= EndBaris; b++)
                {
                    for (int k = StrKolom; k <= EndKolom; k++)
                    {
                        if (b + k >= StrKolom + EndBaris && k + EndBaris <= b + EndKolom)
                            Array2D[b, k] =fibo[angka++].ToString();
                    }
                }
            }
        }
    }
}