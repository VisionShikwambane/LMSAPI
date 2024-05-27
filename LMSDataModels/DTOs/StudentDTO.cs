using LMSDataModels.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataModels.DTOs
{
    public class StudentDTO : IMapToDomain<Student>
    {
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;


       

        public Student toDomain()
        {
            return new Student
            {
                ID = this.ID,
                Name = this.Name,
                Surname = this.Surname,
                Title = this.Title
            };
        }
    }
}
