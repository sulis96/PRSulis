using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic6
{
    class soal8:logicbase
    {
        public soal8(int n)
        {
            jumlahbaris = n * n;
            jumlahkolom = n * n;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            int angka = (n + 1) / 2;
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk)
                    {
                        int stbrs = bb * n;
                        int stklm = bk * n;
                        int endbrs = stbrs + n - 1;
                        int endklm = stklm + n - 1;

                        for (int b = stbrs; b <= endbrs; b++)
                        {
                            int a = angka;
                            for (int k = stklm; k <= endklm; k++)
                            {
                                if ((b - stbrs) + (k - stklm) >= (n - 1) / 2 && (k - stklm) - (b - stbrs) <= (n - 1) / 2 && (b - stbrs) - (k - stklm) <= (n - 1) / 2 && (b - stbrs) + (k - stklm) <= 3 * (n - 1) / 2)
                                {
                                    if (k - stklm < n / 2)
                                    {
                                        Array2D[b, k] = a.ToString();
                                        a--;
                                    }
                                    else
                                    {
                                        Array2D[b, k] = a.ToString();
                                        a++;
                                    } 
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
