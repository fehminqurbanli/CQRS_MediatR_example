using CQRS_MediatR_example.Models;

namespace CQRS_MediatR_example.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        List<Customer> Customers = new List<Customer>
        {
            new Customer{FirstName="Fehmin",LastName="Qurbanli",Age=21,Birthday=Convert.ToDateTime("30-10-2000") , Phone="+9947121710"},
            new Customer{FirstName="Mike",LastName="Jordan",Age=41,Birthday=Convert.ToDateTime("30-10-1980") , Phone="+9941111111"}
        };

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();

        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();

        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
