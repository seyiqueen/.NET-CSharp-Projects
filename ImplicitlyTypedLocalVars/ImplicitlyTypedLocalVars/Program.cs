Console.WriteLine("***** Fun with implicit Typing *****");

DeclareImplicitVars();
Console.WriteLine();
DeclareImplicitNumerics();

Console.ReadLine();

static void DeclareImplicitVars()
{
    // Implicitly typed local variables are declares as follows:
    // var variableName = initialValue;
    var myInt = 0;
    var myBool = true;
    var myString = "Time, marches on...";

    // Print out the underlying type.
    Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
    Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
    Console.WriteLine("myString is a: {0}", myString.GetType().Name);
}

static void DeclareImplicitNumerics()
{
    // Implicitly typed numeric variables
    var myUInt = 0u;
    var myInt1 = 0;
    var myLong = 0L;
    var myDouble = 0.5;
    var myFloat = 0.5F;
    var myDecimal = 0.5M;

    //Print out the underlying type
    Console.WriteLine("myUInt is a: {0}", myUInt.GetType().Name);
    Console.WriteLine("myInt is a: {0}", myInt1.GetType().Name);
    Console.WriteLine("myLong is a: {0}", myLong.GetType().Name);
    Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
    Console.WriteLine("myFloat is a: {0}", myFloat.GetType().Name);
    Console.WriteLine("myDecimal is a: {0}", myDecimal.GetType().Name);
}

// Understanding Restrictions on Implicitly Typed Variables
// The Permissibles when using implicitly Local Varaibles, var

//OK, null can only be passed if SportsCar is a reference type!
// var myCar = new SportsCar();
// myCar = null;

//Also OK!
var myInt2 = 0;
var anotherInt = myInt2;
Console.WriteLine(anotherInt);

string myString2 = "Wake up!";
var myData = myString2;
Console.WriteLine(myData);

//Also Ok, when return type is the same underlying type as the var-defined data point.

static int GetAnInt()
{
    var retVal = 0;
    return retVal;
    
}
Console.WriteLine(GetAnInt());

Console.ReadLine();
// Understanding the Usefulness of Implicitly Typed Local Variables
// Implicit typing is extremely helpful when using LINQ technology because we do not need to explicitly define the type a query will return which in some cases would be literally impossible to do
LinqQueryOverInts();

static void LinqQueryOverInts()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

    // LINQ query!
    var subset = from i in numbers where i < 10 select i;

    Console.WriteLine("Values in subset: ");
    foreach(var i in subset)
    {
        Console.WriteLine("{0}", i);
    }
    Console.WriteLine();

    // what type is subset?
    Console.WriteLine("subset is a: {0}", subset.GetType().Name);
    Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
}
Console.ReadLine();