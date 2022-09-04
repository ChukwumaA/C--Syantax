//Showing a locally scoped varibable
/*
int value = 0;

bool flag = true;
if (flag)
{
    value = 10; 
    Console.WriteLine($"Inside of the code block: {value}");
}

Console.WriteLine($"Outside of the code block: {value}");
*/

//Code blocks define methods, classes and namespaces

//Calling a method in the same class
/*
string value = "Microsoft Learn";
string reversedValue = Reverse(value);
Console.WriteLine($"Secret message: {reversedValue}");

string Reverse(string message)
{
    char[] letters = message.ToCharArray();
    Array.Reverse(letters);
    return new string(letters);
}
*/

//Calling a method from a different class
/*
string value = "Microsoft Learn";
string reversedValue = Utility.Reverse(value);
Console.WriteLine($"Secret message: {reversedValue}");

class Utility
{
    public static string Reverse(string message)
    {
        char[] letters = message.ToCharArray();
        Array.Reverse(letters);
        return new string(letters);
    }
}
*/

//Referencing a class in a different namespace
/*
    string value = "Microsoft Learn";
    string reversedValue = ScopeinCodeBlocks.Utilities.Utility.Reverse(value);
    Console.WriteLine($"Secret message: {reversedValue}");

namespace ScopeinCodeBlocks.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}
*/


//Using the "USING" statements
using ScopeinCodeBlocks.Utilities;

string value = "Microsoft Learn";
string reversedValue = Utility.Reverse(value);
Console.WriteLine($"Secret message: {reversedValue}");

namespace ScopeinCodeBlocks.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}