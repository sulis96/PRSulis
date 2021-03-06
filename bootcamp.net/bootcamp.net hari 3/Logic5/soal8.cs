﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Logic5
{
    class soal8 : logicbase
    {
        public soal8(int n)
        {
            jumlahbaris = (n * n + n) / 2;
            jumlahkolom = (n * n + n) / 2;
            Array2D = new string[jumlahbaris, jumlahkolom];
            IsiArray2D(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray2D(int n)
        {
            //value
            int ganjil = 1;
            int genap = 2;
            for (int bgn = 0; bgn < n; bgn++)
            {
                //starting point
                int stbrs = (bgn * bgn + bgn) / 2;
                int stklm = stbrs;
                //ending point
                int endbrs = stbrs + bgn;
                int endklm = endbrs;
                //flow
                bool kanan = true;
                for (int b = stbrs; b <= endbrs; b++)
                {
                    for (int k = stklm; k <= endklm; k++)
                    {
                     Array2D[b, kanan ? k : endklm -k +stklm] = bgn %2 == 0? ganjil.ToString(): genap.ToString();
                        if (bgn % 2 == 0)
                            ganjil += 2;
                        else
                            genap += 2;
                    }
                    kanan = !kanan;
                      
                 }
             }
        }
     }
}
