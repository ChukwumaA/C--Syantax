//Question 1
/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
*/

//Question 2
/*
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
*/

/*
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");


decimal myDecimal2 = 1.23456789m;
float myFloat = (float)myDecimal2;

Console.WriteLine($"Decimal: {myDecimal2}");
Console.WriteLine($"Float: {myFloat}");

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

string third = "5";
string fourth = "7";
int sum = int.Parse(third) + int.Parse(fourth);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

//Casting versus Conversion
int value = (int)1.999999m; //casting truncates
Console.WriteLine(value);

int valueTwo = Convert.ToInt32(1.499999m); //converting rounds up
Console.WriteLine(valueTwo);
*/


//the TryParse() method
/*
string name = "Bob";
Console.WriteLine(int.Parse(name));
*/

//TryParse() a string into an int with an out parameter
string value = "badass";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to  report the measurement");
}
//Since int result is defined outside of the if statement,
//It can be accessed later in your code
if (result > 0)
Console.WriteLine($"Measurement (w/offset): {50 + result}");