// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//SINGLETON PATTERN USAGE
Bar bar = Bar.Instance;

public class Foo
{
    public static string LogPath { get; private set; }
    private readonly string _name;
    private readonly int _age;
    /*
     * DEFAULT CONSTRUCTOR
     * Constructors are like methods without return type and name same as a class.
     * Default constructor takes no parameters.
     * If you don't declare default constructor and there is no other constructor compiler will automatically add one.
     * This compiler generated default constructor will automatically set default values to all member fields. 
     */
    public Foo()
    {
        _name = "Sid";
    }
    
    /*
     * CONSTRUCTOR OVERLOADING
     * As constructors as nothing but specialized methods they follow rules of overloading of methods as well.
     */
    public Foo(string name)
    {
        _name = name;
    }
    
    /*
     * EXPRESSION BODIED CONSTRUCTOR
     * As constructors are similar to methods, EXPRESSION bodied rules apply here as well.
     * Only assignment works here as there is no return type.
     */
    public Foo(string firstName, string lastName) => _name = firstName;
    
    /*
     * CALLING OTHER CONSTRUCTOR
     * There is a shortcut to call constructor of the same class using 'this' keyword as shown below.
     * This convention helps developer from writing repetitive code.
     * Constructor with 'this' keyword gets called first. Then actual constructor gets executed.
     */
    public Foo(int age) : this() => _age = age;
    
    /*
     * STATIC CONSTRUCTORS
     * Just like static methods, developers can define static constructors.
     * NO ACCESS MODIFIER.
     * NO PARAMETERS.
     * CAN BE CALLED ANY TIME. (NOT IN DEVELOPERS HANDS)
     */
    static Foo() => LogPath = "Sid";
}

public class Bar
{
    /*
     * CONSTRUCTOR ACCESS MODIFIERS
     * You can use PRIVATE OR PROTECTED access modifiers with constructor but in this case no one will be able to initialize your class from outside.
     * This pattern is usually used to create SINGLETON pattern (Pattern where you want to have only one instance)
     */
    private Bar()
    {
        
    }
    
    private static Bar _instance;
    public static Bar Instance
    {
        get => _instance ?? (_instance = new Bar());
    }
}
