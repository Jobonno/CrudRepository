using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudRepository.Models
{
    public class Category
    {
        public int CategoryId { get; set; } //PK (ObjectIdentifier)
        public string Name { get; set; }
        public string Description { get; set; }


    }
}
