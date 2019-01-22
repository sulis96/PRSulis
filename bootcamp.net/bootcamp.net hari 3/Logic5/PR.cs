using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Logic5
{
    class PR : logicbase
    {
        public PR(int n)
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
                int[] fibo = FunctionBase.Fibonacci(jumlahkolom*jumlahbaris);
                //starting point
                int stbrs = (bgn * bgn + bgn) / 2;
                int stklm = bgn * bgn;
                int a = 0;
                //ending point
                int endbrs = stbrs + bgn;
                int endklm = stklm + (bgn * 2);
                
                for (int b = stbrs; b <= endbrs; b++)
                {
                    for (int k = stklm; k <= endklm; k++)
                    {
                        if (b + k >= stklm + endbrs && k + endbrs <= b + endklm)
                        {
                            Array2D[b, k] = fibo[a++].ToString();
                        }
                            
                            
                    }
                }
            }
        }
    }
}
