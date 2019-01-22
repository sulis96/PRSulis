using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace bootcamp.net_hari_3
{
    class soal4: logicbase
    {
        public soal4(int n)
        {
            jumlahbaris = n;
            jumlahkolom = n;
            Array2D = new string[jumlahbaris , jumlahkolom];
            IsiArray();
            CetakArray();
        }
        private void IsiArray()
        {
            int[] tribo2 = FunctionBase.Tribonacci2(jumlahkolom);
            for (int k = 0; k < jumlahkolom; k++)
            {
                Array2D[0, k] = tribo2[k].ToString();
                for (int b = 0; b < jumlahbaris; b++)
                {
                    Array2D[b, k] = tribo2[k].ToString();
                }
            }
        }
        private void CetakArray()
        {
            for (int b = 0; b < Array2D.GetLength(0); b++)
            {
                for (int k = 0; k < Array2D.GetLength(1); k++)
                {
                    Console.Write("{0}\t", Array2D[b, k]);
                }
                Console.WriteLine("\n");
            }
        }


    }
}