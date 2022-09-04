/*string[] fradulentOrderIDs = new string[3];

fradulentOrderIDs[0] = "A123";
fradulentOrderIDs[1] = "B456";
fradulentOrderIDs[2] = "C789";
//fradulentOrderIDs[3] = "D000"; */

/*
string[] fradulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fradulentOrderIDs[0]}");
Console.WriteLine($"Second: {fradulentOrderIDs[1]}");
Console.WriteLine($"Third: {fradulentOrderIDs[2]}");

fradulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fradulentOrderIDs[0]}"); 

Console.WriteLine($"There are {fradulentOrderIDs.Length} fradulent orders to process.");
*/

//understanding FOREACH STATEMENTS
/*
string[] names = { "Ekene", "Amarachi", "Beluchi" };
foreach (string name in names)
{
    Console.WriteLine(name);   
}
*/

int[] inventory = { 200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");
