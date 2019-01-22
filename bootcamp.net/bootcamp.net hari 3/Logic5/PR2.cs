using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Logic5
{
    class PR2 : logicbase
    {
        public PR2(int n)
        {
            jumlahbaris = (n * n + n) / 2;
            jumlahkolom = n * n;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int[] fibo = FunctionBase.Fibonacci(jumlahkolom * jumlahbaris);
                //starting point
                int stbrs = (jumlahbaris -1) - ( bgn * bgn - 3* bgn)/2;
                int stklm = (jumlahkolom-1)-(bgn * bgn+2* bgn);
                int a = 0;

                //ending point
                int endbrs = stbrs + bgn;
                int endklm = stklm + (bgn * 2);
                for (int b = stbrs; b <= endbrs; b++)
                {
                    for (int k = stklm; k <= endklm; k++)
                    {
                        if (b + k >= endklm-endbrs+2*stbrs && k -b <= endklm - endbrs)
                            Array2D[b, k] = fibo[a++].ToString();
                    }
                }
            }
        }
    }
}
