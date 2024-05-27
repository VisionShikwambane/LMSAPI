using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSDataModels;


namespace LMSBusinessLogic
{
    public interface IBusinessLogic<T, TDTO> where T : class, IEntity, IMapToDTO<TDTO> where TDTO : class, IMapToDomain<T>
    {

        Task<IEnumerable<TDTO>> GetAll();
        Task<TDTO> Add(TDTO dto);
        Task<TDTO> GetById(int Id);
        Task<bool> Delete(int id);






    }
}
