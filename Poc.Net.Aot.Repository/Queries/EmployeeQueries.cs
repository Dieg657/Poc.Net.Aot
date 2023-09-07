namespace Poc.Net.Aot.Repository.Queries
{
    public static class EmployeeQueries
    {
        public const string GET_ALL_EMPLOYEES = "SELECT * FROM Employees";
        public const string INSERT_EMPLOYEE = "INSERT INTO Employees (Role, Company, Location, Remote, Link, Salary) VALUES (@p0, @p1, @p2, @p3, @p4, @p5)";
    }
}
