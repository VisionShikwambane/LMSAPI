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
    public class StudentsController : BaseController<StudentRepository, Student, StudentDTO>
    {
        public StudentsController(LMSDbContext dbContext) : base(dbContext)
        {
        }
    }
}
