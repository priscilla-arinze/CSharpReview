

namespace PasswordCheckerNET6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string badPassword__password_keyword = "iAmAvERy!sECure123PAssWord!7";
            string badPassword__no_symbols = "iAmAvERysECure1237";
            string badPassword__no_capitals = "iamvery!secure123!7";
            string badPassword__morethan31chars = "iAmAvERysECure123PAssWord7";
            string badPassword__lessthan8chars = "vEry1!";
            string badPassword_no_nums = "iAmAvERy!sECurePAssWord!";

            string goodPassword = "iAmAvERy!sECure123!7";


            PasswordCheckerValidation passwordCheckerValidation = new PasswordCheckerValidation();


            Console.WriteLine(passwordCheckerValidation.ValidatePasswordLINQ(badPassword__password_keyword));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordLINQ(badPassword__no_symbols));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordLINQ(badPassword__no_capitals));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordLINQ(badPassword__morethan31chars));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordLINQ(badPassword__lessthan8chars));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordLINQ(badPassword_no_nums));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordLINQ(goodPassword));

            
            Console.WriteLine("\n\n");


            Console.WriteLine(passwordCheckerValidation.ValidatePasswordREGEX(badPassword__password_keyword));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordREGEX(badPassword__no_symbols));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordREGEX(badPassword__no_capitals));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordREGEX(badPassword__morethan31chars));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordREGEX(badPassword__lessthan8chars));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordREGEX(badPassword_no_nums));
            Console.WriteLine(passwordCheckerValidation.ValidatePasswordREGEX(goodPassword));
        }
    }
}