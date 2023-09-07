using Poc.Net.Aot.Domain.Models;
using Poc.Net.Aot.Domain.Entities;

namespace Poc.Net.Aot.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAll();
        Task Insert(EmployeeDto model);
    }
}
