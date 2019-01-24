using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic6
{
    class soal5 : logicbase
    {
        public soal5(int n)
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
                    if (bb + bk == n - 1)
                    {
                        int stbrs = bb * n;
                        int stklm = bk * n;
                        int endbrs = stbrs + n - 1;
                        int endklm = stklm + n - 1;

                        bool kanan = true;
                        for (int b = stbrs; b <= endbrs; b++)
                        {
                            for (int k = stklm; k <= endklm; k++)
                            {
                                if (kanan)
                                {
                                    Array2D[b, k] = angka.ToString();
                                    angka += 2;
                                }
                                else
                                {
                                    Array2D[b, endklm -k + stklm] = angka.ToString();
                                    angka += 2;
                                }

                            }
                            kanan = !kanan;
                        }
                    }
                }
            }
        }
    }
}
