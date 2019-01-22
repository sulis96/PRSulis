using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Logic5
{
    class soal10 : logicbase
    {
        public soal10(int n)
        {
            jumlahbaris = (n * n + n) / 2;
            jumlahkolom = (n * 2-1);
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                //starting point
                int stbrs = (bgn * bgn + bgn) / 2;
                int stklm = (n * 2 - 1) / 2 - bgn;
                //ending point
                int endbrs = stbrs + bgn;
                int endklm = stklm + (bgn * 2);
                int angka = 1;
                int a = 0;
                int[] fibo = FunctionBase.Fibonacci(jumlahbaris*jumlahkolom);
                for (int b = stbrs; b <= endbrs; b++)
                {
                   
                    for (int k = stklm; k <= endklm; k++)
                    {
                        if (b + k >= stklm + endbrs && k + endbrs <= b + endklm && bgn % 2 == 0)
                        {   
                            Array2D[b, k] = angka.ToString();
                            angka += 2;
                        }
                        else if(b + k >= stklm + endbrs && k + endbrs <= b + endklm && bgn % 2 == 1)
                            Array2D[b,k] = fibo[a++].ToString();
                    }
                }
            }
        }
    }
}