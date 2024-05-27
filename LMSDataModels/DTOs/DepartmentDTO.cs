using LMSDataModels.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataModels.DTOs
{
    public class DepartmentDTO :  IMapToDomain<Department>
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;


        public Department toDomain()
        {
            return new Department
            {
                ID = this.ID,
                Name = this.Name,
                Description = this.Description
            };
        }


    }
}
