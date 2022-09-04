// string firstName = "Bob";
// string greeting = "Hello";
// string message = greeting + " " + firstName + "!";
//Console.WriteLine(greeting + " " + firstName + "!")
// Console.WriteLine(message);
// Console.WriteLine("\n");
// string message2 = $"{greeting} {firstName}!";


// string firstName = "Bob";
// string message = $"Hello {firstName}!";
// Console.WriteLine(message);

// string firstName = "Bob";
// string greeting = "Hello";
// string message = $"{greeting} {firstName}!";
// Console.WriteLine(message);

// string firstName = "Bob";
// string greeting = "Hello";
// Console.WriteLine($"{greeting} {firstName}!");

// string projectName = "First-Project";
// Console.WriteLine($@"C:\Output\{projectName}\Data");

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English Output:\n\t\t C:\Exercise\{projectName}\data.txt");

Console.WriteLine($@"{russianMessage}:\n\t\t C:\Exercise\{projectName}\ru-RU\data.txt");

//My apprach above was wrong
//What they did was, they made a variable that called the verbatim literal
//Before the character escape sequence
string projectName2 = "ACME";
string englishLocation = $@"c:\Exercise\{projectName2}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
            
string russianMessage2 = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName2}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage2}:\n\t\t{russianLocation}\n");

string projectName3 = "IMISI3D";
string projectLocation = $@"C:\Directory\{projectName3}\data.exe";
Console.WriteLine($"View Project Location: \n\t\t {projectLocation}\n");

string japaneseMsg = "\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a";
string japaneseLocation = $@"C:\Exercise\{japaneseMsg}\jp-JP\data.txt";
Console.WriteLine($"{japaneseMsg}: \n\t\t{japaneseLocation}\n");
