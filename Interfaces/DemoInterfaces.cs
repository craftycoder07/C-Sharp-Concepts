namespace Interfaces;

/*
 * Interfaces are contracts or pacts.
 * In C#, usually interfaces are 'implemented'. Meaning class or interface is inheriting from another interface.
 * Till C#7, interfaces used to contain only method declarations (abstract methods from abstract classes without abstract keyword)
 * From C#8, interfaces can have methods with definitions, they are called default methods.
 * Default methods from interfaces are not inherited into a class. They can be called only using that interface variable.
 * Whenever interface is implemented, all of its methods need to be implemented (definition should be provided) in implementing type.
 * A class can implement multiple interfaces as opposed to only inheriting single class.
 * Common notation is to start interface name with 'I'.
 * Interfaces are useful in developing decoupled software which improves testability of the application. 
 */

public interface IBankAccount
{
    void Deposit(int amount);
    decimal Withdraw(int amount);
    decimal GetBalance();

    //default method of the interface
    void GetBalance2()
    {
        Console.WriteLine(this.GetBalance());
    }
}

//If you don't implement all methods after inheriting from interface you will get compilation error.
// public class BankAccount : IBankAccount
// {
//     
// }

//Multiple interface inheritace.
public class RandomAccount : IBankAccount, IDisposable
{
    //Throwing exception is also a valid implementation.
    public void Deposit(int amount)
    {
        throw new NotImplementedException();
    }

    public decimal Withdraw(int amount)
    {
        throw new NotImplementedException();
    }

    public decimal GetBalance()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}