using Npgsql;
using Poc.Net.Aot.Domain.Entities;
using Poc.Net.Aot.Domain.Models;
using Poc.Net.Aot.Repository.Interfaces;
using Poc.Net.Aot.Repository.Queries;

namespace Poc.Aot.Repository
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {
        public readonly string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            var result = new List<Employee>();

            try
            {
                using var dataSource = new NpgsqlDataSourceBuilder(_connectionString).Build();
                using var connection = dataSource.OpenConnection();
                using var cmd = new NpgsqlCommand(EmployeeQueries.GET_ALL_EMPLOYEES, connection);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    result.Add(new Employee
                    {
                        Id = (long)reader["id"],
                        Role = reader["role"].ToString(),
                        Company = reader["company"].ToString(),
                        Location = reader["location"].ToString(),
                        Remote = (bool)reader["remote"],
                        Link = reader["link"].ToString(),
                        Salary = (decimal)reader["salary"],
                        CreatedAt = DateTimeOffset.TryParse(reader["createdat"].ToString(), out DateTimeOffset createdat) ? createdat : DateTimeOffset.MinValue,
                        UpdatedAt = DateTimeOffset.TryParse(reader["updatedat"].ToString(), out DateTimeOffset updatedat) ? updatedat : null,
                        DeleteAt = DateTimeOffset.TryParse(reader["deletedat"].ToString(), out DateTimeOffset deletedat) ? deletedat : null,
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public async Task Insert(EmployeeDto model)
        {
            try
            {
                using var dataSource = new NpgsqlDataSourceBuilder(_connectionString).Build();
                using var connection = dataSource.OpenConnection();
                using var cmd = new NpgsqlCommand(EmployeeQueries.INSERT_EMPLOYEE, connection);

                cmd.Parameters.AddWithValue("p0", model.Role);
                cmd.Parameters.AddWithValue("p1", model.Company);
                cmd.Parameters.AddWithValue("p2", model.Location);
                cmd.Parameters.AddWithValue("p3", model.Remote);
                cmd.Parameters.AddWithValue("p4", model.Link);
                cmd.Parameters.AddWithValue("p5", model.Salary);

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
