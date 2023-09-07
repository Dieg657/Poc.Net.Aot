using Poc.Net.Aot.Application.Interfaces.Services;
using Poc.Net.Aot.Domain.Entities;
using Poc.Net.Aot.Domain.Models;
using Poc.Net.Aot.Repository.Interfaces;

namespace Poc.Net.Aot.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        public readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Employee>> GetAll() 
            => await _repository.GetAll();

        public async Task Insert(EmployeeDto model) 
            => await _repository.Insert(model);
    }
}
