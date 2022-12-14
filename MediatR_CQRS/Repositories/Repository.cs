using MediatR_CQRS.Data;

namespace MediatR_CQRS.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly DataContext _dataContext;

        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity==null)
            {
                throw new ArgumentException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await _dataContext.AddAsync(entity);
                await _dataContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {

                throw new Exception($"{nameof(entity)} could not be saved");
            }
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _dataContext.Set<TEntity>();
            }
            catch (Exception)
            {

                throw new Exception("Could not retrieve entites");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                _dataContext.Update(entity);

                await _dataContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(AddAsync)} could not be updated");
            }


        }
    }
}
