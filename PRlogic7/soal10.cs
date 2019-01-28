using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace PRlogic7
{
    class soal10:logicbase
    {
        public soal10(int n)
        {
            jumlahbaris = n * n;
            jumlahkolom = n * n;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            int angka = 1;
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == 0 || bb == n - 1 || bk == 0 || bk == n - 1)
                    {
                        int stbrs = bb * n;
                        int stklm = bk * n;
                        int endbrs = stbrs + n - 1;
                        int endklm = stklm + n - 1;

                        for (int b = stbrs; b <= endbrs; b++)
                        {
                            for (int k = stklm; k <= endklm; k++)
                            {
                                if (b == endbrs || k == stklm || (b - stbrs) == (k - stklm))
                                {
                                    Array2D[b, k] = angka.ToString();
                                }
                            }

                        }
                        angka++;
                    }
                }
            }
        }
    }
}
