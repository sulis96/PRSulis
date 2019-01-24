using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic6
{
    class extend1:logicbase
    {
        public extend1(int n)
        {
            jumlahbaris = n;
            jumlahkolom = n;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            int ganjil = 1;
            bool kanan = true;
            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (b % 2 == 0)
                        Array2D[b, k] = ganjil.ToString();
                    else
                        Array2D[b, jumlahkolom - k-1] = ganjil.ToString();
                    ganjil += 2;
                }
                kanan = !kanan;
            }
        }
    }
}
