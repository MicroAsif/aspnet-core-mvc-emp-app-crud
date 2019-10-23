using EasyInventory.Core.Interfaces.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using SignalR.core.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using dotnetT.Persistance;

namespace EasyInventory.Data.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly AppDbContext context;
        private DbSet<T> entities;
        public BaseRepository(AppDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public void Add(T entity)
        {
            context.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
           await context.AddAsync(entity);
        }

        public async Task AddAsyncRange(List<T> entites)
        {
           await context.AddRangeAsync(entities);
        }

        public void AddRange(List<T> entities)
        {
            context.AddRange(entities);
        }

        public IQueryable<T> All()
        {
            return entities.Where(x => !x.IsDelete);
        }
        public IQueryable<T> All(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> queryable = All();
            foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            {
                queryable = queryable.Include<T, object>(includeProperty);
            }
            return queryable;
        }
        public T Find(Guid id)
        {
            return All().FirstOrDefault(x=>x.Id == id);
        }

        public async Task<T> FindAsync(Guid id)
        {
            return await entities.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            context.Update(entity);
        }

    
        public void UpdateRange(List<T> entites)
        {
            context.UpdateRange(entities);
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }
        public Task DeleteAsyncRange(List<T> entites)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<T> entites)
        {
            if (entites == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.RemoveRange(entites);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

       
    }
}
