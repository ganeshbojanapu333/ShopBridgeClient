using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeClient.Models.Repositories
{
    public interface IClientProductRepo
    {
        Task<List<ProductViewModel>> GetProductsList();
        Task<ProductViewModel> GetProductDetails(int id);
        Task<List<string>> AddModifyProductDetails(ProductViewModel Params);
        Task<List<string>> DeleteProduct(int id);
    }
}
