//A complex condition comes before a simpler condition
//As we can see the  if ((i % 3 == 0) && (1 % 5 == 0))
//Condition joined by an && or || comes before the plain 
//condition

for (int i = 1; i <= 100; i ++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine((i) + "- FizzBuzz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else
        Console.WriteLine(i);
}

//Microsoft "One possible solution"
// for (int i = 1; i <= 100; i++)
// {
//     if ((i % 3 == 0) && (i % 5 == 0))
//         Console.WriteLine($"{i} - FizzBuzz");
//     else if (i % 3 ==0)
//         Console.WriteLine($"{i} - Fizz");
//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");
//     else 
//         Console.WriteLine($"{i}");
// }