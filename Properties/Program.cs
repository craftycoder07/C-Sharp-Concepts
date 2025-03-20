// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Foo
{
    /*
     * In encapsulation, properties reduces the overhead of writing LONG getter and setter.
     */
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    /*
     * EXPRESSION BODIED PROPERTY ACCESSOR
     * We can use expressions if we know there is going to be only one statement in  getter and setter.
     */
    private string _lastName;
    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }
    
    /*
     * AUTO IMPLEMENTED PROPERTIES
     * These are the properties that are NOT backed by any private variable. Just has empty getter and setter.
     * Useful when you want to future-proof your development.
     * Good practice to write properties instead of fields as client library doesn't need to be compiled if we make changes in code.
     */
    public string CompanyName { get; set; }
    
    
    /*
     * You can use access modifiers with accessors of properties.
     * At least one of the accessor should have matching access modifier with the property.
     * e.g. If you make both accessor in below property private you will get compilation error.
     */
    private int _age;
    public int Age
    {
        get => _age;
        private set => _age = value;
    }
    
    /*
     * READONLY PROPERTIES
     * You can create readonly properties by creating properties backed by readonly fields.
     * In this case if you try to provide setter, you will get compilation error because readonly properties can be set only in a constructor.
     */
    private readonly double _salary;
    public double Salary
    {
        get => _salary;
    }

    /*
     * AUTO IMPLEMENTED READONLY PROPERTIES
     * This is a combination of AUTO IMPLEMENTED and READONLY properties.
     * AUTO IMPLEMENTED properties does not have any back up field and READONLY property doesn't have set accessor.
     */
    public string EmployeeCode { get; }
    
    /*
     * EXPRESSION BODIED PROPERTIES (There is difference between EXPRESSION BODIED ACCESSOR AND PROPERTIES)
     */
    public string FullName => $"{Name} {LastName}";
    
    
}
