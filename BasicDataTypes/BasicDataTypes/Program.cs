// Working with System Data Types and Corresponding C# Keywords

//Big Interger when needed to define a massive numerical value
using System.Numerics;

Console.WriteLine("***** Fun with Basic Data Types *****");
LocalVarDeclarations();
DefaultDeclarations();
NewingDataTypes();
NewingDataTypesWith9();
ObjectFunctionality();
DataTypeFunctionality();
CharFunctionality();
ParseFromStrings();
ParseFromStringWithTryParse();
UseDatesAndTimes();
UseBigInteger();
DigitSeparators();
BinaryLiterals();

Console.ReadLine();

// Understanding Variable Declaration and Initialization
static void LocalVarDeclarations()
{
    Console.WriteLine("=> Data Declarations: ");
    //Local variables are declared as so:
    //dataType varName;

    // Local variables are declared and initialized as follows:
    // dataType varName = initialValue;
    int myInt = 0;

    // You can also declare and assign on two lines.
    string myString;
    myString = "This is my character data";

    // Declare 3 bools on a single line
    bool b1 = true, b2 = false, b3 = b1;

    // Use System.Boolean data type to declare a bool.
    System.Boolean b4 = false;

    Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);

    Console.WriteLine();
}

// The Default Literal
static void DefaultDeclarations()
{
    Console.WriteLine("=> Default Declarations: ");
    int myInt = default;
    Console.WriteLine(myInt);
}

//Using Intrinsic Data Types and the new Operator (Updated 9.0)
static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables: ");
    bool b = new bool(); //set to false
    int i = new int(); //set to 0;
    double d = new double(); //set to 0.
    DateTime dt = new DateTime(); //set to 1/1/0001 12:00:00 AM
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}

//The updated version of NewingDataTypes C# 9.0
static void NewingDataTypesWith9()
{
    Console.WriteLine("=> Using new to create variables C# 9.0:");
    bool b = new();              // Set to false.
    int i = new();               // Set to 0.
    double d = new();            // Set to 0.
    DateTime dt = new();         // Set to 1/1/0001 12:00:00 AM
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}

// Understanding the Data Type Class Hierarchy
static void ObjectFunctionality()
{
    Console.WriteLine("=> System.Object Functionality:");
    // A C# int is really a shorthand for System.Int32,
    // which inherits the following members from System.Object.
    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
    Console.WriteLine("12.ToString() = {0}", 12.ToString());
    Console.WriteLine("12.GetType() = {0}", 12.GetType());
    Console.WriteLine();
}

// Understanding the Members of Numerical Data Types
static void DataTypeFunctionality()
{
    Console.WriteLine("=> Data Type Functionality");

    Console.WriteLine("Max of int: {0}", int.MaxValue);
    Console.WriteLine("Min of int: {0}", int.MinValue);
    Console.WriteLine("Max of double: {0}", double.MaxValue);
    Console.WriteLine("Min of double: {0}", double.MinValue);
    Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
    Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
    Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
    Console.WriteLine();
}

//Understanding the Members of System.Boolean
Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
Console.WriteLine("bool.TrueString: {0}", Boolean.TrueString);

//Understanding the Members of System.Char
static void CharFunctionality()
{
    Console.WriteLine("=> char type Functionality:");
    char myChar = 'a';
    Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
    Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
    Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
    Console.WriteLine();
}

//Parsing Values from String Data
static void ParseFromStrings()
{
    Console.WriteLine("=> Data Type parsing: ");
    bool b = bool.Parse("True");
    Console.WriteLine("value of b: {0}", b);
    double d = double.Parse("99.884");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("The value of i: {0}", i);
    char c = Char.Parse("w");
    Console.WriteLine("The value of c: {0}", c);
    Console.WriteLine();
}

//Using TryParse to Parse Values from String Data
static void ParseFromStringWithTryParse()
{
    Console.WriteLine("=> Data type parsing with TryParse");
    if (bool.TryParse("True", out bool b))
    {
        Console.WriteLine("Value of b: {0}", b);
    }
    else
    {
        Console.WriteLine("Default value of b: {0}", b);
    }
    string value = "Hello";
    if (double.TryParse(value, out double d))
    {
        Console.WriteLine("Value of d: {0}", d);
    }
    else
    {
        Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value, d);
    }
    Console.WriteLine();
}

//Using System.DateTime and System.TimeSpan
static void UseDatesAndTimes()
{
    Console.WriteLine("=> Dates and Times:");

    //This constructor takes (year, month, day.
    DateTime dt = new DateTime(2015, 10, 17);

    //What day of the month is this?
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

    //Month is now December.
    dt = dt.AddMonths(2);
    Console.WriteLine("DayLight savings: {0}", dt.IsDaylightSavingTime());

    //This constructor takes (hours, minutes, seconds).
    TimeSpan ts = new TimeSpan(4, 30, 0);
    Console.WriteLine(ts);

    //Substract 15 minutes from the current TimeSpan and print the result.
    Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

    //DateOnly and TimeOnly
    DateOnly d = new DateOnly(2021, 07, 21);
    Console.WriteLine(d);

    TimeOnly t = new TimeOnly(13, 30, 0, 0);
    Console.WriteLine(t);
}

//Working with the System.Numerics Namespace
static void UseBigInteger()
{
    Console.WriteLine("=> Use BigInteger:");
    BigInteger biggy = BigInteger.Parse("999999999999999999999999999999999999999999999999999");
    Console.WriteLine("Value of biggy is {0}", biggy);
    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
    Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
    BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("888888888888888888888888888888888888888"));
    Console.WriteLine("Value of reallyBig is {0}", reallyBig);

    //using mathematical operators *, +, -
    BigInteger reallyBig2 = biggy * reallyBig;
    BigInteger reallyBig3 = biggy + reallyBig;
    BigInteger reallyBig4 = biggy - reallyBig;

    Console.WriteLine(reallyBig2);
    Console.WriteLine(reallyBig3);
    Console.WriteLine(reallyBig4);
}

//Using Digit Separators
static void DigitSeparators()
{
    Console.WriteLine("=> Use Digit Separators:");
    Console.Write("Integer:");
    Console.WriteLine(123_456);
    Console.Write("Long:");
    Console.WriteLine(123_456_789L);
    Console.Write("Float:");
    Console.WriteLine(123_456.1234F);
    Console.Write("Double:");
    Console.WriteLine(123_456.12);
    Console.Write("Decimal:");
    Console.WriteLine(123_456.12M);
    Console.Write("Hex:");
    Console.WriteLine(0x_00_00_FF);
}

//Using Binary Literals
static void BinaryLiterals()
{
    Console.WriteLine("=> Use Binary Literals");
    Console.WriteLine("Sixteen: {0}",0b_0001_0000);
    Console.WriteLine("Thiry Two: {0}", 0b_0010_0000);
    Console.WriteLine("Sixty Four: {0}", 0b_0100_0000);
}