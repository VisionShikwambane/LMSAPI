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
    public class DepartmentRepository : BaseRepository<Department, DepartmentDTO>
    {
        public DepartmentRepository(LMSDbContext dbContext) : base(dbContext)
        {

        }

        public override bool IsValidated(Department entity, DepartmentDTO entityDTO)
        {
            string code = entityDTO.Name;

            if(code == null || code == "")
            {
                return false;
            }
            return true;
          
        }
    }
}
