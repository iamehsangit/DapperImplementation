using Dapper;
using WebApplication1.Context;
using WebApplication1.Contracts;
using WebApplication1.Entities;

namespace WebApplication1.Repository
{
    public class EmployeeRepository : IEmpolyeeRepository
    {
        private readonly DapperContext _context;
        public EmployeeRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var query = "select * from Employees";

            using (var connection = _context.CreateConnection())
            {
                var employees = await connection.QueryAsync<Employee>(query);
                return employees.ToList();
            }
        }
    }
}
