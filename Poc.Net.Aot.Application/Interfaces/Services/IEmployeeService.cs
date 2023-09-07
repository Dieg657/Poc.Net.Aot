using Poc.Net.Aot.Domain.Entities;
using Poc.Net.Aot.Domain.Models;

namespace Poc.Net.Aot.Application.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task Insert(EmployeeDto model);
    }
}
