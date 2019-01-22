using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exambase
{
    public class logicbase
    {
        public int jumlahbaris { get; set; }
        public int jumlahkolom { get; set; }
        public string[,] Array2D { get; set; } 
    }
    public class FunctionBase
    {
        public static int[] Fibonacci(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 1)
                    result[pos] = 1;
                else
                    result[pos] = result[pos - 1] + result[pos - 2];
            }
            return result;
        }
        public static int[] Tribonacci(int n)
        {
            int[] result = new int[n];
            for(int pos = 0; pos < n; pos++)
            {
                if (pos <= 2)
                    result[pos] = 1;
                else
                    result[pos] = result[pos - 1] + result[pos - 2] + result[pos - 3];
            }
            return result;
        }
        public static int[] Fibonacci2(int n)
        {
            int g = 1;
            int[] result = new int[n];
            for(int pos = 0; pos < n; pos++)
            {
                if (pos <= 1)
                    result[pos] = 1;
                else if (1 < pos & pos <= n / 2)
                    result[pos] = result[pos - 1] + result[pos - 2];
                else
                {
                    result[pos] = result[n / 2 - g];
                    g++;
                }
                
                

            }
            return result;
        }
        public static int[] Tribonacci2(int n)
        {
            int g = 1;
            int[] result = new int[n];
            for(int pos = 0; pos < n; pos++)
            {
                if (pos <= 2)
                    result[pos] = 1;
                else if (1 < pos & pos <= n / 2)
                    result[pos] = result[pos - 1] + result[pos - 2] + result[pos - 3];
                else
                {
                    result[pos] = result[n / 2 - g];
                    g++;
                }
            }
            return result;
        }
        public static void CetakArray(string[,] array)
        {
            for (int b = 0; b < array.GetLength(0); b++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write("{0}\t", array[b, k]);
                }
                Console.WriteLine("\n");
            }
        }
        public static int[] ASCII(int n)
        {
            int[] result = new int[n];
            for (int b = 0; b < n; b++)
            {
                if (b == 0)
                    result[b] = 65;
                else
                    result[b] = result[b - 1] + 1;
            }
            return result;
        }

    }
}
