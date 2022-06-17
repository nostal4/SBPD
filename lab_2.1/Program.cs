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
            string str_reg_form = "REGISTRATION FORM";
            string str_hello = "Hello, user!\n What's domain are you use? \n example: gmail.com";
            string str_index = " And enter your adress index:";
            string str_password = " Add your password:";
            string str_password_end = " So, your password is: ";
            string str_reg_end = "Your registration has been succesfully. Please, login.";
            string str_login = " Enter your E-Mail.";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str_reg_form);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(n + str_hello);
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string domain = Convert.ToString(Console.ReadLine());
            Console.WriteLine(str_index);
            string adress_index = Convert.ToString(Console.ReadLine());
            string str_email = " So, your E-Mail adress is : ";
            string email_adress = (adress_index + '@' + domain);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str_email + email_adress + '.' + n);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(str_password);
            string password = Convert.ToString(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str_password_end + password + nn + str_reg_end);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(str_login);
            string ent_adress = Convert.ToString(Console.ReadLine());
            if (ent_adress != email_adress)
            {
                string answer = "Not correct E-Mail adress.";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(answer);
                Console.ReadKey();
                return;
            }
            else if (ent_adress == email_adress)
            {
                string answer = " And enter your password:";
                Console.WriteLine(answer);
                string ent_password = Convert.ToString(Console.ReadLine());
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                if (ent_password != password)
                {
                    string answer_2 = "Not correct password.";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(answer_2);
                    Console.ReadKey();
                    return;
                }
                else if (ent_password == password)
                {
                    string answer_2 = "Congratulations! Your login is completed succesfully!";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answer_2);
                    Console.ReadKey();
                }
            }
        }
    }
}