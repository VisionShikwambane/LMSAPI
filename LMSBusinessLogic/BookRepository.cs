using LMSDatabaseContext;
using LMSDataModels.DomainModels;
using LMSDataModels.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBusinessLogic
{
    public class BookRepository : BaseRepository<Book, BookDTO>
    {
        public BookRepository(LMSDbContext dbContext) : base(dbContext)
        {

        }
    }
}
