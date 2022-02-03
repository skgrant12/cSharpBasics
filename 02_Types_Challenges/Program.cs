string firstName = "Scott";
string lastName = "Calvin"; 
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

string words = "This is a string";
int integer = 100;
string wordsPlusNumber = words + integer;
Console.WriteLine(wordsPlusNumber);

// Gold 
// How to convert a string to a number: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
string year = "2022";
int yearNumber = int.Parse(year);
Console.WriteLine(yearNumber);

// There are 2 different ways to do it.
int anotherNumber = Convert.ToInt32(year);
Console.WriteLine(anotherNumber);
