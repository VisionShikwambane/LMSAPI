using LMSDataModels.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataModels.DomainModels
{
    public class Student : IEntity, IMapToDTO<StudentDTO>
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;

       public StudentDTO toDTO()
        {
            return new StudentDTO
            {
                ID = this.ID,
                Name = this.Name,
                Surname = this.Surname,
                Title = this.Title

            };
        }
    }
}
