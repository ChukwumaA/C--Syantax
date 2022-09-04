string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//Solution
//Create a varibable message and total, sice that is what i'll pass to the console window
decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal digitInArray = 0m;
    if (decimal.TryParse(value, out digitInArray))
    {
        total += digitInArray;
    }
    else 
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Message: {total}");