namespace BasicSyntax;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n");

        //// PRINT STATEMENT
        Console.WriteLine("i am a print statement");
        Console.WriteLine("\n\n");



        //// KEYBOARD INPUT
        Console.Write("Enter any string: ");
        string str = Console.ReadLine();
        Console.WriteLine("\n\n");



        //// COMMON OPERATORS & OPERATIONS
        int a, b, c, d, e;
        a = 2;
        b = 4;
        c = 6;
        d = 8;
        e = 10;

        //Arithmetic Operators
        a = a + 2; //4
        b = b - 1; //3
        c = c * 2; //12
        d = d / 1; //8
        e = 10 % 2; //0

        //Relational Operators
        bool result_equal = (a == b);
        bool result_notequal = (a != b);
        bool result_greater = (a > 1);
        bool result_greater_equal = (a >= 1);
        bool result_lesser = (d < 1);
        bool result_lesser_equal = (d <= 1);

        //Logical Operators
        bool result_and = (result_greater && result_lesser);
        bool result_or = (result_greater || result_lesser);
        bool result_not = !(result_greater || result_lesser);

        //Increment and Decrement Operators
        c = c++; //increment by one; same as --> c = c + 1
        b = a--; //decrement by one; same as --> b = a - 1

        int num1 = 10;
        num1 = num1++;
        int num2 = 10;
        num2 = ++num2;
        Console.WriteLine($"Increment after printing: {num1}");
        Console.WriteLine($"Increment before printing: {num2}");
        Console.WriteLine("\n\n");

        //Ternary Operator (shortened if-else statement)
        c = a >= 100 ? b : c / 10; // Condition ? valueIfTrue : valueIfFalse

        //Compound Assignment Operators
        a += 1; //5; same as --> a = a + 1
        b -= 2; //1; same as --> b = b - 2;
        c *= 10; //120; same as --> c = c * 10;
        d /= 2; //4; same as --> d = d / 2
        d %= 2; //0; same as --> d = d % 2



        //// ARRAYS/LISTS
        var numbers = new List<int>(new[] { 1, 2, 3 });
        
        string[] fruit = {"apple", "applesauce", "red apple", "green apple", "red apple again"};

        var scores = new[] { 90, 97, 78, 68, 85 };



        //// STRINGS
        string str2 = "i am a string";

        //String Interpolation (format strings)
        Console.WriteLine($"here is a random string i entered previously: {str}");
        Console.WriteLine("\n");

        //Indexing
        char ch = str[str.Length - 1];
        Console.WriteLine($"Last character in previously entered string: {ch}");

        //Concatenation
        string str3 = "i " + "am " + "doing " + "the " + "contenating ";

        string[] words = { "I", "Like", "Bread"};

        var unreadablePhrase = String.Concat(words);
        System.Console.WriteLine($"Concatenation using String.Concat (no spaces): {unreadablePhrase}");

        var readablePhrase = String.Join(" ", words);
        System.Console.WriteLine($"Concatenation using String.Join (with spaces): {readablePhrase}");

        string date = String.Format("Using String.Format: Today's date is {0}", DateTime.Now);
        Console.WriteLine(date);

        //Length
        Console.WriteLine($"The previously entered string this {str.Length} letters in it.");

        //Trim

    }
}
