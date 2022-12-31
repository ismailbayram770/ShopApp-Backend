using ExampleProject.Back.Core.Application.Interfaces;
using ExampleProject.Back.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ExampleProject.Back.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly ExampleProjectContext exampleProjectContext;

        public Repository(ExampleProjectContext exampleProjectContext)
        {
            this.exampleProjectContext = exampleProjectContext;
        }

        public async Task CreateAsync(T entity)
        {
            await this.exampleProjectContext.Set<T>().AddAsync(entity);
            await this.exampleProjectContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await this.exampleProjectContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await this.exampleProjectContext.Set<T>().FindAsync(id);
        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await this.exampleProjectContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task RemoveAsync(T entity)
        {
            this.exampleProjectContext.Remove(entity);
            await this.exampleProjectContext.SaveChangesAsync();

        }

        public async Task UpdateAsync(T entity)
        {
            this.exampleProjectContext.Update(entity);
            await this.exampleProjectContext.SaveChangesAsync();
        }
    }
}
