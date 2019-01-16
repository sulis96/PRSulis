using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp.net_hari_2
{
    class soal_10
    {
        public soal_10(int n)
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
                    if (b < jB / 2)                    
                        Console.Write("{0}\t ", b * 2);
                    //prepare yg kosong
                    else 
                        Console.Write("{0}\t ", (jB - b) * 2);
                }
                Console.WriteLine("\n");
            }
        }
    }
}

