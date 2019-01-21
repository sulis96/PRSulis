using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_Logic_4
{
    class soal9
    {
        public soal9()
        {
            Console.WriteLine("jumlah bangun = ");
            int jmlhbangun = int.Parse(Console.ReadLine());
            Console.WriteLine("lebar bangun =");
            int n = int.Parse(Console.ReadLine());
            for(int m = 0; m < jmlhbangun; m++)
            {
                //baris
                for(int b = 0; b < n; b++)
                {
                    //kolom
                    for(int k = 0; k < n; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
        
    }
}
