//Microsoft solution

string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split(' ');
foreach (var item in message)
{
    Console.WriteLine(item);
}

string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    Console.WriteLine(letters);
    newMessage[i] = new string(letters);
}
string result = String.Join(" ", newMessage);
Console.WriteLine(result);


//My approach
/*
string pangram = "The quick brown fox jumps over the lazy dog";

char[] pangramLastToFirst = pangram.ToCharArray();
Array.Reverse(pangramLastToFirst);
string result = new string(pangramLastToFirst);
Console.WriteLine(result);

string[] resultArray = result;
for (int i = 0; i < resultArray.Length; i--)
{

}

try if for loop will work
try the split, split the string into an array
revese the index positions of the letters to look like the challenge
*/


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] convertToArray = orderStream.Split(',');

foreach (var item in convertToArray)
{
    if(item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}
