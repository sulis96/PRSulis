using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp.net_hari_2
{
    class soal7
    {
        public soal7(int n)
        {
            CetakPola(n, n);
        }

        private void CetakPola(int jB, int jK)
        {
            int ganjil = 1;
            //baris
            for (int b = 0; b < jB; b++)
            {
                //kolom
                for (int k = 0; k < jK; k++)
                {
                    if (b == k)
                    {
                        Console.Write("{0} ", ganjil);
                        ganjil += 2;
                    }
                    else if ( b + k == jK - 1)
                    {
                        Console.Write("{0} ", 2 * k);
                    }
                    else if (b < k && b + k < jK-1)
                    {
                        Console.Write("A ");
                    }
                    else if (b > k & b + k > jK - 1)
                    {
                        Console.Write("B ");
                    }
                    //prepare yg kosong
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }       
    }
}