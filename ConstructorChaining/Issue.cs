namespace ConstructorChainging.Issue
{
    class Student
    {
        public string _name;
        public string? _address;

        //Redundant constructor logic!.
        //If you want to update this redundant logic, you will have to update all constructors.
        public Student(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name cannot be null or empty");
            }
            else
            {
                _name = name;
            }
        }

        public Student(string name, string address)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name cannot be null or empty");
            }
            else
            {
                _name = name;
            }

            _address = address;
        }
    }
}
