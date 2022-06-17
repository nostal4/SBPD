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
            string str_start = ("Hello, user!" + nn + "Make your special authentication question for more account safety." + nn + "Your question:");
            string str_continue = (n + "And make your answer :");
            string str_end = "Okay. Now you can continue your work.";
            string four = "2 + 2 = ";

            string[] warning = new string[4]
            { "WARNING!!!",
              "We've detected suspicious activity from your account. Please, authenticate to proceed.",
              "Your answer is not correct!",
              "Sorry to have distracted you. You may return to the task at hand." };

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str_start);
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string question = Convert.ToString(Console.ReadLine());
            Console.WriteLine(str_continue);
            string correct_answer = Convert.ToString(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str_end);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(n + four + '?');
            double it_doesnt_matter = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(warning[0] + n + warning[1] + n + question);
            string answer = Convert.ToString(Console.ReadLine());
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            if (answer != correct_answer)
            {
                Console.WriteLine(warning[2]);
                Console.ReadKey();
                return;
            } else if (answer == correct_answer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(warning[3] + n + four);
                double it_matter = Convert.ToDouble(Console.ReadLine());
                if (it_matter != 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No. " + four + "4.");
                    Console.ReadKey();
                    return;
                } else if (it_matter == 4)
                {
                    Console.WriteLine("Yes! " + four + it_matter + '!');
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}




