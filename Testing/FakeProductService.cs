using Entities.Models;
using Service.ProductService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class FakeProductService : IProductService
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return new List<Product>() {
                new Product() {
                    Id =  new Guid("aeed54ce-36d8-42f6-8055-4c648c3bd4a1"),
                    Name= "Generic Concrete Computer",
                    Description= "Voluptas vel numquam culpa aut non qui aliquam ut. Sequi corrupti ducimus ex officiis aperiam. Aspernatur ea nobis sit.",
                    Price= "275.00",
                    Brand= "Hirthe - Pacocha",
                    Stock= "47905",
                    Photo= "http=//lorempixel.com/640/480/nature",
                    Categories= "Tech, Services"
                }
            };

        }

        public IEnumerable<Product> GetByCategory(string category)
        {
            return new List<Product>() {
                new Product() {
                    Id =  new Guid("aeed54ce-36d8-42f6-8055-4c648c3bd4a1"),
                    Name= "Generic Concrete Computer",
                    Description= "Voluptas vel numquam culpa aut non qui aliquam ut. Sequi corrupti ducimus ex officiis aperiam. Aspernatur ea nobis sit.",
                    Price= "275.00",
                    Brand= "Hirthe - Pacocha",
                    Stock= "47905",
                    Photo= "http=//lorempixel.com/640/480/nature",
                    Categories= "Tech, Services"
                }
            };
        }

        public Product GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
