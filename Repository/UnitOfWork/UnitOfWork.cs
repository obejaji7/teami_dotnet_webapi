

using Repository.Base;
using Repository.Product;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private RepositoryContext _context;
        private IProductRepository _product;

        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(this._context);
                }

                return _product;
            }
        }

        public UnitOfWork(RepositoryContext context)
        {
            this._context = context;
        }

        public void Save()
        {
             this._context.SaveChanges();
        }
    }
}
