using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace bootcamp.net_hari_3
{
    class soal2: logicbase
    {
        public soal2(int n)
        {
            jumlahbaris = 1;
            jumlahkolom = n;
            Array2D = new string[1, jumlahkolom];
            IsiArray();
            CetakArray();
        }
        private void IsiArray()
        {
            int[] tribo = FunctionBase.Tribonacci(jumlahkolom);
            for (int k = 0; k < jumlahkolom; k++)
            {
                Array2D[0, k] = tribo[k].ToString();
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