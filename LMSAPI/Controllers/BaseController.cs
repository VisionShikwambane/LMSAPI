using LMSBusinessLogic;
using LMSDataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using LMSDatabaseContext;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using System.Linq;

namespace LMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<IRepository, T, TDTO> : ODataController where IRepository : class, IBusinessLogic<T, TDTO> where T : class, IEntity, IMapToDTO<TDTO> where TDTO : class, IMapToDomain<T>
    {
        private readonly LMSDbContext dbContext;
        private readonly IRepository repository;

        public BaseController(LMSDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.repository = (IRepository)Activator.CreateInstance(typeof(IRepository), dbContext);
        }

        [EnableQuery]
        [HttpGet]
        public virtual async Task<IEnumerable<TDTO>> Get()
        {
            return await repository.GetAll();
        }

        [EnableQuery]
        [HttpGet("{key}")]
        public virtual async Task<TDTO> Get(int key)
        {
            var response =  await repository.GetById(key);
            return response;
        }

        [HttpPost]

        public virtual async Task<IActionResult> Post([FromBody] TDTO dto)
        {   
          var response =  await  repository.Add(dto);
          return Ok(response);
        }


        [HttpDelete]
        public virtual async Task<IActionResult> Delete(int Id)
        {
            var response = await repository.Delete(Id);
            return Ok(response);
        }

    }
}
