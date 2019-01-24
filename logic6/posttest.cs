using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic6
{
    class posttest:logicbase
    {
        public posttest(int n)
        {
            jumlahbaris = n;
            jumlahkolom = n * n - n + 1;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            for(int bgn = 0; bgn < n; bgn++)
            {
                int stbrs = 0;
                int stklm = (n - 1) * bgn;
                int endbrs = stbrs + n - 1;
                int endklm = stklm + n - 1;

                for (int b = stbrs; b <= endbrs; b++)
                {
                    for (int k = stklm; k <= endklm; k++)
                    {
                        if(k == endklm|| b + k - stklm == n-1)
                        {
                            Array2D[b, k] = "*".ToString();
                        }
                    }
                }
            }
        }
    }
}
