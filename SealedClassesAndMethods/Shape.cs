namespace SealedClassesAndMethods;

/*
* With 'sealed' keyword, developers can prevent their classes from being inherited.
*/
public sealed class Shape
{
    public void Draw()
    {
        Console.WriteLine("In draw of Shape");
    }
}

/*
* If you try to inherit from sealed class, you will get compilation error as follows
*/
// public class Rectangle : Shape
// {

// }

/*
* Developers can use 'sealed' keyword only with overriden methods.
* If you use 'sealed' keyword with normal methods, compiler will give you error.

*/
public class Shape2
{
    public virtual void Draw()
    {
        Console.WriteLine("In draw of shape2");
    }
}

public class Shape3 : Shape2
{
    /*
    * If you mark overriden method as 'sealed', following child class in inheritance won't be able to override the method.
    */
    public sealed override void Draw()
    {
        Console.WriteLine("In draw of shape3");
    }
}

/*
* Compiler error will be given if you try to override the sealed method
*/
// public class Shape4 : Shape3
// {
//     public override void Draw()
//     {
//         Console.WriteLine("In draw of shape4");
//     }
// }

/*
* You can still override method from base class.
*/
public class Shape5 : Shape2
{
    public override void Draw()
    {
        Console.WriteLine("In draw of shape4");
    }
}


