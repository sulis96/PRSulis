using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace PRlogic7
{
    class PR3 : logicbase
    {
        public PR3(int n)
        {
            jumlahbaris = 2 * n + 1;
            jumlahkolom = 4 * n - 1;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int angka = 1;
                int stbrs = 0;
                int stklm = 2 * n - 2 * bgn - 2;
                int endbrs = stbrs + 2 * bgn + 2;
                int endklm = stklm + 4 * bgn + 2;

                for (int b = stbrs; b <= endbrs; b++)
                {
                    for (int k = stklm; k <= endklm; k++)
                    {
                        if (k == stklm || b == endbrs)
                        {
                            Array2D[b, k] = angka.ToString();
                            angka++;
                        }
                        else if (k == endklm)
                        {
                            Array2D[b, k] = (8 * bgn - b + 7).ToString();
                        }
                    }

                }
            }
        }
    }
}
