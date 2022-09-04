//counting up
for (int fromZeroToNine = 0; fromZeroToNine < 10; fromZeroToNine++)
{
    //Console.WriteLine(fromZeroToNine);
}

//Counting down
for (int i = 10; i >= 0; i--)
{
    //Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
    //Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    //Console.WriteLine(i);
    if (i == 7)
    break;
}

/*
//Shwowing for statment benefits over freach statements when handling arrays
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    //Console.WriteLine(names[i]);
}

//foreach limitation
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    if (name == "David") 
        name = "Sammy";
//    Console.WriteLine(name);
} */

//Overcoming the foreach limitation using the for statement
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David")
        names[i] = "Sammy";

foreach (var name in names)
    Console.WriteLine(name);