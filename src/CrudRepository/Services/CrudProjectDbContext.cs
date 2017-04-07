using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudRepository.Models;

namespace CrudRepository.Services
{
    public class CrudProjectDbContext : DbContext
    {
        public DbSet<Category> TblCategory { get; set; }


        //COnfigure Connection string
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=CrudProjectDB; Trusted_Connection=True");
        }

    }
}
