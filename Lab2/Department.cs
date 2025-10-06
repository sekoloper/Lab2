namespace Lab2
{
    internal class Department
    {
        private string _name;
        private Employee _head;
        private Employee[] _employees;

        public string Name
        {
            get 
            { 
                return _name; 
            }
            set
            {
                _name = value;
            }
        }

        public Employee Head
        {
            get
            {
                return _head;
            }
            set
            {
                if (_head != null)
                {
                    _head.IsHead = false;
                }
                _head = value;
                value.IsHead = true;
            }
        }

        public Employee[] Employees
        {
            get
            {
                return _employees;
            }
        }

        public void Add(Employee newEmployee)
        {
            Employee[] newEmployees = new Employee[_employees.Length + 1];
            for (int i = 0; i < _employees.Length; i++)
            {
                newEmployees[i] = _employees[i];
            }
            newEmployees[_employees.Length] = newEmployee;
            _employees = newEmployees;
        }

        public void Remove(Employee employee)
        {
            Employee[] newEmployees = new Employee[_employees.Length - 1];
            for (int i = 0; i < Array.IndexOf(_employees, employee); i++)
            {
                newEmployees[i] = _employees[i];
            }
            for (int i = Array.IndexOf(_employees, employee); i < newEmployees.Length; i++)
            {
                newEmployees[i] = _employees[i + 1];
            }
            if (employee.IsHead)
            {
                employee.IsHead = false;
                newEmployees[0].IsHead = true;
                _head = newEmployees[0];
            }
        }

        public Department(string name)
        {
            _name = name;
            _employees = new Employee[0];
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
