using Domain.IGeneric;
using Infrastracture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Repository
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

   

        public async Task<T> AddAsync(T entity)
        {
             context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
            // throw new NotImplementedException();
        }

       

        public async Task DeleteAsync(T entity)
        {
             context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
           // return entity;
           
            // throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await context.Set<T>().ToListAsync();
            return entities;

            //throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Entity with id {id} not found.");
            }
            return entity;


            //throw new NotImplementedException();
        }

        public async Task UpdateAsync(T entity)
        {
            context.Set<T>().Update(entity);

            await context.SaveChangesAsync();
 // throw new NotImplementedException();
        }
    }
}
