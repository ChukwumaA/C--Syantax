int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

//Something to note, casting rounds down(truncates), convert rounds up.
int result1 = value1/(int)value2;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2/(decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3/(float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

/*
//This was microsoft solution
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

//here we are trying out the convert method, after widening the value of value1, to converting the entire answer to an Int32() format.
int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//This is a widening conversion
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//Thisis a narrowing conversion, that's why there was no need for passing the (int) cast on value1
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

//truly, i understand why they did what they did
*/