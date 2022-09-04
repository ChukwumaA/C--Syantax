
//Call methods from the .NET Class Library using C#

/*
int firstValue = 500;
int secondValue = 600;

int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);*/

//IF, ELSE, ELSE IF, statements in c#
Random random = new Random();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

//Chukwuma Akunyili Solution
if(daysUntilExpiration < 1)
{
    Console.WriteLine("Your subscription has expired");
}
else if(daysUntilExpiration == 1 )
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day\nRenew now and save {discountPercentage}%");
}

else if(daysUntilExpiration <=5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days or less\nRenew now and save {discountPercentage}%");
}

else if(daysUntilExpiration <= 10)
{
Console.WriteLine("Your subscription will expire soon. Renew now!");
}

else if(daysUntilExpiration > 10)
{
    Console.WriteLine("Nothing");
}






//Microsoft Solution
// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if(daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day");
//     discountPercentage = 20;
// }
// else if(daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subcription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if(daysUntilExpiration <=10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }