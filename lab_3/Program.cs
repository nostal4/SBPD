using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string n = "\n";
            string nn = n + n;

            string[] start = new string[2]
            { "This is a journal of your last 5 actions.",
            ("\n What disk did you select?") };

            string enter = "Open your file.";

            Console.WriteLine(start[0] + n + start[1]);
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            Char d1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(enter);
            string w1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(start[1]);
            Char d2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(enter);
            string w2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(start[1]);
            Char d3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(enter);
            string w3 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(start[1]);
            Char d4 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(enter);
            string w4 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(start[1]);
            Char d5 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(enter);
            string w5 = Convert.ToString(Console.ReadLine());
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.

            string end = "You've opened: ";
            char m = (char)92;
            string lm = (":" + m);

            Console.WriteLine(nn + end + d1 + lm + w1);
            Console.WriteLine(d2 + lm + w2);
            Console.WriteLine(d3 + lm + w3);
            Console.WriteLine(d4 + lm + w4);
            Console.WriteLine(d5 + lm + w5);

            Console.ReadKey();
        }
    }
}