using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic6
{
    class soal1:logicbase
    {
        public soal1(int n)
        {
            jumlahbaris = n * n;
            if (n == 1)
                jumlahkolom = 1;
            else
                jumlahkolom = (n * 2 - 1) * 2;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stbrs = n * bgn;
                int stklm = bgn % 2 * (n * 2 - 1);
                int endbrs = stbrs + n - 1;
                int endklm = stklm + 2 * (n - 1);
                for (int b = stbrs; b <= endbrs; b++)
                {
                
                    for (int k = stklm; k <= endklm; k++)
                    {
                        if(b+k <= stklm + endbrs && b + endklm >= k + endbrs)
                            Array2D[b, k] = ("*").ToString();
                    }
                }
            }
        }
    }
}
