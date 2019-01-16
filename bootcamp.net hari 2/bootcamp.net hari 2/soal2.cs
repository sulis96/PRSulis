using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp.net_hari_2
{
    class soal2
    {
        public soal2(int n)
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
                    if (b + k ==  jK - 1)
                    {
                        Console.Write("{0}\t", b * 2);
                    }
                    //prepare yg kosong
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        } 
    }
}