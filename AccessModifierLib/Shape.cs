namespace AccessModifierLib;

public class Shape
{
    //private members are available only within the class
    private static int x = 1;
    
    //public members are available everywhere
    public static int y = 2;

    //internal members are available only within assembly
    internal static int z = 3;
    
    //protected members are only available within derived class
    protected static int a = 4;
    
    //'protected internal' members are accessible in derived class OR in classes within same assembly
    protected internal static int b = 5;
    
    //'private protected' members are accessible in derived class of the same assembly.
    private protected static int c = 6;
}

public class Rectangle : Shape
{
    public void Draw()
    {
        /*
         * Trying to access private member in derived class. Compilation error.
         */
        //Console.WriteLine(x);
        
        /*
         * Trying to access public member in derived class. Successful.
         */
        Console.WriteLine(y);
        
        /*
         * Trying to access internal member in derived class. Successful.
         */
        Console.WriteLine(z);
        
        /*
         * Trying to access protected member in derived class. Successful.
         */
        Console.WriteLine(a);
        
        /*
         * Trying to access 'protected internal' member in derived class. Successful.
         */
        Console.WriteLine(b);
        
        /*
         * Trying to access 'private protected' member in derived class. Successful.
         */
        Console.WriteLine(c);
    }
}

public class Shape2
{
    public static void Draw()
    {
        /*
         * Trying to access private member in other class. Compilation error.
         */
        //Console.WriteLine(Shape.x);
        
        /*
         * Trying to access public member in other class. Successful.
         */
        Console.WriteLine(Shape.y);
        
        /*
         * Trying to access internal member in other class. Successful.
         */
        Console.WriteLine(Shape.z);
        
        /*
         * Trying to access protected member in other class. Compilation error.
         */
        //Console.WriteLine(Shape.a);
        
        /*
         * Trying to access 'protected internal' member in other class in same assembly. Successful.
         */
        Console.WriteLine(Shape.b);
        
        /*
         * Trying to access 'private protected' member in other class in same assembly. Compilation Error.
         */
        //Console.WriteLine(Shape.c);
    }
}