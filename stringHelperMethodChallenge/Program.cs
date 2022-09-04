
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string openingSpan = "<span>";
const string closingSpan = "</span>";

int openingTarget = input.IndexOf(openingSpan);
int closingTarget = input.IndexOf(closingSpan);

openingTarget += openingSpan.Length;
int wordsInBetween = closingTarget - openingTarget;
quantity = input.Substring(openingTarget, wordsInBetween);

//Second Task
output = input.Replace("trade", "reg");

const string openingDiv = "<div>";
const string closingDiv = "</div>";

int opening = input.IndexOf(openingDiv);
int closing = input.IndexOf(closingDiv);

opening += openingDiv.Length;
int inBetweenDiv = closing - opening;
output = input.Substring(opening, inBetweenDiv);


Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");



//Microsoft Solution
/*
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

const string spanTag = "<span>";

// Extract the quantity
int quantityStart = input.IndexOf(spanTag);
int quantityEnd = input.IndexOf("</span>");

quantityStart += spanTag.Length;

int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);

// Set output to input, replacing the trademark symbol with the registered trademark symbol
output = input.Replace("&trade;", "&reg;");

// Remove the opening <div> tag
int divStart = input.IndexOf("<div");
int divEnd = input.IndexOf(">");
int divLength = divEnd - divStart;
divLength += 1;
output = output.Remove(divStart, divLength);

// Remove the closing <div> tag
int divCloseStart = output.IndexOf("</div");
int divCloseEnd = output.IndexOf(">", divCloseStart);
int divCloseLength = divCloseEnd - divCloseStart;
divCloseLength += 1;
output = output.Remove(divCloseStart, divCloseLength);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
*/