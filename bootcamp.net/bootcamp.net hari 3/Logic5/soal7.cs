using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Logic5
{
    class soal7 : logicbase
    {
        public soal7(int n)
        {
            jumlahbaris = (n * n + n) / 2;
            jumlahkolom = (n * n + n) / 2;
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
                int stklm = 9 - (bgn * bgn + 3 * bgn) / 2;
                //ending point
                int endbrs = stbrs + bgn;
                int endklm = stklm + bgn;
                int angka = 1;
                for (int b = stbrs; b <= endbrs; b++)
                {
                    for (int k = stklm; k <= endklm; k++)
                    {
                        Array2D[b, k] = angka++.ToString();
                    }
                }
            }
        }
    }
}
