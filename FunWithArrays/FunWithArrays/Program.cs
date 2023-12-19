Console.WriteLine("***** Fun with Arrays *****");
SimpleArrays();
ArrayInitialization();
DeclareImplicitArrays();
ArrayOfObjects();
Console.ReadLine();

//Understanding C# Arrays
static void SimpleArrays()
{
    Console.WriteLine("Simple Array Creation.");
    // Create and fill an array of 3 integers
    int[] myInts = new int[3];
    myInts[0] = 100;
    myInts[1] = 200;
    myInts[2] = 300;

    // Now print each value
    foreach(int i in myInts)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();

    // Create a 100 item string array, indexed 0 - 99
    string[] bookOnDotNet = new string[100];
    Console.WriteLine();
}

//Looking at the C# Array Initialization Syntax
static void ArrayInitialization()
{
    Console.WriteLine("=> Array Initialization. ");

    // Array initialization using the new keyword
    string[] stringArray = new string[] { "one", "two", "three" };
    Console.WriteLine("stringArray has {0} elements", stringArray.Length);

    // Array initialization syntax without the new keyword.
    bool[] boolArray = { false, false, true };
    Console.WriteLine("boolArray has {0} elements", boolArray.Length);

    // Array with the new keyword and size.
    int[] intArray = new int[4] { 20, 22, 23, 0 };
    Console.WriteLine("intArray has {0} elements", intArray.Length);
}

// Understanding Implitcitly Typed Local Arrays
// The new keyword must be used when using the var keyword AND THE ARRAY ITEMS IN THE ARRAY INITIALIZATION LIST MUST BE OF THE SAME UNDELYING TYPE

static void DeclareImplicitArrays()
{
    Console.WriteLine("=> Implicit Array Initialization.");

    // a is really int[]
    var a = new[] { 1, 10, 100, 1000 };
    Console.WriteLine("a is a: {0}", a.ToString());

    // b is really double[]
    var b = new[] { 1, 1.5, 2, 2.5 };
    Console.WriteLine("b is a: {0}", b.ToString());

    // c is really string[]
    var c = new[] { "hello", "null", "world" };
    Console.WriteLine("c is a: {0}", c.ToString());
    Console.WriteLine();
}

// Defining an Array of Objects
// The Array of Objects can be anything at all. They do not have to be of the same type

static void ArrayOfObjects()
{
    Console.WriteLine("=> Array of Objects.");

    // An array of objects can be anything at all.
    object[] myObjects = new object[4];
    myObjects[0] = 10;
    myObjects[1] = false;
    myObjects[2] = new DateTime(1969, 3, 24);
    myObjects[3] = "Form & Void";

    foreach(object obj in myObjects)
    {
        // Print the type and value for each item in an array.
        Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
    }
    Console.WriteLine();
}

// Working with Multidimensional Arrays
RectangularMultidimensionalArray();
JaggedMultimensionalArray();
Console.ReadLine();

//Rectangular Multimensional Array
static void RectangularMultidimensionalArray()
{
    Console.WriteLine("=> Rectangular multidimensional array.");
    // A rectangular MD Array, Each row is of the same length
    int[,] myMatrix;
    myMatrix = new int[3, 4];

    // populate (3 * 4) array
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            myMatrix[i, j] = i * j;
        }
    }

    //print (3 * 4) Array
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            Console.Write(myMatrix[i,j] + "\t");
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Jagged Multimensional Array
static void JaggedMultimensionalArray()
{
    Console.WriteLine("=> Jagged multidimensional array.");
    // A jagged MD array (i.e., an array of arrays).
    // Here we have an array of 5 different arrays
    int[][] myJagArray = new int[5][];

    // Create the jagged array.
    for (int i = 0; i < myJagArray.Length; i++)
    {
        myJagArray[i] = new int[i + 7];
    }

    // Print each row (remember, each element is defaulted to zero!)
    for(int i = 0; i < 5; i++)
    {
        for(int j = 0; j < myJagArray[i].Length; j++)
        {
            Console.Write(myJagArray[i][j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Using Arrays As Arguments or Return Values
static void PrintArray(int[] myInts)
{
    for(int i = 0; i < myInts.Length; i++)
    {
        Console.WriteLine("Item {0} is {1}", i, myInts[i]);
    }
}

static string[] GetStringArray()
{
    string[] theStrings = { "Hello", "from", "GetStringArray" };
    return theStrings;
}

// Invoking the above methods
PassAndReceiveArrays();
Console.ReadLine();
static void PassAndReceiveArrays()
{
    Console.WriteLine("=> Arrays as params and return values");
    // Pass array as parameter.
    int[] ages = { 20, 22, 23, 0 };
    PrintArray(ages);

    //Get Array as return value.
    string[] strs = GetStringArray();
    foreach(string s in strs)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine();
}

// Using the System.Array Base Class
SystemArrayFunctionality();
Console.ReadLine();
static void SystemArrayFunctionality()
{
    Console.WriteLine("=> Working with the System.Array.");
    // Initialize items at startup
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

    // Print out names in declared order.
    Console.WriteLine("-> Here is the array:");
    for (int i = 0; i < gothicBands.Length; i++)
    {
        // Print a name
        Console.Write(gothicBands[i] + ", ");

    }
    Console.WriteLine("\n");

    // Reverse them...
    Array.Reverse(gothicBands);
    Console.WriteLine("-> The reversed array");

    // ... and print them.
    for(int i = 0; i < gothicBands.Length; i++)
    {
        // Print a name
        Console.Write(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");

    //Clear out all but the first member.
    Console.WriteLine("-> Cleared out all but one...");
    Array.Clear(gothicBands, 1, 2);

    for(int i = 0; i < gothicBands.Length; i++)
    {
        // Print a name
        Console.Write(gothicBands[i] + ", ");
    }
    Console.WriteLine();
}

// Using Indices and Ranges
WorkingWithArrayUsingIndicesAndRanges();
Console.ReadLine();
static void WorkingWithArrayUsingIndicesAndRanges()
{
    Console.WriteLine("=> Working with Indices and Ranges.");
    // Initialize items at startup
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

    // Using the System.Index represents an index into sequence
    Console.WriteLine("-> Here is the array:");
    for (int i = 0; i < gothicBands.Length; i++)
    {
        Index idx = i;
        // Print a name
        Console.Write(gothicBands[idx] + ", ");

    }
    Console.WriteLine("\n");

    // Prints the Array in reverse using the Index operator
    Console.WriteLine("-> The reversed array");
    for (int i = 1; i <= gothicBands.Length; i++)
    {
        Index idx = ^i;
        // Print a name
        Console.Write(gothicBands[idx] + ", ");
    }
    Console.WriteLine("\n");

    //Using the System.Range Represents a Subrange of Indices.
    //Using the Range Operator 
    Console.WriteLine("-> Using the Range Operator");
    //Pull out the first two members of the Array. The start of the range is inclusive, and the end of the range is exclusive
    foreach (var itm in gothicBands[0..2])
    {
        // Print a name
        Console.Write(itm + ", ");
    }
    Console.WriteLine("\n");

    // Using the Range data type
    Console.WriteLine("-> Using the Range data type");
    Range r = 0..2;
    foreach (var itm in gothicBands[r])
    {
        // Print a name
        Console.Write(itm + ", ");
    }
    Console.WriteLine("\n");

    // Defining the range using Integers or Index variables
    Console.WriteLine("-> Using Integers or Index variables");
    Index idx1 = 0;
    Index idx2 = 2;
    Range r1 = idx1..idx2; //the end of range is exclusive
    foreach (var itm in gothicBands[r])
    {
        // Print a name
        Console.Write(itm + ", ");
    }
    Console.WriteLine("\n");

    //The ElementAt() extension method in the System.Linq namespace which retrieves the element from the array at the specified location
    Console.WriteLine("Usint the ElementAt() method");
    var band = gothicBands.ElementAt(^2); //gets the second-to-last band from the list
    Console.WriteLine(band);
}