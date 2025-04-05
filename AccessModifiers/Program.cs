using AccessModifierLib;

//Can't access private members anywhere
//Console.WriteLine(Shape.x);

//Can access public member
Console.WriteLine(Shape.y);

//Can't access internal members
//Console.WriteLine(Shape.z);

public class Circle : Shape
{
    public static void Draw2()
    {
        //protected member is accessible in derived class in different assembly
        Console.WriteLine(a);
        
        //'protected internal' is accessible in derived class of different assembly
        Console.WriteLine(b);
        
        //'private protected' NOT accessible in derived class of different assembly
        //Console.WriteLine(c);
    }
}

public class Cone
{
    public static void Draw2()
    {
        //'protected internal' is NOT accessible in other class of different assembly
        //Console.WriteLine(b);
        
        //'private protected' NOT accessible in other class of different assembly
        //Console.WriteLine(c);
    }
}


