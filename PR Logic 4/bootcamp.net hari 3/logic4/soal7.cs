using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic4
{
    class soal7 : logicbase
    {
        public soal7(int n)
        {
            jumlahbaris = n;
            jumlahkolom = n * 2 - 1;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D();
            FunctionBase.CetakArray(Array2D);

        }
        private void IsiArray2D()
        {
            for (int b = 0; b < jumlahbaris; b++)
            {
                int angka = 1;
                for (int k = 0; k < jumlahkolom; k++)
                {
                    if (b <= k && b + k <= jumlahbaris - 1)
                    {
                        Array2D[b, k] = angka.ToString();
                        if (k < jumlahkolom / 2)                        
                            angka += 2;                        
                        else                        
                            angka -= 2;             

                    }
                }
            }
        }
    }

}
