using System.Runtime.CompilerServices;

namespace AccessModifiers;

public class Shape
{
    //private members are available only within that class
    private static int x;
    
    //public members are available everywhere
    public static int y;
    
    //protected members are only available within derived class
    protected static int z = 3;
}

public class Rectangle : Shape
{
    public void Draw()
    {
        Console.WriteLine(z);
    }
}