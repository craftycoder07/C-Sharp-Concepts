/*
 * Delegates are nothing but reference to a method.
 * The way we pass value to a method, we can also pass methods around.
 * This is useful when you want consumer of your call to add custom logic in your code.
 */

internal class Program
{
    //To declare a delegate, you just write method signature with delegate keyword
    delegate int Calculate(int a, int b);
    public static void Main(string[] args)
    {
        //You can assign method to delegate with traditional object creation syntax. [Note no parenthesis are used when assigning a method.]
        Calculate calc = new Calculate(Add);
        
        //You can call a method assigned to a delegate by following syntax
        Console.WriteLine($"Addition result is => {calc(10, 20)}");
        
        //You can also use shorthand syntax to assign method to a delegate.
        calc+=Subtract;
        Console.WriteLine($"Subtraction result is => {calc(10, 20)}");
    }
    
    //Method that is going to be assigned to a delegate must match its signature, else you will get compilation error.
    static int Add(int a, int b) => a + b;
    
    static int Subtract(int a, int b) => a - b;
    
    //You can't assign below method to 'Calculate' delegate as it takes 3 parameters and delegate takes only 2 parameters.
    static int Subtract(int a, int b, int c) => a - b - c;
}