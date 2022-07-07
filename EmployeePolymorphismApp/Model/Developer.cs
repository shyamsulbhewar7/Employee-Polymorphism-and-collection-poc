namespace EmployeePolymorphismApp.Model
{
    public class Developer : Employee
    {
        public Developer(int id, string name, double salary) : base(id, name, salary) { }
        public override double TotalSalary()
        {
            double totalSalary = _salary + _salary * 40 / 100;
            return totalSalary;
        }
        public override double AnnualCTC()
        {
            return 12 * TotalSalary();
        }
    }
}
