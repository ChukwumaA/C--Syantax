// An if statement that uses a code block
bool flag = true;
//if we remove the curly braces we get the same ouput

if (flag)

    Console.WriteLine(flag);

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else 
    Console.WriteLine("Found Chuck");



//Challenge part
int total = 0;
bool found = false;
int[] numbers = { 4, 8, 15, 16, 23, 42 };
foreach (int number in numbers)
{
    total += number;
    if (number == 42) found = true; 
}
if (found) Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");