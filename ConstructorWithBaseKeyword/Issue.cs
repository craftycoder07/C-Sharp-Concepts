namespace ConstructorWithBaseKeyword.Issue
{
    public class Person
    {
        public string Name { get; set; } = null!;
        public byte Age { get; set; }
    }

    public class Teacher : Person
    {
        public int Salary { get; set; }

        public Teacher(string name, byte age, int salary)
        {
            //These properties are from base class. Hence they become repeatative code in other derived classes.
            Name = name;
            Age = age;

            //Only property of Teacher class
            Salary = salary;
        }
    }

    public class Student : Person
    {
        public byte RollNumber { get; set; }

        public Student(string name, byte age, byte rollNumber)
        {
            //These properties are from base class. Hence they become repeatative code in other derived classes.
            Name = name;
            Age = age;

            //Only property of Student class
            RollNumber = rollNumber;
        }
    }
}
