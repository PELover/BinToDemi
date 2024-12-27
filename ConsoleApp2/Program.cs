using System;
using System.Reflection.Emit;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            string s = "";
            int a = 0;
            double sum = 0;
            while (b)
            {
                Console.Write("Please insert binary number : ");
                s = Console.ReadLine();
                b = s.Any(c => c != '0' && c != '1');
            }
            int n = s.Length-1;
            for(int i=0;i<s.Length;i++)
            {
                a = (int)s[i] - 48;
                sum += a * Math.Pow(2, n);
                n--;
            }
            Console.WriteLine($"Your binary number {s} convert to demical number = {sum}");
            Console.ReadKey();
        }
    }
}