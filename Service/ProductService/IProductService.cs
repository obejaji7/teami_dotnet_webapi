using Entities.Models;
using System;
using System.Collections.Generic;

namespace Service.ProductService
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();

        Product GetById(Guid id);

        IEnumerable<Product> GetByCategory(string category);

        void Add(Product product);
    }
}
