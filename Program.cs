using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator
{
    class Program
    {
        static string imie;

        static void Main(string[] args)
        {
            Introduction();
            Setting();         
        }

        static void ColorsWrite(ConsoleColor color, string write, char line = 'y')
        {
            Console.ForegroundColor = color;

            switch(line)
            {
                case 'y':
                    Console.Write($"\n{ write}");
                    break;
                case 'n':
                    Console.Write($"{write}");
                    break;
            }

            Console.ResetColor();
        }

        static void ColorsLine(ConsoleColor color, string write, char line = 'y')
        {
            Console.ForegroundColor = color;

            switch (line)
            {
                case 'y':
                    Console.WriteLine($"\n{ write}");
                    break;
                case 'n':
                    Console.WriteLine($"{write}");
                    break;
            }

            Console.ResetColor();
        }

        static void Introduction()
        {
            ColorsLine(ConsoleColor.DarkRed, "Witaj!!", 'n');
            ColorsWrite(ConsoleColor.DarkRed, "Podaj swoje imię: ", 'n');
            imie = Console.ReadLine();

            Console.Clear();
        }

        static int Asking()
        {
            int set = 0;

            ColorsLine(ConsoleColor.Blue, "Prosty Kalkulator \n", 'n');
            ColorsLine(ConsoleColor.Green, $"W prostym kalkulatorze możesz wykonać 4 proste działania matematyczne. Wybierz jedno {imie}");

            ColorsLine(ConsoleColor.Magenta, "1. Dodawanie");
            ColorsLine(ConsoleColor.Magenta, "2. Odejmowanie");
            ColorsLine(ConsoleColor.Magenta, "3. Mnożenie");
            ColorsLine(ConsoleColor.Magenta, "4. Dzielenie");
            ColorsLine(ConsoleColor.Magenta, "5. Wyjście z kalkulatora");

            set = Checking("Jakie działanie matematyczne chcesz przeprowadzić: ");

            return set;
        }

        static void Setting()
        {
            Console.Clear();

            int pick;

            pick = Asking();

            switch (pick)
            {
                case 1:
                    Console.Clear();

                    Dodawanie();
                    break;
                case 2:
                    Console.Clear();

                    Odejmowanie();
                    break;
                case 3:
                    Console.Clear();

                    Mnożenie();
                    break;
                case 4:
                    Console.Clear();

                    Dzielenie();
                    break;
                case 5:
                    Environment.Exit(0)
;                    break;
                default:

                    Setting();
                    break;
            }

            
        }

        private static void Dodawanie()
        {
            int a, b, c;

            ColorsLine(ConsoleColor.DarkBlue, "Podaj dwie liczby jakie chciałbyś dodać");
            a = Checking("Podaj pierwszą liczbę: ");
            b = Checking("Podaj drugą liczbę: ");
            c = a + b;

            ColorsLine(ConsoleColor.Yellow, $"Wynik Dodawania to {c}");

            Console.ReadKey();
            Setting();
        }

        static void Odejmowanie()
        {
            int a, b, c;

            ColorsLine(ConsoleColor.DarkBlue, "Podaj dwie liczby które chciałbyś od siebie odjąć");
            a = Checking("Podaj pierwszą liczbę: ");
            b = Checking("Podaj drugą liczbę: ");
            c = a - b;

            ColorsLine(ConsoleColor.Yellow, $"Wynik Odejmowania to {c}");

            Console.ReadKey();
            Setting();
        }

        static void Mnożenie()
        {
            int a, b, c;

            ColorsLine(ConsoleColor.DarkBlue, "Podaj dwie liczby które chciałbyś pomnożyć");
            a = Checking("Podaj pierwszą liczbę: ");
            b = Checking("Podaj drugą liczbę: ");
            c = a * b;

            ColorsLine(ConsoleColor.Yellow, $"Wynik Mnożenia to {c}");

            Console.ReadKey();
            Setting();
        }

        static void Dzielenie()
        {
            int a, b, c;
            int d, f;
            ColorsLine(ConsoleColor.DarkBlue, "Podaj dwie liczby które chciałbyś podzielić");
            a = Checking("Podaj pierwszą liczbę: ");
            d = Checking(a);
            b = Checking("Podaj drugą liczbę: ");
            f = Checking(b);
            c = d / f;

            ColorsLine(ConsoleColor.Yellow, $"Wynik Dzielenia to {c}");

            Console.ReadKey();
            Setting();
        }

        private static int Checking(string write)
        {
            int number = 0;
            bool var_Correct = true;
            string check;

            while (var_Correct)
            {
                ColorsWrite(ConsoleColor.Green, write);

                check = Console.ReadLine();

                if (Int32.TryParse(check, out number))
                {
                    var_Correct = false;
                }
                else
                {
                    ColorsLine(ConsoleColor.Red, "Nie rozpoznano znaku.");
                    
                }
            }

            return number;
        }

        static int Checking(int notZero)
        {
            bool var_Correct = true;
            

            while(var_Correct)
            {
                if(notZero == 0)
                {
                    ColorsLine(ConsoleColor.Red, "Nie można dzielić przez zero.  ");
                    notZero = Checking("Podaj poprawną liczbę: ");
                }
                else
                {
                    var_Correct = false;
                }
            }

            return notZero;
        }
    }
}
