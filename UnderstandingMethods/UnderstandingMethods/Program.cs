//Understanding Methods
/* Methods are defined by an access modifier and return type (or void for no returm stype) and may or may not take parameters */

/* A Method that returns a value to the caller is commonly referred to as a function while methods that do not return a value are commonly referred to as methods. */

/* Basic format of a method - static returnType MethodName(parameter list){ Implementation } */

/* Static methods can be called directly without creating a class instance. */

static int Add(int x, int y)
{
    return x + y;
}
/* Methods can be implemented within the scope of classes,stuctured, or interfaces */


//Understanding Expression-Bodied Members
/* It Shortens the syntax for single-line methods. It is commonly reffered to as syntactic sugar. "=>" operator is a lambda operation */
static int Add1(int x, int y) => x + y;


//Understanding Local Functions
/* The ability to create methods within methods is referred to as local functions. */
/* A local function is a function is a function declared inside another function. It must be private and can be static (C# 8.0) and does not support overloading */
/* Local functions do support nesting: a local function can have a local function declared inside it. */
static int AddWrapper(int x, int y)
{
    //Do Some Validation here
    return Add(); //The Add() method can be called only from the AddWrapper() method

    int Add()
    {
        return x + y;
    }
}

/* Local Functions allows adding attributes to a local function, its parameters, and its type parameters (C# 9.0) */


// Understanding Static Local Functions (New 8.0)
static int AddWrapperWithStatic(int x, int y)
{
    //Do Some Validation here
    return Add(x,y); //The Add() method can be called only from the AddWrapper() method

    static int Add(int x, int y) // The static prevents the local function from accessing the parent method variables directly.
    {
        return x + y;
    }
}

