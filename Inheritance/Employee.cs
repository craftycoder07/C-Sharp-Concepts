//Parent Class. Multiple inheritance possible only through interfaces.
public class Employee : IEmployeeActions, IEmployeeActions2
{
    private string firstName;
    public string lastName;

    public Employee(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public void CheckIn()
    {
        throw new NotImplementedException();
    }

    public void CheckSalary()
    {
        throw new NotImplementedException();
    }

    public void TakeLunchBreak()
    {
        throw new NotImplementedException();
    }

    public void RequestHolidays()
    {
        throw new NotImplementedException();
    }
}

//Child Class. Only single class inheritance is supported.
public class Manager : Employee
{
    //All public MEMBERS are inherited.
    //private members are not inherited.
    public Manager(string firstName, string lastName) : base(firstName, lastName)
    {
        
    }
}

public interface IEmployeeActions
{
    void CheckIn();
    void CheckSalary();
}

public interface IEmployeeActions2
{
    void TakeLunchBreak();
    void RequestHolidays();
}