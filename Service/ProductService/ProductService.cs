using Entities.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _repository;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _repository = unitOfWork;

            if (_repository.Product.GetAll().Count() == 0)
            {
                using (System.IO.StreamReader file = System.IO.File.OpenText(@"./mock-data/products.json"))
                using (JsonTextReader reader = new JsonTextReader(file))
                {

                    JArray productArray = (JArray)JToken.ReadFrom(reader);

                    foreach (var product in productArray)
                    {
                        Add(new Product { Name = product["name"].ToString(), Brand = product["brand"].ToString(), Categories = string.Join(',', product["categories"]), Description = product["description"].ToString(), Photo = product["photo"].ToString(), Price = product["price"].ToString(), Stock = product["stock"].ToString() });
                    }
                    _repository.Save();
                }
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.Product.GetAll();
        }

        public Product GetById(Guid id)
        {
            return _repository.Product.GetBy(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Product> GetByCategory(string category)
        {
            return _repository.Product.GetBy(p => p.Categories.Contains(category));
        }

        public void Add(Product product)
        {
            _repository.Product.Add(product);
        }

        public void Save()
        {
            _repository.Save();
        }
    }
}
