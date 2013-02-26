using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            string greeting = String.Format("Hi there! I'm going to print the first {0} fibonacci numbers!", n);
            Console.WriteLine(greeting);
            int[] fs = fib(n);
            for (int i = 0; i < n; i++)
            {
                string f = String.Format("{0,2:d}:{1,3:d}", i+1, fs[i]);
                Console.WriteLine(f);
            }
            Console.Read();
        }

        public static int[] fib(int n)
        {
            int a = 1;
            int b = 1;
            int[] fibs = new int[n];

            for (int i = 0; i < n; i++)
            {
                fibs[i] = a;
                a = b;
                b += fibs[i];
            }

            return fibs;
        }
    }
}
