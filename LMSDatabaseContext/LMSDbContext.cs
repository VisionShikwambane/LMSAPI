using LMSDataModels.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDatabaseContext
{
    public class LMSDbContext : DbContext
    {

        public LMSDbContext()
        {
        }

        public LMSDbContext(DbContextOptions<LMSDbContext> options)

            : base(options)
        {
        }

        public  DbSet<Student> Students { get; set; }

        public  DbSet<Department> Departments { get; set; }

        public DbSet<Book> Books { get; set; }


    }
}
