using WebApplication1.Entities;

namespace WebApplication1.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
    }
}
