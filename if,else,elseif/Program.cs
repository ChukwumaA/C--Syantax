Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);


int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!, +6 bonus to total!");
        total += 6;
        Console.WriteLine("Your score is now " + total+".\n");
    }
    else
    {
        Console.WriteLine("You rolled doubles!, +2 bonus to total!");
        total += 2;
        Console.WriteLine("Your score is now " + total+".\n");
    }
    
}


if (total >= 16)
{
    Console.WriteLine("Congrats, You scored 16 and above, hooray.\nYou Win a new car\n");
}
else if (total >= 10)
{
    Console.WriteLine("You scored 10 and above\nYou win a new laptop\n");
}
else if (total == 7)
{
    Console.WriteLine("You scored 7 \nYou win a trip for two\n");
}
else
{
    Console.WriteLine("You win a kitten.\n");
}

//Test the string.Contains() method
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say");
}