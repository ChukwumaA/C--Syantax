/*
string[] pallets = { "B14", "A11", "B12", "A13" };

//Using Sort method in the array class
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


//Using Reverse method in the array class
Console.WriteLine("\nReversed");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//Using Clear method in the array class
//What if we attempt to retrieve the value of an element that was affected by thr Array.Clear() method

Console.WriteLine($"\nBefore: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
if(pallets[0] != null)
    Console.WriteLine($"\nAfter: {pallets[0].ToLower()}");
//The output here stored in pallets[0], the c# compiler implicitly converts the null value to an empty string for presentation
Console.WriteLine($"\nClearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");   
}

//Calling a string helper method on a cleared element
    //To prove the value stored in pallets[0] after being cleared is null, 
    //We will apply the ToLower() method on pallets[0].
    //If it is a string, it should work fine, but
    //if it is null, it should throw an exception

//Array.Clear() will remove an array element's reference to a value if one exists.
    //An apprach to fix this, will be to check for null before attempt to print the value.
//We add an "if statement" before accessing an array element that is potentially null.



//REsizing an array to add more elements
Array.Resize(ref pallets, 6);
Console.WriteLine($"\nResizing 6 ... count: {pallets.Length}");

pallets[4] = "CO1";
pallets[5] = "C02";


foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Resize(ref pallets, 3);
Console.WriteLine($"\nResizing 3 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

*/

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);

//using the Join() method
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}