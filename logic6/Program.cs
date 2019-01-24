using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("masukan nilai n =");
            int n = int.Parse(Console.ReadLine());

            //soal1 soal1 = new soal1(n);
            //soal2 soal2 = new soal2(n);
            //soal4 soal4 = new soal4(n);
            //soal5 soal5 = new soal5(n);
            //soal6 soal6 = new soal6(n);
            //soal10 soal10 = new soal10(n);
            PR1 PR1 = new PR1(n);
            Console.WriteLine("tekan sembarang tombol");
            Console.ReadKey();
        }
    }
}
