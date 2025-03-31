/*
 * METHOD OVERRIDING is applicable in INHERITANCE.
 * In method overriding parent class and child class has same methods (method signature) and different implementations
 * Only difference is, Parent class method signature has 'virtual' keyword and child class signature has 'override' keyword
 * Method overriding is used when you want to allow child classes to have their own implementations.
 * If 'virtual' keyword is missing and 'override' keyword is used in parent and child class, compilation error will be given.
 */

public class Shape
{
    // With virtual keyword, child class can override 'Draw' method.
    public virtual void Draw()
    {
        Console.WriteLine("In draw method of shape");
    }

    public virtual void Move()
    {
        Console.WriteLine("In move method of shape");
    }
}

public class Rectangle : Shape
{
    //With override keyword, child class is providing different implementation.
    public override void Draw()
    {
        Console.WriteLine("In draw method of rectangle");
    }
    
    //If parent class method is defined as a 'virtual' and 'override' keyword is missing in child class, it is considered as a method hiding.
    public void Move()
    {
        Console.WriteLine("In move method of rectangle");
    }
}