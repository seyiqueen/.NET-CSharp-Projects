// Narrowing and Widening Data Type Conversions
Console.WriteLine("***** Fun with type conversions *****");
//Widening is the term used to define an implicit upward cast and does not result in a loss of data
//Add two shorts and print the result.
short numb1 = 9, numb2 = 10;
Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));
Console.ReadLine();

static int Add(int x, int y)
{
    return x + y;
}

//Narrowing is the logical opposite of widening, in that a larger value is stored within a smaller data type variable.
// All narrowing conversions result in a compiler error

// Explicit cast using the c# casting operator, ().


Console.WriteLine("***** Explicit Casting *****");
short num1 = 30000, num2 = 30000; //short holds a maximum value between of 32,767

//Explicitly cast the int into a short (and allow loss of data).
short answer = (short)Add(num1, num2);
Console.WriteLine("{0} + {1} = {2}", num1, num2, answer); //this resulted to an incorrect addition (-5536) when the code compiles
NarrowingAttempt();
Console.ReadLine();


static void NarrowingAttempt()
{
    byte myByte = 0;
    int myInt = 200;

    //Explicitly cast the int into a byte (no loss of data).
    myByte = (byte)myInt;
    Console.WriteLine( "Value of myByte: {0}", myByte);

}


static void ProcessBytes()
{
    byte b1 = 100; //Byte holds a value between (0 and 255, total of 256)
    byte b2 = 250;
    byte sum = (byte)Add(b1, b2);

    //sum should hold the value of 250, However, we find the value 94! which is the overflow value from the byte (350-256=94)
    Console.WriteLine("Sum = {0}", sum);
}

ProcessBytes();

//Using checked Keyword
//Used to ensure that data loss does not escape undetected and to handle overflow and underflow conditions that may result when adding, multiplying, substracting,or dividing two numerical data types
static void ProcessBytes2()
{
    byte byte1 = 100;
    byte byte2 = 250;

    //This time, the compiler will add CIL code to throw an exception if overflow/undrflow takes place
    try
    {
        byte sum = checked((byte)Add(byte1, byte2));
        Console.WriteLine("sum = {0}", sum);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

ProcessBytes2();

//To force overflow checking to occur over a block of code statements
//Used to ensure that data loss does not escape undetected and to handle overflow and underflow conditions that may result when adding, multiplying, substracting,or dividing two numerical data types
static void ProcessBytes3()
{
    byte byte1 = 100;
    byte byte2 = 250;

    //This time, the compiler will add CIL code to throw an exception if overflow/undrflow takes place
    try
    {
        checked
        {
            byte sum = (byte)Add(byte1, byte2);
            Console.WriteLine("sum = {0}", sum);
        }
    }
       
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
ProcessBytes3();

//Using the unchecked Keyword
//Used to disable the throwing of an exception on a case-by-case basis when data loss is acceptable in a block of code if the project-wide overflow checking setting is enabled.
//Assuming /checked is enabled, this block will not trigger a runtime exception

static void ProcessBytes4()
{
    byte byte1 = 100;
    byte byte2 = 250;

    //This time, the compiler will add CIL code to throw an exception if overflow/undrflow takes place
    try
    {
        unchecked
        {
            byte sum = (byte)Add(byte1, byte2);
            Console.WriteLine("sum = {0}", sum);
        }
    }

    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
ProcessBytes4();

Console.ReadLine();