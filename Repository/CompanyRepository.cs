﻿using Dapper;
using WebApplication1.Context;
using WebApplication1.Contracts;
using WebApplication1.Entities;

namespace WebApplication1.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DapperContext _context;
        public CompanyRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            var query = "Select * from Companies";

            using (var connection =_context.CreateConnection())
            {
                var companies = await connection.QueryAsync<Company>(query);
                return companies.ToList();
            }
        }
    }
}
