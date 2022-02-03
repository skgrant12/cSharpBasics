Console.Write("Enter your age:");
string response = System.Console.ReadLine();

//if the string can be parsed into a NUMBER, please do it
int age = int.Parse(response);

//Computer gives us a prompt, if we answer something > or  = the number, it's true, so we get "you can vote" 
//If what we put in is false, or < 18, then we get the second response, "You're too young to vote!"
string output = age >= 18 ? "You can vote!" : "You're too young to vote!";
Console.WriteLine(output);

