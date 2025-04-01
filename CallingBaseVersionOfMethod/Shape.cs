namespace CallingBaseVersionOfMethod;

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("In draw of Shape");
    }

    public void Draw2()
    {
        Console.WriteLine("In draw2 of Shape");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        /*
         * Developers can use 'base' keywords, to call method from parent class. 
         */
        base.Draw();
        Console.WriteLine("In draw of rectancle");
    }

    public void Draw2()
    {
        /*
         * 'base' keyword has no dependency on 'virtual' & 'override' keyword. 
         */
        base.Draw();
        Console.WriteLine("In draw2 of rectancle");
    }
}
