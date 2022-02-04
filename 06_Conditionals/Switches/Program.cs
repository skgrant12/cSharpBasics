//Switch Cases 

Console.WriteLine("Please give us your name!");
string name = Console.ReadLine();

//Switch Expressions - example: if the name Adam is typed, they will get the response "Hello Adam"

string greeting = name switch
{
    "Adam" => "Hello Adam",
    //If they don't put the name above, then they get "Who are you?" sort of like a default
    _ => "Who are you?"
};
Console.WriteLine(greeting);

switch (name)
{
    case "Sarah":
        Console.WriteLine("Nice to meet you " + name);
        break;
    default:
        break;
}

Console.WriteLine("How are you feeling today on a scale of 1-5?");
string feelingRating = Console.ReadLine();

// You don't need semicolons in this example because you put break;
switch (feelingRating)
{
    case "5":
        Console.WriteLine("That's great to hear!");
        //Break means the console will stop running
        break;
    case "4":
        Console.WriteLine("Good stuff!");
        break;
    case "3":
        Console.WriteLine("Hope things improve!");
        break;
    case "2":
        Console.WriteLine("Oh. Sorry to hear that!");
        break;
    case "1":
        Console.WriteLine("Dang. We hope your day gets better!");
        break;
    default: //only used if none of the other cases are matches
        Console.WriteLine("Sorry, we don't understand. Please try again later.");
        break;
}

//If there are more than 8 possible answers to a question, go for an if statement instead of a switch.

Console.WriteLine("How were you feeling yesterday on a scale of 1-5?");
string ratingInput = Console.ReadLine();
int yesterdayRating = int.Parse(ratingInput);

//This is an example of a switch expression. A ; indicates the end of a line
string response = yesterdayRating switch
{
    1 => "Dang. Maybe today will be better", 
    2 => "Oh. Sorry to hear that",
    3 => "Nice, sounds like a good day", 
    4 => "Good stuff",
    5 => "That's wonderful to hear!",
    _ => "Sorry, we didn't understand. Please try again."
};

Console.WriteLine(response);