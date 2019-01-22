using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Logic5
{
    class soal4 : logicbase
    {
        public soal4(int n)
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
                //starting point
                int stbrs = (bgn * bgn + bgn) / 2;
                int stklm = 8- (bgn * bgn + 2* bgn);

                //ending point
                int endbrs = stbrs + bgn;
                int endklm = stklm + (bgn * 2);
                for (int b = stbrs; b <= endbrs; b++)
                {
                    for (int k = stklm; k <= endklm; k++)
                    {
                        if (b + k >= stklm + endbrs && k + endbrs <= b + endklm)
                            Array2D[b, k] = "*";
                    }
                }
            }
        }
    }
}
