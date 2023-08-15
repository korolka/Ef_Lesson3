using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_V2.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public async Task<bool> Create(TEntity entity)
        {
            using(EntityDatabase db = new EntityDatabase())
            {
                await db.Set<TEntity>().AddAsync(entity);
                return true;
            }
        }

        public async Task<bool> Delete(TEntity entity)
        {
            using (EntityDatabase db = new EntityDatabase())
            {
                await db.Set<TEntity>().AddAsync(entity);
                return true;
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            using (EntityDatabase db = new EntityDatabase())
            {
               return await db.Set<TEntity>().FindAsync(id);
            }
        }

        public async Task<IEnumerable<TEntity>> Select()
        {
            using (EntityDatabase db = new EntityDatabase())
            {
                return await db.Set<TEntity>().ToListAsync();
            }
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            using (EntityDatabase db = new EntityDatabase())
            {
                db.Entry(entity).State= EntityState.Modified;
                await db.SaveChangesAsync();
                return entity;
            }
        }
    }
}
