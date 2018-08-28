using Microsoft.ServiceFabric.Services.Remoting;
using Microsoft.ServiceFabric.Services.Remoting.FabricTransport;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.ProductCatalog.Model
{
    public interface IProductCatalogService : IService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task AddProduct(Product Product);
        Task<Product> GetProduct(Guid productId);
    }
}
