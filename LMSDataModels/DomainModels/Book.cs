using LMSDataModels.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataModels.DomainModels
{
    public class Book : IEntity, IMapToDTO<BookDTO>
    {
        public int ID { get; set; }

        public string Name { get; set; }  = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Aurthor { get; set; } = string.Empty;


        public BookDTO toDTO()
        {
            return new BookDTO
            {
                ID = this.ID,
                Name = this.Name,
                Author = this.Aurthor
            };

        }




    }
}
