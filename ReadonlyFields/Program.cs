// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



public class Foo
{
    /*
     * 1) Readonly fields are initialized in constructor
     * 2) Once initialized, they cannot be assigned value anywhere else in the code
     * 3) Best use case for it is loading configuration values.
     *    They are not know when developing SW, and you dont want to change them during execution.
     */

    public readonly int _testNumber = 20;
    
    public Foo()
    {
        _testNumber = 10;
    }
}
