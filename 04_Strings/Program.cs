string first = "The cars we sell are";
string second = "BMW, Lexus, Mercedes, and Tesla.";

string concatenatedResult = first + " " + second; 

Console.WriteLine(concatenatedResult);

string firstName = "Jenny";
string lastName = "Williams";

// It uses curly braces () inside the string itself with a number inside the braces.

// The number stands for the index, which starts by counting at 0 being the first! It always starts at 0.

string compositeResult = string.Format("Her name is {0} {1}", firstName, lastName, first, second);

Console.WriteLine(compositeResult);
Console.WriteLine("Her name is {0} {1}", firstName, lastName);

string interpolationResult = $"Her name is still {firstName} {lastName}!";
Console.WriteLine(interpolationResult);