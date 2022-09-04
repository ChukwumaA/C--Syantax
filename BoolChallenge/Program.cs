Random coin = new Random();
int flip = coin.Next(0, 2);

string toss =  flip == 0 ? "heads" : "tails"; 
Console.WriteLine(toss);

string permission = "";
int level = 53;

//My soulution logic fail 2 tests i can think of, 
//Hence microsoft solution wins
string user = permission.Contains("Admin") && level > 56 ?  "Welcome, Super Admin user": "Welcome, Admin user";
string user2 = permission.Contains("Manager") && level >= 20 ?  "Contact an Admin for Access": "You do not have suficient priviledges";
string user3 = !permission.Contains("Admin|Manager") ?  "You do not have sufficient priviledges" : "" ;

Console.WriteLine(user);
Console.WriteLine(user2);
Console.WriteLine(user3);

//Microsoft Solution


if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}