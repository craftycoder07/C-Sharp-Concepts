namespace ConstructorWithBaseKeyword.Solution
{
    public class Person
    {
        public required string Name { get; set; }
        public byte Age { get; set; }

        public Person(string name, byte age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Teacher : Person
    {
        public int Salary { get; set; }

        public Teacher(string name, byte age, int salary) : base(name, age)
        {
            //Only property of Teacher class
            Salary = salary;
        }
    }

    public class Student : Person
    {
        public byte RollNumber { get; set; }

        public Student(string name, byte age, byte rollNumber) : base(name, age)
        {
            //Only property of Student class
            RollNumber = rollNumber;
        }
    }
}
