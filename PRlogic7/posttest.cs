using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace PRlogic7
{
    class posttest : logicbase
    {
        public posttest(int n)
        {
            jumlahbaris = n * n;
            jumlahkolom = n * n;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(jumlahbaris * jumlahkolom);
            
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk)
                    {
                        int angka = 0;
                        int stbrs = bb * n;
                        int stklm = bk * n;
                        int endbrs = stbrs + n - 1;
                        int endklm = stklm + n - 1;

                        for (int b = stbrs; b <= endbrs; b++)
                        {
                            for (int k = stklm; k <= endklm; k++)
                            {
                                if (b == stbrs || k == endklm)
                                {
                                    Array2D[b, k] = fibo[angka].ToString();
                                    angka++;
                                }
                                else if (k == stklm || b == endbrs)
                                {
                                    Array2D[b, k] = fibo[(jumlahbaris - (b- stbrs) - (k-stklm))].ToString();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
