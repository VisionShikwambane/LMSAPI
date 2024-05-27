using LMSDatabaseContext;
using LMSDataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LMSBusinessLogic
{
    public class BaseRepository<T, TDTO> : IBusinessLogic<T, TDTO> where T : class, IEntity, IMapToDTO<TDTO> where TDTO : class, IMapToDomain<T> 
    {
        protected readonly LMSDbContext  dbContext;
        public BaseRepository(LMSDbContext  dbContext)
        {
            this.dbContext = dbContext;
        }

        public virtual async Task<IEnumerable<TDTO>> GetAll()
        {
            var entities = await dbContext.Set<T>().ToListAsync();
            return entities.Select(e => e.toDTO());
        }

     

        public virtual async Task<TDTO> Add(TDTO dto)
        {
            T entity = dto.toDomain();

            var validationResults = IsValidated(entity , dto);

           if (validationResults == true)
            {
             
                dbContext.Entry(entity).State = EntityState.Detached;
                dbContext.Set<T>().Update(entity);
                await dbContext.SaveChangesAsync();
                return entity.toDTO();
            }

           return dto;
          
          
        }

        public async Task<TDTO> GetById(int Id)
        {
            var entity =  await dbContext.Set<T>().FindAsync(Id);
            return entity.toDTO();
        }


        public virtual async Task<bool> Delete(int id)
        {
            var entity = await dbContext.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return false; 
            }

            dbContext.Set<T>().Remove(entity);
            await dbContext.SaveChangesAsync();
            return true;
        }





        public virtual bool IsValidated(T entity, TDTO entityDTO)
        {
            return true;
        }
    }
}
