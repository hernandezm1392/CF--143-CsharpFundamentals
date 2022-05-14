//! IF

bool UserIsHungry = true;

if (UserIsHungry); // Value within paranthases need to equal true.
{
    System.Console.WriteLine("eat something"); // because userIsHungry is true, it will run this writeLine
}
// If userIsHungry was false, it would skip this If conditional.

//! using Operators

int hoursWorking = 1;
if(hoursWorking < 8)
{
    System.Console.WriteLine("are you even working?");
} 

//! Else
bool choresAreDone = false;

if(choresAreDone)
{
    System.Console.WriteLine("Havefunat the movies!");
}
else
{
    System.Console.WriteLine(" You need to stay home and finish your chores.");
    // when the IF is false, it runs the else. an else is a great way to catch various errors through user input.
}

string input = "7";
int totalHours = int.Parse(input); //if the string cannot be read as an int, an error will be thrown.

if(totalHours >= 8)
{
    System.Console.WriteLine("you should be well rested.");
}
else
{
    System.Console.WriteLine("you might be tired this afternoon...");
    if (totalHours < 4)
    {
        System.Console.WriteLine("you need to get some sleep!");
    }
}

/*
A persons age
    <18: You're just a kid
    18: Adult
    21: Drinking Age
    25: Insurance lowers / rent car
*/

int age = 23;
if (age >= 18)
{
System.Console.WriteLine("insurance lowers! you can rent a car!");
}
else if (age >=21)
{
        System.Console.WriteLine("drinking age!");
}
else if ("youre an adult");
{
    System.Console.WriteLine("your an adult");
}
{
    System.Console.WriteLine("youre just a kid");
}


/*
! switch cases
    - allow us to check against a case depending on the value passed, and returns a result.
*/

int intInput = 4;
string order;

switch (intInput)
{
    case 1: 
        order = "burger and fries";
        break; 
    case 2:
        order = "chicken sandwhich";
    case 3: 
        order = "tacos";
        break;
    case 4:
        order = "bean burrito";
        break;
    default: 
        order = "cup of water";
        break;
}
System.Console.WriteLine(order);

string sampleInput = "test";
switch(sampleInput)
{
    case "Test":
        System.Console.WriteLine("this is a test");
        break;
    default:
        System.Console.WriteLine("not a test");
        break;
}

string today = "Saturday";

switch (today)
{
    case "monday":
    case "tuesday":
    case "wednesday":
    case "thursday":
    case "friday":
        System.Console.WriteLine("office is open");
        break;
    case "saturday":
    case "sunday":
        System.Console.WriteLine("office is closed");
        break;
    default:
        System.Console.WriteLine("please input a valid day.");
        break;
}

//! Switch Expression:
order = intInput switch
{
    1 => "burger and fries",
    2 => "Chicken Sandwhich",
    3 or 4 => "burrito",
        => "cup of water"
};
System.Console.WriteLine(order);

//! Ternary Expression

/*
-shorthand for if/else conditional
-meant to assign a value to a variable.
*/
int userAge = 71;
bool isAdult = (userAge > 17) ? true : false;

string ticketType = (userAge >=17) ? true : false;

string ticketType = (userAge >=18) ? "adult" : "child";
System.Console.WriteLine(ticketType);

//* compound ternary
string otherTicketType = userAge >= 18 ? userAge > 65? "senior" : "adult": "child";
System.Console.WriteLine(otherTicketType);