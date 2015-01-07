namespace SalaryApp
{
    internal class Employee
    {
        public Employee(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public string Email { private get; set; }

        public string Name { get; set; }

        public string Id { get; set; }
        public Salary EmployeeSalary { get; set; }
    }
}