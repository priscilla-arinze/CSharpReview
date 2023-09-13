using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordCheckerNET6
{
    public class PasswordCheckerValidation
    {
        /// <summary> Returns a boolean of whether the given password passes the following validation criteria using LINQ
        /// <para>Validation Criteria:</para>
        /// <para>1. Must be between 8-30 characters in length</para>
        /// <para>2. Must contain at least 1 number</para>
        /// <para>3. Must contain at least 1 capital letter (A-Z)</para>
        /// <para>4. Must contain at least 1 symbol (includes spaces)</para>
        /// <para>5. Must NOT contain the word "password", regardless of case</para>
        /// </summary>
        public bool ValidatePasswordLINQ(string password)
        {
            int passwordLength = password.Length;

            if (passwordLength < 8 || passwordLength > 30)
            {
                return false;
            }

            string symbols = " !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

            bool validateNums = password.Any(c => Char.IsDigit(c));
            bool validateCaps = password.Any(c => (int)c >= 65 && (int)c <= 90);
            bool validateSymbols = password.Intersect(symbols).Any();
            bool validateNoPasswordKeyword = !(password.ToLower().Contains("password"));

            return validateNums && validateCaps && validateSymbols && validateNoPasswordKeyword;
        }


        /// <summary> Returns a boolean of whether the given password passes the following validation criteria using Regular Expressions (Regex)
        /// <para>Validation Criteria:</para>
        /// <para>1. Must be between 8-30 characters in length</para>
        /// <para>2. Must contain at least 1 number</para>
        /// <para>3. Must contain at least 1 capital letter (A-Z)</para>
        /// <para>4. Must contain at least 1 symbol (includes spaces)</para>
        /// <para>5. Must NOT contain the word "password", regardless of case</para>
        /// </summary>
        public bool ValidatePasswordREGEX(string password)
        {
            int passwordLength = password.Length;

            if (passwordLength < 8 || passwordLength > 30)
            {
                return false;
            }

            Regex patternNums = new Regex("[0-9]+");
            Regex patternCaps = new Regex("[A-Z]+");
            Regex patternNoSymbols = new Regex("^[a-zA-Z0-9]*$");
            Regex patternPasswordKeyword = new Regex("password");

            bool validateNums = patternNums.IsMatch(password);
            bool validateCaps = patternCaps.IsMatch(password);
            bool validateSymbols = !(patternNoSymbols.IsMatch(password));
            bool validateNoPasswordKeyword = !(patternPasswordKeyword.IsMatch(password.ToLower()));

            return validateNums && validateCaps && validateSymbols && validateNoPasswordKeyword;
        }
    }
}
