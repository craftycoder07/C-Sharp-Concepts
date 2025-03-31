namespace MethodHiding;

/*
 * In METHOD HIDING, both parent and child class has same methods (method signature)
 * No 'virtual' or 'override' keyword is used.
 * Compiler will give warning for child class method, asking to use new keyword if hiding is intentional.
 * To suppress warning message developers can use 'new' keyword in method signature.
 */

public class Shape
{
    public void Draw()
    {
        Console.WriteLine("In draw method of shape");
    }

    public void Draw2()
    {
        Console.WriteLine("In draw2 method of shape");
    }
}

public class Rectangle : Shape
{
    /*
     * Compiler will give warning to indicate there is method hiding.
     */
    public void Draw()
    {
        Console.WriteLine("In Draw method of rectangle");
    }

    /*
     * As you can see below with 'new' keyword, I am able to suppress warning.
     */
    public new void Draw2()
    {
        Console.WriteLine("In Draw2 method of rectangle");
    }
}