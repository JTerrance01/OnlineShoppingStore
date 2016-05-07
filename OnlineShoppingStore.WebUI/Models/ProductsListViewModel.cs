using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShoppingStore.Domain.Entities;

namespace OnlineShoppingStore.WebUI.Models
{
    public class ProductsListViewModel
    {
        //List of Products
        public IEnumerable<Product> Products { get; set; }

        //PagingInfo model
        public PagingInfo PagingInfo { get; set; }
    }
}