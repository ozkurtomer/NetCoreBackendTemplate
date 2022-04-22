using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreBackendTemplate.Entities.Classes
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public int Product_CategoryId { get; set; }
        public decimal Product_Price { get; set; }
    }
}
