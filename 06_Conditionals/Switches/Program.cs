Console.WriteLine("Please give us your name!");
string name = Console.ReadLine();
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

switch (feelingRating)
{
    case "5":
        Console.WriteLine("That's great to hear!");
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

