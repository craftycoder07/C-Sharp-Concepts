// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * INVOKING INSTANCE METHODS
 */
TestMethods testMethods = new TestMethods();
Console.WriteLine(testMethods.GetFullName("Sid", "Chalke"));

/*
 * NAMED ARGUMENTS
 * When calling a method, developer can specify which argument belongs to which parameter.
 * This way developer doesn't have to maintain order of the arguments when calling the function. They can be shuffled as follows and code will still compile.
 */
Console.WriteLine(testMethods.GetFullName(firstName:"Sid",lastName:"Chalke",middleName:"Vijay"));

/*
 * INVOKING STATIC METHODS
 */
TestMethods.SayHello("Sid");

//OPTIONAL PARAMETER:=> Pay attention as I have not passed 3rd parameter, default value will be taken.
Console.WriteLine(testMethods.GetInterest(1,4));

//Different ways to calling method that takes variable argument 
Console.WriteLine(testMethods.AddNumbers(2,4));
Console.WriteLine(testMethods.AddNumbers(2,4,6));
Console.WriteLine(testMethods.AddNumbers(new []{1, 2,3,4,5}));

class TestMethods
{
    /*
     * SYNTAX OF THE METHOD
     */
    //[Access Modifier] [Return Type]  [Method Name]  [Parameters. (Can send any number of parameters)]
      public static     void           SayHello       (string name)
      {
        Console.WriteLine($"Hello, {name}!");
      }
    
    /*
     * EXPRESSION-BODIED METHODS
     * 1) If you have only one statement in a method you can ignore method brackets.
     * 2) If function is returning a value, return keyword can also be ignored as one statement will be automatically returned.
     */
    public string GetFullName(string firstName, string lastName) => $"{firstName} {lastName}";
    
    /*
     * METHODS OVERLOADING
     * 1) In method overloading, TYPE or NUMBER of parameters to the method are changed. Method name remains same.
     * 2) If you change only return type, then it is not method overloading.
     */
    public string GetFullName(string firstName, string middleName, string lastName) => $"{firstName} {middleName} {lastName}";
    
    /*
     * OPTIONAL PARAMETERS
     * 1) Developers can define optional parameters by assigning default value to its parameter (valueC).
     * 2) When calling the method, if developer doesn't pass value for valueC, default value will be taken.
     * 3) optional parameter should always be last parameter otherwise you will get compilation error.
     * 4) You can define as many optional parameters as you want
     * 5) If you change default value of optional parameter or change number of arguments in a method that takes optional parameter, client code needs to be recompiled.
     */
    public int GetInterest(int valueA, int valueB, int valueC = 5) => valueA + valueB + valueC;
    
    /*
     * VARIABLE NUMBER OF ARGUMENTS
     * 1) You can define variable number of arguments for a method using 'params' keyword along with an array of required type as a parameter.
     * 2) variable number of arguments should be the last parameter.
     * 3) You can define only one variable argument parameter for a method.
     */
    public int AddNumbers(params int[] args)
    {
        int sum = 0;
        foreach (var number in args)
        {
            sum += number;    
        }
        return sum;
    }
}