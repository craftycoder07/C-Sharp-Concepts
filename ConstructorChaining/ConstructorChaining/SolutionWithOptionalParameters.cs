namespace ConstructorChainging.Solution.OptionalParameters
{
    class Student
    {
        public string _name;
        public string? _address;

        //With optional parameters, we can remove redundancy and reduce number of constructors as well.
        public Student(string name, string address = "")
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
