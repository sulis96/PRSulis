using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Logic 5---");
            Console.Write("Masukan nilai n :");
            int n = int.Parse(Console.ReadLine());
            //soal1 soal1 = new soal1(n);
            //soal2 soal2 = new soal2(4);
            //soal3 soal3 = new soal3(n);
            //soal5 soal5 = new soal5(n);
            //soal4 soal4 = new soal4(n);
            //soal6 soal6 = new soal6(n);
            //soal7 soal7 = new soal7(n);
            //soal8 soal8 = new soal8(n);
            //soal9 soal9 = new soal9(n);
            //soal10 soal10 = new soal10(n);
            //PR PR = new PR(n);
            PR2 PR2 = new PR2(3);
            //posttes posttes = new posttes(n);
            PR1 PR1 = new PR1(n);
            Console.Write("tekan sembarang tombol");
            Console.ReadKey();
        }
    }
}
