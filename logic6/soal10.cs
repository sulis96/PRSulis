using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic6
{
    class soal10
    {
        public soal10(int n)
        {
            for(int b = 0; b < n; b++)
            {
                for(int k = 0; k < n; k++)
                {
                    if (b >= k && b % 2 == 0)
                        Console.Write("{0}\t", b + 1);
                    else if (b + k >= n - 1 && b % 2 == 1)
                        Console.Write("{0}\t", b + 1);
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
