// string[] fakeOrderID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// foreach (string items in fakeOrderID)
// {
//     if (items.StartsWith("B"))
//     {
//         Console.WriteLine(items);
//     }
    
// }




//Coding Practice Module
//Comment chapter
//-the code below shows poorly commented code or low quality comments
//I edited the poorly commented code for this

/*
    The following code creates five random OrderIDs
    to test the fraud detection process. OrderIDs
    consist of a letter from A to E, and a three digit
    number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}


//Illustrating whitespace
Console
.
WriteLine
(
    "Hello World"
)
;

// Example 2:
string firstWord="Hello";string lastWord="World";Console.WriteLine(firstWord+" "+lastWord+"!");


//Comment challenge

//This code reverses a string and count 
//the number of times a particular 
//character appears
string message = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = message.ToCharArray();

Array.Reverse(charMessage);

int number = 0;
foreach(char item in charMessage)
{
    if (item == 'o')
    {
        number++;
    }
}

string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {number} times.");


//What microsoft learn did
/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message3 = originalMessage.ToCharArray();
Array.Reverse(message3);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage2 = new String(message3);

Console.WriteLine(newMessage2);
Console.WriteLine($"'o' appears {letterCount} times.");