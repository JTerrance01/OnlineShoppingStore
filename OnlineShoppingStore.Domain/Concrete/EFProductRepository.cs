using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {

        private readonly EFDbContext context = new EFDbContext();

        //Return a list of PRODUCTS from the Database...
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
