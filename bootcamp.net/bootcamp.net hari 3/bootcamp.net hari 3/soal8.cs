using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace bootcamp.net_hari_3
{
    class soal8:logicbase
    {
        public soal8(int n)
        {
            jumlahbaris = n;
            jumlahkolom = n * 2 - 1;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray()
        {
            int[] fibo = FunctionBase.Fibonacci(jumlahkolom);
            for(int k = 0; k < jumlahkolom; k++)
            {
                Array2D[0, k] = fibo[k].ToString();
                for(int b = 0; b < jumlahbaris; b++)
                {
                    Array2D[b, k] = fibo[k].ToString();
                }
            }
        }
    }
}
