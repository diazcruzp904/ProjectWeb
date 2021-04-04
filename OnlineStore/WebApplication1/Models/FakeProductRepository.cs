using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Product => new List<Product>
        {
            new Product { Name = "POP Tart Cherry", Price = 25},
            new Product { Name = "POP Tart Chocolate", Price = 179},
            new Product { Name = "POP Tart BlueBerry", Price = 95},
        };
    }
}
