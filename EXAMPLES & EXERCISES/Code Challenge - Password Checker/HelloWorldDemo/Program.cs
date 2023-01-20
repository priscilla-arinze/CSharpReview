using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo
{
    class Program
    {

        public static string StringChallenge(string str)
        {

            // Length variables
            int minLength = 8;
            int maxLength = 30;
            int passwordLength = str.Length;
            string symbols = "!/{}[]^*-+=%().<>";

            //Condition variables
            bool passwordInputNotEmpty = passwordLength > 0;
            bool moreThan7Length = str.Length >= minLength; 
            bool lessThan31Length = str.Length <= maxLength;
            bool containsNumber = str.Any(char.IsDigit);
            bool containsPasswordPhrase = str.ToLower().Contains("password");


            bool hasSymbol = false;
            foreach (char c in symbols)
            {
                if (str.Contains(c))
                {
                    hasSymbol = true;
                    break;
                }
            }

            bool hasCapital = false;
            foreach (char c in str)
            {
                if (c.ToString().ToUpper() == c.ToString())
                {
                    hasCapital = true;
                    break;
                }
            }


            // CONDITIONAL LOOP
            if (passwordInputNotEmpty)
            {
                if (moreThan7Length && lessThan31Length && containsNumber && hasSymbol && (!containsPasswordPhrase) && hasCapital)
                {
                    str = "true";
                }

                else
                {
                    str = "false";
                }
            }

            else
            {
                str = "false";
            }

            return str;

        }

        static void Main(string[] args)
        {
            /*Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Hellooo");

            //Console.ReadKey();

            Console.ResetColor();*/

            Console.WriteLine(StringChallenge(Console.ReadLine()));
        }
    }
}
