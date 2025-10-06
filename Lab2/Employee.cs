namespace Lab2
{
    internal class Employee
    {
        private string _name;
        private bool _isHead;
        private Department _department;

        public string Name
        {
            get 
            { 
                return _name; 
            }
        }

        public bool IsHead
        {
            get
            {
                return _isHead;
            }
            set
            {
                _isHead = value;
            }
        }

        public void Transfer(Department newDepartment)
        {
            _department.Remove(this);
            newDepartment.Add(this);
        }

        public Department Department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }

        public Employee(string name, Department department)
        {
            _name = name;
            _isHead = false;
            _department = department;
            department.Add(this);
        }

        public override string ToString()
        {
            if (_isHead)
            {
                return $"{_name} начальник отдела {_department}";
            }
            else
            {
                return $"{_name} работает в отделе {_department}";
            }
        }
    }
}
