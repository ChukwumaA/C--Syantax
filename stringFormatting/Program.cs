//STRING FORMATTING BASICS
/*
//What is composite formatting
string first = "Hello";
string second = "World";

string result = string.Format("{0}, {1}!\n", first, second);
Console.WriteLine(result);

Console.WriteLine(first + ", "+ second + "!" );
Console.WriteLine($"{first}, {second}!\n");


//more composite examples
Console.WriteLine("\n{1} {0}!", first, second);
Console.WriteLine("*{0}-{0}!", second, first); //this is what i created
Console.WriteLine("*{1}-{0}!", second, first); //this is what i created
Console.WriteLine("{0} {0} {0}!", first, second);

//String Interpolation
Console.WriteLine($"\n{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

//Formtting Currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"\nPrice: {price:C} (Save {discount:C})\n");

//Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units\n");

//Formatting percentages
decimal tax = .367585m;
Console.WriteLine($"Tax Rate: {tax:P2}");

*/



//Exercise - String Interpolation
/*
Suppose we want to print a receipt for the sale of a chemical solvent used in industrial 
settings. While our scales measure in micrograms, we price each sale in milligrams 
(a thousandth of a gram). To print the receipt, we would likely need to combine data of 
different types, including fractional values, currency, and percentages in precise ways.
*/

/*
int invoiceNumber = 1201;
decimal productMeasurement = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
//Billing customers acording to milligram which is x10^-3
Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
//The subtotal we will charge the customer in formatted currency
Console.WriteLine($"     Sub Total: {subtotal:C}");
//Displaying the charge on the sale of formatted as a percentage
Console.WriteLine($"           Tax: {taxPercentage:P2}");
//Receipt with  total amount due formatted as a currency
Console.WriteLine($"     Total Due: {total:C}\n");

*/
//Padding and alignment
/*
string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
*/


//Add the orderId to the output
//Add the payee name to the output
//Add the payment amount to the output

string paymentId = "769";
string payeeName = "Mr. Emeka Achebe";
string paymentAmount = "$5,000.00";

//The integer passed as an argument in the PadRight methods is the total width, counting the entire width of the string, including, symbols and characters,
//The remaining integers will be passed as whitespaces.
//The sae things happens for PadLeft
//Also PadLeft takes an overloaded operator that looks like
//PadLeft(6, '-'), which represents (int totalWidth, char Seperator)

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
//Adding a line of numbers above the output to more easily confirm the result
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

