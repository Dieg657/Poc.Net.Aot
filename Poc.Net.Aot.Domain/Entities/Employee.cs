using Poc.Net.Aot.Domain.Models;

namespace Poc.Net.Aot.Domain.Entities
{
    public class Employee : EmployeeDto
    {
        public long Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeleteAt { get; set; }
    }
}
