using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic4
{
    class soal3:logicbase
    {
        public soal3(int n)
        {
            jumlahbaris = n;
            jumlahkolom = n;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray()
        {
            for(int b = 0; b < jumlahbaris/2 + 1; b++)
            {
                int angka = 1;
                for (int k = 0; k < jumlahkolom; k++)
                {
                    if (b + k >= jumlahbaris / 2 - 1 && k - b <= jumlahbaris / 2 && b <= jumlahbaris / 2)
                    { 
                    Array2D[b, k] = angka.ToString();
                    Array2D[jumlahbaris - b - 1, k] = angka.ToString();
                    angka++;
                    }
                }
            }
        }
    }
}
