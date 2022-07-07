namespace EmployeePolymorphismApp.Model
{
    public abstract class Employee
    {
        private int _id;
        private string _name;
        protected double _salary;
        public Employee(int id, string name, double salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }
        public abstract double TotalSalary();
        public abstract double AnnualCTC();
        public int ID { get { return _id; } }
        public string Name { get { return _name; } }
        public double Salary { get { return _salary; } }
    }
}
