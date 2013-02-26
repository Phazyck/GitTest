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
            int n;
            try
            {
                n = Int32.Parse(args[0]);
            }
            catch (Exception e)
            {
                n = 15;
            }

            string greeting = String.Format("Hi there! I'm going to print the first {0} fibonacci numbers!\n", n);
            Console.WriteLine(greeting);
            Console.WriteLine("When you're ready for it, press any key. ^_^\n");
            Console.ReadKey();
            int[] fs = fib(n);
            for (int i = 0; i < n; i++)
            {
                string f = String.Format("{0,3:d}:{1,4:d}", i+1, fs[i]);
                Console.WriteLine(f);
            }
            Console.WriteLine("\n*Whew* that was all of them.\nPress any key to quit.");
            Console.ReadKey();
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
