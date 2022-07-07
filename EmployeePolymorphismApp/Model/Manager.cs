namespace EmployeePolymorphismApp.Model
{
    public class Manager : Employee
    {
        public Manager(int id, string name, double salary) : base(id, name, salary) { }

        public override double TotalSalary()
        {
            double totalSalary = _salary + _salary * 50 / 100 + _salary * 40 / 100;
            return totalSalary;
        }
        public override double AnnualCTC()
        {
            return 12 * TotalSalary();
        }
    }
}
