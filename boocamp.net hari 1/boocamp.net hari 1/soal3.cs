using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boocamp.net_hari_1
{
    class soal3
    {
        public soal3()
        {
            Console.Write("Masukkan nilai n : ");
            int n = int.Parse(Console.ReadLine());
            //baris
            for (int b = 0; b < n; b++)
            {
                //kolom
                for (int k = 0; k < n; k++)
                {
                    //pindah kolom
                    if (b == k || b + k == n - 1)
                    {                        
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                  
                }
                //pindah baris
                Console.WriteLine("\n");
            }
            //tahan cetakan
            Console.WriteLine("Tekan sembarang tombol");
            Console.ReadKey();
        }
    }
}
