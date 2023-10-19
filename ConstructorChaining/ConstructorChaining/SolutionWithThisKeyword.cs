namespace ConstructorChainging.Solution.ThisKeyword
{
    class Student
    {
        public string _name;
        public string? _address;

        //Removed redundancy by using this keyword.
        //Usually we put all common logic in constructor with max # of parameters
        public Student(string name) : this(name, string.Empty)
        {
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
