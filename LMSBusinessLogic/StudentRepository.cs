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
    public class StudentRepository : BaseRepository<Student, StudentDTO>
    {
        public StudentRepository(LMSDbContext dbContext) : base(dbContext)
        {
        }
    }
}
