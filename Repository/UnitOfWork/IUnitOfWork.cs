using Repository.Product;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
     public interface IUnitOfWork
    {
        IProductRepository Product { get; }

        void Save();
    }
}
