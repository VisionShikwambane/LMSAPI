using LMSDataModels.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataModels.DTOs
{
    public class BookDTO : IMapToDomain<Book>
    {
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;


        public Book toDomain()
        {
            return new Book
            {
                ID = this.ID,
                Name = this.Name,
                Title = this.Title,
                Aurthor = this.Author
               
            };
        }
    }
}
