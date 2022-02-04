
int children = 3;
Console.WriteLine(children);

string firstName = "Angela";
Console.WriteLine(firstName);


char middleInitial = 'N';
Console.WriteLine(middleInitial);

DateTime date1 = new DateTime(2022, 2, 3);
Console.WriteLine(date1.ToString());

int subtractionResult = 10 - 3;
Console.WriteLine("10 - 3 = " + subtractionResult);

string lastName = "Martin";
string interpolationResult = $"Her full name {firstName} {middleInitial} {lastName}!";
Console.WriteLine(interpolationResult);

Console.WriteLine("Are you wearing clothes?");
string answer = Console.ReadLine();

string greeting = answer switch
{
    "Yes" => "I'm glad you're wearing clothes",
    "No" => "Maybe put some clothes on",
    _ => "Please answer the question above",
};
Console.WriteLine(greeting);

switch (answer)
{
    case "Yes":
        Console.WriteLine("I'm glad you responded " + answer);
        break;
    case "No":
        Console.WriteLine("Did you seriously say " + answer);
        break;
    default:
        break;
}

Console.WriteLine("Please rate your outfit today on a scale of 1-5");
string outfit = Console.ReadLine();

switch (outfit)
{
    case "5":
        Console.WriteLine("Looking good!");
        break;
    case "4":
        Console.WriteLine("Nice - add accessories.");
        break;
    case "3":
        Console.WriteLine("Pretty good, but could use a little more work.");
        break;
    case "2":
        Console.WriteLine("Hmmm...try a little harder.");
        break;
    case "1":
        Console.WriteLine("Yikes.");
        break;
    default: //only used if none of the other cases are matches
        Console.WriteLine("Sorry, we don't understand. Please try again later.");
        break;
}

Console.WriteLine("Please choose a restaurant for your lunch order.");
string restaurant = Console.ReadLine();

switch (restaurant)
{
    case "Wendy's":
        Console.WriteLine("S-tier choice! Good job!");
        break;
    case "McDonald's":
        Console.WriteLine("That's nasty.");
        break;
    case "Chick-fil-a":
        Console.WriteLine("Homophobic but the chicken is good.");
        break;
    case "Chipotle":
        Console.WriteLine("Don't forget guac is extra.");
        break;
    case "Arby's":
        Console.WriteLine("Underrated choice.");
        break;
    default:
        Console.WriteLine("Sorry, we didn't get that. Please type your selection.");
        break;
}

