namespace singleResponsibilityPrinciple
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
    public class PayrollCalculator
    {
        public decimal CalculatePay(Employee employee)
        {
            return employee.Salary * 1.1m;
        }
    }
    public class EmployeeReportGenerator
    {
        public string GenerateReport(Employee employee)
        {
            return $"Employee: {employee.Name}";
        }
    }
}