// Working with C# Iteration Constructs
// Using the for Loop
using System;
using System.Diagnostics.Metrics;

ForLoopExample();
ForEachLoopExample();
LinqQueryOverInts();
WhileLoopExample();
DoWhileLoopExample();
WhileLoopExample2();
DoWhileLoopExample2();

// A basic for loop.
static void ForLoopExample()
{
    // Note! "!" is only visible within the scope of the for loop
    for(int i = 0; i < 4; i++)
    {
        Console.WriteLine("Number is: {0} ", i);
    }
    // "i" is not visible here
}

// Using the foreach Loop
// Iterate array items using foreach
static void ForEachLoopExample()
{
    string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
    foreach (string c in carTypes)
    {
        Console.WriteLine(c);
    }

    int[] myInts = { 10, 20, 30, 40 };
    foreach (int i in myInts)
    {
        Console.WriteLine(i);
    }
}

// Using Implicit Typing within foreach Constructs
static void LinqQueryOverInts()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

    //LINQ query!
    var subset = from i in numbers where i < 10 select i;
    Console.WriteLine("Values in subset: ");

    foreach (var i in subset)
    {
        Console.WriteLine("{0} ", i);
    }
}

// Using the while and do/while Looping Constructs
static void WhileLoopExample()
{
    string userIsDone = "";

    // Test on a lower-class copy of the string.

    while(userIsDone.ToLower() != "yes")
    {
        Console.WriteLine("In while loop");
        Console.WriteLine("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
      
    }
  
}

static void DoWhileLoopExample()
{
    string userIsDone1 = "";

    do
    {
        Console.WriteLine("In do/while loop");
        Console.WriteLine("Are you done? [yes] [no]: ");
        userIsDone1 = Console.ReadLine();
       
    }
    while(userIsDone1.ToLower() != "yes");

   
}

Console.ReadLine();

static void WhileLoopExample2()
{
    int counter = 0;

    while (counter < 0)
    {
        Console.WriteLine("in while loop example 2");
        Console.WriteLine(counter);
        counter = counter + 1;
    }

}

static void DoWhileLoopExample2()
{
    int counter1 = 0;

    do
    {
        Console.WriteLine("in do/while loop example 2");
        Console.WriteLine(counter1);
        counter1 = counter1 + 1;
    }
    while (counter1 < 0);


}

for (int i = 0;i < 4; i++)
{
    Console.WriteLine("Number is: {0} ", i);
    Console.WriteLine("Number plus 1 is {0} ", i+1);
}


//Working with Decision Constructs and the Relational/Equality Operators
IfElseExample();
IfElsePatternMatching();
IfElsePatternMatchingUpdatedInCSharp9();
ExecuteIfElseUsingConditionalOperator();
ConditionalRefExample();
LogicalOperatorExample();

//The if/else tatement in C# operates only on Boolean expressions, not ad hov values such as -1 or 0
static void IfElseExample()
{
    string stringData = "My textual data";
    if (stringData.Length > 0)
    {
        Console.WriteLine("string is greater than 0 characters");
    }
    else
    {
        Console.WriteLine("string is not greater than 0 characters");
    }
}

// Using if/else with Pattern Matching (New 7.0)
static void IfElsePatternMatching()
{
    Console.WriteLine("=== If Else Pattern Matching ===");
    object testItem1 = 123;
    object testItem2 = "Hello";
    if (testItem1 is string myStringValue1)
    {
        Console.WriteLine($"{myStringValue1} is a string");
    }
    if (testItem1 is int myValue1)
    {
        Console.WriteLine($"{myValue1} is an int");
    }
    if (testItem2 is string myStringValue2)
    {
        Console.WriteLine($"{myStringValue2} is a string");
    }
    if (testItem2 is int myValue2)
    {
        Console.WriteLine($"{myValue2} is an int");

    }
    Console.WriteLine();
}

// Using if/else with Pattern Matching Updated (New 9.0)
static void IfElsePatternMatchingUpdatedInCSharp9()
{
    Console.WriteLine("====== C# 9 If Else Pattern Matching Improvements ======");
    object testitem1 = 123;
    Type t = typeof(string);
    char c = 'f';

    //Type patterns
    if (t is Type)
    {
        Console.WriteLine($"{t} is a Type");
    }

    //Relational, Conjuctive, and Disjunctive patterns
    if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine($"{c} is a character");
    }

    // Parenthesized patterns
    if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
    {
        Console.WriteLine($"{c} is a character or separator");
    }

    // Negative patterns
    if (testitem1 is not string)
    {
        Console.WriteLine($"{testitem1} is not a string");
    }

    if (testitem1 is not null)
    {
        Console.WriteLine($"{testitem1} is not null");
    }
    Console.WriteLine();
}

// Using the Conditional Operator (Updated 7.2, 9.0)
static void ExecuteIfElseUsingConditionalOperator()
{
    string stringData = "My textual data";
    Console.WriteLine(stringData.Length > 0 ? "string is greater than 0 characters" : "string is not greater than 0 characters" );
    Console.WriteLine();
}

//Using conditional operator to return a reference to the result of the condition
static void ConditionalRefExample()
{
    var smallArray = new int[] { 1, 2, 3, 4, 5 };
    var largeArray = new int[] { 10, 20, 30, 40, 50 };

    int index = 7;
    ref int refValue = ref ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]);
    refValue = 0;
    index = 2;
    ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]) = 100;

    Console.WriteLine(string.Join(" ", smallArray));
    Console.WriteLine(string.Join(" ",largeArray));
}

// Using Logical Operators
static void LogicalOperatorExample()
{
    int age = 30;
    string name = "Femi";
    bool myBool = false;
    Console.WriteLine(age == 30 && name == "Fred" ? "Successful" : "Wrong information");
    Console.WriteLine(age == 30 || name == "Fred" ? "Successful" : "Wrong information");
    Console.WriteLine(myBool == false ? "Successful" : "Wrong information");
}

// Working with Selection Construct
SwitchExample();
SwitchOnStringExample();
SwitchOnEnumExample();
SwitchWithGoto();
ExecutePattenMatchingSwitch();
ExecutePatternMatchingSwitchWithWhen();

// Using the switch Statement

// Switch on a numerical value
static void SwitchExample()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.WriteLine("Please pick your language preference: ");

    string langChoice = Console.ReadLine();
    int n = int.Parse(langChoice);

    switch (n)
    {
        case 1:
            Console.WriteLine("Good choice, C# is a fine language");
            break;
        case 2:
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;

    }
}

// Switch on a string data
static void SwitchOnStringExample()
{
    Console.WriteLine("C# or VB");
    Console.WriteLine("Please pick your language preference: ");

    string langChoice = Console.ReadLine();

    switch (langChoice.ToUpper())
    {
        case "C#":
            Console.WriteLine("Good choice, C# is a fine language");
            break;
        case "VB":
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;

    }
}

// Switch on an enumeration data type
static void SwitchOnEnumExample()
{
    Console.WriteLine("Enter your favorite day of the week: ");
    DayOfWeek favDay;
    try
    {
        favDay = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Bad input!");
        return;
    }
    switch (favDay)
    {
        case DayOfWeek.Sunday:
            Console.WriteLine("Football");
            break;
        case DayOfWeek.Monday:
            Console.WriteLine("Another day, another dollar");
            break;
        case DayOfWeek.Tuesday:
            Console.WriteLine("At least it is not monday");
            break;
        case DayOfWeek.Wednesday:
            Console.WriteLine("A fine day.");
            break;
        case DayOfWeek.Thursday:
            Console.WriteLine("Almost Friday...");
            break;
        case DayOfWeek.Friday:
            Console.WriteLine("Yes, Friday rules!");
            break;
        case DayOfWeek.Saturday:
            Console.WriteLine("Great day indeed");
            break;
    }
    Console.WriteLine();
}

//Using goto statement in a switch block
static void SwitchWithGoto()
{
    var foo = 5;
    switch (foo)
    {
        case 1:
            //do something
            goto case 2;
        case 2:
            //do something else
            break;
        case 3:
            //yet another action
            goto default;
        default:
            //default action
            break;
    }
}

//performing switch Statement Pattern Matching (New 7.0, Updated 9.0)
static void ExecutePattenMatchingSwitch()
{
    Console.WriteLine("1 [integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
    Console.WriteLine("Please choose an option: ");
    string userChoice = Console.ReadLine();
    object choice = userChoice;

    //This is a standard constant pattern switch statement to set up the example
    switch (userChoice)
    {
        case "1":
            choice = 5;
            break;
        case "2":
            choice = "Hi";
            break;
        case "3":
            choice = 2.5M;
            break;
    }

    //This is new the pattern matching switch statement by checking the type
    switch (choice)
    {
        case int i:
            Console.WriteLine("Your choice is an integer {0}.", i);
            break;
        case string s:
            Console.WriteLine("Your choice is a string {0}", s);
            break;
        case decimal d:
            Console.WriteLine("Your choice is a decimal {0}", d);
            break;
        default:
            Console.WriteLine("Your choice is something else");
            break;
    }
    Console.WriteLine();
}

//This is new the pattern matching switch statement with When clauses to evaluate conditions on the variable
static void ExecutePatternMatchingSwitchWithWhen()
{
    Console.WriteLine("C# or VB");
    Console.WriteLine("Please pick your language preference: Press 1 or C# for language C# AND Press 2 or VB for Language VB ");

    object langChoice = Console.ReadLine();
    var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

    switch (choice)
    {
        case int i when i == 2:
        case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        case int i when i == 1:
        case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):; ; ;
            Console.WriteLine("Good Choice, C# is a fine language.");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }
    Console.WriteLine();
}

Console.WriteLine("Enter the Color");
string colorBand = Console.ReadLine();
Console.WriteLine(FromRainbowClassic(colorBand));

//Using switch Expressions (New 8.0)
static string FromRainbowClassic(string colorBand)
{

    switch (colorBand.ToLower())
    {
        case "red":
            return "#FF0000";
        case "orange":
            return "#FF7F00";
        case "yellow":
            return "#FFFF00";
        case "green":
            return "#00FF00";
        case "blue":
            return "#0000FF";
        case "indigo":
            return "#4B0082";
        case "violet":
            return "#9400D3";
        default:
            return "#FFFFFF";
    }
}

Console.WriteLine("Enter the other Color");
string colorBand1 = Console.ReadLine();
Console.WriteLine(FromRainbow(colorBand1));

//Using switch Expressions, a concised version (New 8.0)
static string FromRainbow(string colorBand1)
{

    return colorBand1.ToLower() switch
    {
        "red" => "#FF0000",
        "orange" => "#FF7F00",
        "yellow" => "#FFFF00",
        "green" => "#00FF00",
        "blue" => "#0000FF",
        "indigo" => "#4B0082",
        "violet" => "#9400D3",
        _=> "#FFFFFF",
    };
}

Console.WriteLine("Enter your first option, rock, paper, or scissors");
string first = Console.ReadLine();
Console.WriteLine("Enter your second option, rock, paper, or scissors");
string second = Console.ReadLine();
Console.WriteLine(RockPaperScissors(first, second));
//Switch expression with Tuples
static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins.",
        ("rock", "scissors") => "Rock wins.",
        ("paper", "rock") => "Paper wins.",
        ("paper", "scissors") => "Scissors wins.",
        ("scissors", "rock") => "Rock wins.",
        ("scissors", "paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}
Console.ReadLine();