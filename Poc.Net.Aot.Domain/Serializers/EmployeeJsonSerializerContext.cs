using Poc.Net.Aot.Domain.Models;
using Poc.Net.Aot.Domain.Entities;
using System.Text.Json.Serialization;

namespace Poc.Net.Aot.Domain.Serializers
{
    [JsonSerializable(typeof(Employee))]
    [JsonSerializable(typeof(IAsyncEnumerable<Employee>))]
    [JsonSerializable(typeof(IEnumerable<Employee>))]
    [JsonSerializable(typeof(List<Employee>))]
    [JsonSerializable(typeof(EmployeeDto))]
    [JsonSerializable(typeof(IAsyncEnumerable<EmployeeDto>))]
    [JsonSerializable(typeof(IEnumerable<EmployeeDto>))]
    [JsonSerializable(typeof(List<EmployeeDto>))]
    public partial class EmployeeJsonSerializerContext : JsonSerializerContext
    {
    }
}
