namespace AbstractClassesAndMethods;

/*
* Abstarct classes are classes whos instance cannot be created.
* Developers can use 'abstarct' keyword to declare class.
* Goal here is to restrict developers from creating instance of the class.
*/
public abstract class Shape
{
    //Abstarct classes can have normal members (fields, methods, properties & events)
    public decimal LocationX { get; set; }
    public decimal LocationY { get; set; }

    /*
    * Important thing is abstarct classes can have 'abstarct methods'.
    * These are methods without implementation. They ony have method declaration.
    * With abstract classes developers can dump the responsibility of implementing abstract methods to consumer.
    * Abtsract metthods are automatically 'virtual' because they have to be overriden in child class.
    * If you declare method as abstract, then by default class is also abstract and then developer will have to define it.
    */
    public abstract void Draw();
}

public class Rectangle : Shape
{
    /*
    * If you don't implement abstract method in immediate NON-abstarct class, compiler will give error.
    */
    public override void Draw()
    {
        Console.WriteLine("In draw method of Rectangle");
    }
}


public abstract class Shape2 : Shape
{
    /*
    * Abstract methods need to implemented in immediate NON-ABSTRACT classe.
    * In this example since Shape2 is also abstarct class, no need to implement abstarct method.
    */
}
