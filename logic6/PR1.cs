using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic6
{
    class PR1: logicbase
    {
        public PR1(int n)
        {
            jumlahbaris = 3 * n + (n - 1);
            jumlahkolom = 3 * n + (n - 1);
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int b = 0; b < jumlahbaris; b++)
            {
                for (int k = 0; k < jumlahkolom; k++)
                {
                    if (b + k >= n + n - 1 && k - b <= n + n - 1 && b < n)
                    {
                        Array2D[b, k] = "*";
                        Array2D[k, b] = "*";
                        Array2D[jumlahbaris - b - 1, k] = "*";
                        Array2D[jumlahkolom - k - 1, jumlahbaris - b - 1] = "*";
                    }
                }
            }
        }
    }
}