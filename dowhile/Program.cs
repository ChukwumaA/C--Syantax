/*
Random random = new Random();
int current  = 0;

do{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

//A while statement
/*
Random random = new Random();
int current = random.Next(1,11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1,11);
}
Console.WriteLine($"Last number : {current}");
*/


//Using the continue keyword
Random random = new Random();
int latest = random.Next(1, 11);

do{
    latest = random.Next(1, 11);
        if (latest >= 8) 
            continue;
    Console.WriteLine(latest);
} while (latest != 7);