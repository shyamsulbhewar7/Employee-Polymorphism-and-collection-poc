namespace EmployeePolymorphismApp.Model
{
    public class Tester : Employee
    {
        public Tester(int id, string name, double salary) : base(id, name, salary) { }
        public override double TotalSalary()
        {
            double totalSalary = _salary + _salary * 30 / 100;
            return totalSalary;
        }
        public override double AnnualCTC()
        {
            return 12 * TotalSalary();
        }
    }
}
