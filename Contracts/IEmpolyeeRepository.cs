using WebApplication1.Entities;

namespace WebApplication1.Contracts
{
    public interface IEmpolyeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployees();
    }
}
