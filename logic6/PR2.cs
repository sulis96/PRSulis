using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic6
{
    class PR2: logicbase
    {
        public PR2(int n)
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
                int stklm = jumlahkolom - (bgn * bgn + 7 * bgn + 6) / 2;
                int endbrs = n + 1;
                int endklm = stklm + bgn + 2;

                for (int b = stbrs; b <= endbrs; b++)
                {
                    for(int k = stklm; k <= endklm; k++)
                    {
                        if(b == stbrs || k == stklm || b + k - stklm == n + 1)
                        {
                            Array2D[b, k] = (jumlahkolom-k).ToString();
                        }
                    }
                }
            }
        }
    }
}
