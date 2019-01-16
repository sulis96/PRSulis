using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp.net_hari_2
{
    class soal9
    {
        public soal9(int n)
        {
            CetakPola(n, n);
        }

        private void CetakPola(int jB, int jK)
        {
            //baris
            for (int b = 0; b < jB; b++)
            {
                //kolom
                for (int k = 0; k < jK; k++)
                {
                    if (k < jK/2)
                        Console.Write("{0} ", k*2 + 1);
                    //prepare yg kosong
                    else
                        Console.Write("{0} ", (jK-k)*2 - 1);
                }
                Console.WriteLine("\n");
            }
        }
    }
}