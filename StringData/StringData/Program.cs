//Working with String Data

//Performing Basic String Manipulation

using System.Runtime.CompilerServices;

// StringBuilder lives here
using System.Text;

BasicStringFunctionality();
StringConcatenation();
EscapeChars();
StringInterpolation();
StringInterpolationWithDefaultInterpolatedStringHandler();
StringEquality();
StringEqualitySpecifyingCompareRules();
StringAreImmutable();
StringAreImmutable2();
FunWithStringBuilder();

static void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic String functionality");
    string firstName = "Freddy";
    Console.WriteLine("Value of firstName: {0}", firstName);
    Console.WriteLine("firstName has {0} characters.", firstName.Length);
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
    Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
    Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
    Console.WriteLine();
}

//Performing String Concatenation
static void StringConcatenation()
{
    Console.WriteLine("=> String concatenation");
    string s1 = "Programming the ";
    string s2 = "PsychoDrill (PTP)";
    string s3 = s1 + s2;
    Console.WriteLine(s3);
    Console.WriteLine();
}

//Using Escape characters
static void EscapeChars()
{
    Console.WriteLine("=> Escape charcters:");
    string strWithTabs = "Model\tColor\tSpeed\tPet Name";
    Console.WriteLine(strWithTabs);

    Console.WriteLine("Everyone loves \"Helloworld\" ");
    Console.WriteLine("C:\\MyApp\\bin\\Debug ");

    // Adds a total of 4 blank lines (3 escaped, 1 from WriteLine).
    Console.WriteLine("All finished.\n\n\n");
    Console.WriteLine();

    //omitted for brevity
    //Adds a 4 more blank lines.
    Console.WriteLine("All finished for real this time.{0}{0}{0}", Environment.NewLine);
}

//Performing String Interpolation
static void StringInterpolation()
{
    Console.WriteLine("=> String interpolation:\a");

    // Some local variables we will plug into our larger string
    int age = 4;
    string name = "Soren";

    //Using curly-bracket syntax.
    string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
    Console.WriteLine(greeting);

    //Using string interpolation
    String greeting2 = $"Hello {name} you are {age} years old.";
    Console.WriteLine(greeting2);

    //Using curly-bracket syntax using the dot operation on the variables.
    string greeting3 = string.Format("Hello {0} you are {1} years old.", name.ToUpper(), age);
    Console.WriteLine(greeting3);

    //Using string interpolation using the dot operation on the variables
    String greeting4 = $"Hello {name.ToUpper()} you are {age} years old.";
    Console.WriteLine(greeting4);

    //using curly-bracket syntax using the tab \t escape character
    string greeting5 = string.Format("\tHello {0} you are {1} years old.", name.ToUpper(), age);
    Console.WriteLine(greeting5);

    //Using string interpolation using the tab \t escape character
    String greeting6 = $"\tHello {name.ToUpper()} you are {age} years old.";
    Console.WriteLine(greeting6);
}

//Performance Improvement using interpolation, DefaultInterpolatedStringHandler and its methods
static void StringInterpolationWithDefaultInterpolatedStringHandler()
{
    Console.WriteLine("=> String interpolation under the covers");
    int age = 4;
    string name = "Soren";

    var builder = new DefaultInterpolatedStringHandler(3, 2);
    builder.AppendLiteral("\tHello ");
    builder.AppendFormatted(name);
    builder.AppendLiteral(" you are ");
    builder.AppendFormatted(age);
    builder.AppendLiteral(" years old.");
    var greeting7 = builder.ToStringAndClear();
    Console.WriteLine(greeting7);     
}

//Defining Verbatim Strings
//The following string is printed verbatim, thus all escape characters are displayed.
Console.WriteLine(@"C:\MyApp\bin\Debug");

//Whitespace is preserved with verbatim strings
string myLongString = @"This is a very
    very
        very
              long string";
Console.WriteLine(myLongString);

//Insert double qoute by doubling the " token with verbatim strings
Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets"" ");

//Verbatim strings can also be Interpolated strings by spacifying both interpolator operation ($) and verbatim operator ($)
string interp = "interpolation";
string myLongString2 = $@"This is a very
    very
        long string with {interp}";
Console.WriteLine(myLongString2);

//Working with Strings and Equality
static void StringEquality()
{
    Console.WriteLine("=> String equality");
    string s1 = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();

    //Test these strings for equality.
    Console.WriteLine("s1 == s2: {0}", s1 == s2);
    Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
    Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
    Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
    Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();
}

//String Comparison Enumeration
static void StringEqualitySpecifyingCompareRules()
{
    Console.WriteLine("=>String equality (Case Sensitive:)");
    string s3 = "Hello";
    string s4 = "HELLO";
    Console.WriteLine("s3 = {0}", s3);
    Console.WriteLine("s4 = {0}", s4);
    Console.WriteLine();

    // Check the results of changing the default compare rules.
    Console.WriteLine("Default rules: s3 = {0}, s4={1}, s3.Equls(s4): {2}", s3, s4, s3.Equals(s4));

    Console.WriteLine("Ignore case: s3.Equals(s4, StringComparison.OrdinalIgnoreCase):{0}", s3.Equals(s4,StringComparison.OrdinalIgnoreCase));

    Console.WriteLine("Ignore case, InvariantCulture: s3.Equals(s4, StringComparison.InvariantCultureIgnoreCase):{0}", s3.Equals(s4, StringComparison.InvariantCultureIgnoreCase));

    Console.WriteLine();

    Console.WriteLine("Default rules: s3={0}, s4={1}, s3.IndexOf(\"E\"):{2}", s3, s4, s3.IndexOf("E") );

    Console.WriteLine("Ignore case: s3.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", s3.IndexOf("E", StringComparison.OrdinalIgnoreCase));

    Console.WriteLine("Ignore case, Invariant Culture: s3.IndexOf(\"E\", StringComparison.InavriantCultureIgnoreCase): {0}", s3.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));

    Console.WriteLine();
}


// String are Immutable
static void StringAreImmutable()
{
    Console.WriteLine("=> Immutable Strings:\a");
    //Set initial String state
    string string1 = "This is my string";
    Console.WriteLine("string1 ={0}", string1);

    //Uppercase string1
    string upperString = string1.ToUpper();
    Console.WriteLine("upperString = {0}", upperString);

    //Nope string1 is in the same format!
    Console.WriteLine("string1 = {0}", string1);
}

// String are Immutable: Using the C# Assignment operator
static void StringAreImmutable2()
{
    Console.WriteLine("=> Immutable Strings 2:\a");
    string string2 = "My other string";
    string2 = "New string value";
    Console.WriteLine(string2);
}

// Using the System.Text.StringBuilder Type
static void FunWithStringBuilder()
{
    Console.WriteLine("=> Using the StringBuilder:");
    StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
    sb.Append("\n");
    sb.AppendLine("Half Life");
    sb.AppendLine("Morrowwind");
    sb.AppendLine("Deus Ex" + "2");
    sb.AppendLine("System Shock");
    Console.WriteLine(sb.ToString());
    sb.Replace("2", " Invisible War");
    Console.WriteLine(sb.ToString());
    Console.WriteLine("sb has {0} chars.", sb.Length);
    Console.WriteLine();
}

//Make a StringBuilder with an initial size of 256
StringBuilder sb2 = new StringBuilder("**** Fantastic Games ****", 256);
Console.WriteLine(sb2);

Console.ReadLine();