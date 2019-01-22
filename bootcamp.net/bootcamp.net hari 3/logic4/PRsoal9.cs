using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic4
{
    class PRsoal9 : logicbase
    {
        public PRsoal9(int n)
        {
            Console.WriteLine("jumlah bangun =");
            int m = int.Parse(Console.ReadLine());
            jumlahbaris = n;
            jumlahkolom = n;
            Array2D = new string[jumlahbaris, jumlahkolom*m-(m-1)];
            IsiArray2D(m);
            FunctionBase.CetakArray(Array2D);

        }
        private void IsiArray2D(int m)
        {
            for(int g = 0; g < m; g++)
            {
                //baris
                for(int b = 0; b < jumlahbaris; b++)
                {
                    //kolom
                    int angka = 1;
                    for (int k = 0; k < jumlahkolom; k++)
                    {
                        if(b + k >= jumlahbaris/2 && k - b <= jumlahbaris/2)
                        {
                            
                            Array2D[b,g*(jumlahkolom-1)+k] = angka.ToString();
                            if (k < jumlahkolom / 2)
                            {
                                angka += 2;
                            }
                            else
                            {
                                angka -= 2;
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }

}
