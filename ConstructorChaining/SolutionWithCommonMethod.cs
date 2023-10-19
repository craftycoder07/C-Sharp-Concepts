namespace ConstructorChainging.Solution.CommonMethod
{
    class Student
    {
        public string _name;
        public string? _address;

        //Removed redundancy by creating common method.
        //Still it has MINOR redundancy as we have to call this common
        public Student(string name)
        {
            SetStudentName(name);
        }

        public Student(string name, string address)
        {
            SetStudentName(name);
            _address = address;
        }

        private void SetStudentName(string name)
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
    }
}
