/*
//Code to find an pening and closing parenthesis embedded in a string
string message = "Find what is (inside the parenthesis)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition); //answer = 13
Console.WriteLine(closingPosition);


//Updating code to modify the starting poition of the substring
openingPosition += 1;

//Adding code to retrieve th value between two parenthesis characters

int length = closingPosition - 14;
Console.WriteLine(message.Substring(14, length));


int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


string sentence = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingTarget = sentence.IndexOf(openSpan);
int closingTarget = sentence.IndexOf(closeSpan);


openingTarget += openSpan.Length;
int wordInBetween = closingTarget - openingTarget;

Console.WriteLine(sentence.Substring(openingTarget, wordInBetween));

//"const" keyword. A constant allows you to define and initiliaze a 
//variable whose value can never be changed


//Code to retrieve the last occurence of a sub string --LastIndexOf
    //Adding many sets of parentheses, then write code to retrieve the content inside the last set of parenthesis

string information = "(What if) I am (only intrersted) in the last (set of parentheses)?";
int openingInformation = information.LastIndexOf('(');

openingInformation += 1;
int closingInformation = information.LastIndexOf(')');
int width = closingInformation - openingInformation;
Console.WriteLine(information.Substring(openingInformation, width),"\n");

*/
//We uodated the code example to retieve any value between one or more 
//sets of parentheses in a string

string text = "(What if) there are (more than) one (set of parentheses)?";
while(true)
{
    int openingArgument = text.IndexOf('(');
    if (openingArgument == -1) break;

    openingArgument += 1;
    int closingArgument = text.IndexOf(')');
    int distance = closingArgument - openingArgument;
    Console.WriteLine(text.Substring(openingArgument, distance));

    //We used the overload of substring to return only the remaining
    //Unprocessed text:
    text = text.Substring(closingArgument + 1);
}

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

//The IndexOfAny() helper method require a char array of characters.
//We want to look for:

char[] openSymbols = { '[', '{', '('};;
    //We'll use a slightly different technique for iterating through the
    //characters in the string. This time, we'll use the closing position
    //of the previous iteration as the starting index for the next open
    //symbol. So, we need to initialize the closingPosition variable to zero.

int closingPosition = 0;

while(true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    //Now we must find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    //To find the closingPosition, we use an overload of the indexOf method to specify
    //that our search for the matchingSymbol should start at the openingPosition in the string.

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    //Finally, use the technique we've already learned to display the sub-string
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}