using LMSBusinessLogic;
using LMSDatabaseContext;
using LMSDataModels.DomainModels;
using LMSDataModels.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : BaseController<DepartmentRepository, Department, DepartmentDTO>
    {
        public DepartmentsController(LMSDbContext dbContext) : base(dbContext)
        {
        }
    }
}
