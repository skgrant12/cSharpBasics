bool isSnowing = false;
bool isGoingOutside = false;
// if(true/false value)
//{
// body of the code, execute this code if above is true

if (isSnowing)
{
    Console.WriteLine("It is snowing outside!");
}

if (isSnowing && isGoingOutside)
{
    Console.WriteLine("Better wear some snowboots!");
}

//bang makes a statement false
// || means or, runs both sides of the statement 
//if !isSnowing is false, then move onto !isGoingOutside
//otherwise
if (!isSnowing || !isGoingOutside)
{
    Console.WriteLine("I do not need any boots.");
}

// The ^ operator computes the logical exclusive OR, aka logical XOR, of its operands. The result of x ^ y is true if x evaluates to true and y evaluates to false, or x evaluates to false and y evaluates to true. Otherwise, the result is false. 
// ^ runs each side of the statement exclusively.
if (isSnowing ^ isGoingOutside)
{
    Console.WriteLine("I will only go outside once the snow stops!!!");
}


if (!isSnowing)
{
    Console.WriteLine("There is no need to shovel snow.");
}

//else = default or catchall statement. If nothing else is true, run an else statement - helpful for debugging.
else
{
    Console.WriteLine("I guess I need to shovel.");
}

//computer would hit the first if statement if !isSnowing is true.
//if both if and else if are false, then it would hit the else statement on the bottom.
// else if prevents more lines of code from being run and slowing down the computer.

if (isSnowing)
{
    Console.WriteLine("I guess I have to go clear off my husband's cars.");
}

else if(!isSnowing){
    Console.WriteLine("I don't have to clear off the cars!");
}

else
{
    Console.WriteLine("I don't know what we are even talking about.");
}

// Challenge 

bool hasUmbrella = true;
bool isStayingInside = false;

if(hasUmbrella && !isStayingInside)
{
    Console.WriteLine("Good thing I have my umbrella so I can go outside while It's raining!");
}

if(!hasUmbrella && !isStayingInside)
{
    Console.WriteLine("I'd better go get my umbrella so I don't get wet!!");
}
