using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic6
{
    class soal9:logicbase
    {
        public soal9(int n)
        {
            jumlahbaris = n + 2;
            jumlahkolom = (n * n + 5 * n) / 2;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stbrs = n - bgn - 1;
                int stklm = (bgn * bgn + 5 * bgn) / 2;
                int endbrs = stbrs + bgn + 2;
                int endklm = stklm + bgn + 2;
                 
                for (int b = stbrs; b <= endbrs; b++)
                {
                    for (int k = stklm; k <= endklm; k++)
                    {
                        if (b + k == stbrs + endklm || b == endbrs || k == endklm)
                            Array2D[b, k] = (k+1).ToString();
                    }
                }
            }
        }
    }
}
