using LMSDataModels.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataModels.DomainModels
{

 


    public class Department : IEntity, IMapToDTO<DepartmentDTO>
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;


        public DepartmentDTO toDTO()
        {
            return new DepartmentDTO
            { 
              ID = this.ID, 
              Name = this.Name, 
              Description = this.Description
            };

        }
    }
}
