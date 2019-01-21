using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Logic 4---");
            Console.Write("Masukan nilai n :");
            int n = int.Parse(Console.ReadLine());
            //soal1 soal1 = new soal1(n);
            //soal2 soal2 = new soal2(n);
            //soal3 soal3 = new soal3(n);
            //soal4 soal4 = new soal4(n);
            //soal5 soal5 = new soal5(n);
            //soal6 soal6 = new soal6(n);

            PRsoal9 PRsoal9 = new PRsoal9(n);
            Console.Write("tekan sembarang tombol");
            Console.ReadKey();

        }
    }
}
