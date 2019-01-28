using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRlogic7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("masukan nilai n =");
            int n = int.Parse(Console.ReadLine());

            //soal9 soal9 = new soal9(n);
            //soal10 soal10 = new soal10(n);
            posttest posttest = new posttest(n);
            //PR3 PR3 = new PR3(n);
            Console.WriteLine("tekan sembarang tombol");
            Console.ReadKey();
        }
    }
}
