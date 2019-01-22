using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace bootcamp.net_hari_3
{
    class soal1: logicbase
    {
        public soal1(int n)
        {
            jumlahbaris = 1;
            jumlahkolom = n;
            Array2D = new string[1,jumlahkolom];
            IsiArray();
            CetakArray();
        }
        private void IsiArray()
        {
            int[] fibo = FunctionBase.Fibonacci(jumlahkolom);
            for (int k = 0; k < jumlahkolom; k++)
            {
                Array2D[0, k] = fibo[k].ToString();
            }
            //Console.WriteLine("nilai jumlah baris : {0}", jumlahbaris);
            //Console.WriteLine("nilai jumlah kolom : {0}", jumlahkolom);
            //Console.WriteLine("buffer Array : {0}", jumlahbaris*jumlahkolom);

            //for(int b = 0; b < jumlahbaris; b++)
            //{
            //    for(int k = 0; k < jumlahkolom; k++)
            //    {
            //        //diagonal kiri ganjil
            //        if (b == k)
            //        {
            //            Array2D[b, k] = (k * 2 + 1).ToString();
            //        }
            //        else if(b + k == jumlahbaris - 1)
            //        {
            //            Array2D[b, k] = (k * 2).ToString();
            //        }
                    
            //    }
            //}
        }
        private void CetakArray()
        {
            for(int b = 0;b < Array2D.GetLength(0); b++)
            {
                for(int k = 0; k < Array2D.GetLength(1); k++)
                {
                    Console.Write("{0}\t", Array2D[b,k]);
                }
                Console.WriteLine("\n");
            }
        }


    }
}
