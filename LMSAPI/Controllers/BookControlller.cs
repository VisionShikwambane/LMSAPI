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
    public class BookControlller : BaseController<BookRepository, Book, BookDTO>
    {
        public BookControlller(LMSDbContext dbContext) : base(dbContext)
        {
        }
    }
}
