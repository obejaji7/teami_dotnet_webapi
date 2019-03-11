using Repository.Product;

namespace Repository.Base
{
    class ProductRepository : RepositoryBase<Entities.Models.Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
