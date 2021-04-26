//using ShopBridgeClient.Common;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Threading.Tasks;

//namespace ShopBridgeClient.Models.Repositories
//{
//    public class ClientProductRepo : IClientProductRepo
//    {
//        public Task<List<ProductViewModel>> AddModifyProductDetails(ProductViewModel Params)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<List<ProductViewModel>> DeleteProduct(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<List<ProductViewModel>> GetProductsList()
//        {
//            List<ProductViewModel> Response = new List<ProductViewModel>();

//            try
//            {
//                //var resultData = await careSupportApiClient
//                //    .GetAsync<ResultData<List<ProductViewModel>>>(APIRoutes._C_GetAllergiesList);

//                //var ProductsList = resultData.result;

//                //if (resultData.status.ToString().ToLower().In("1", "success"))
//                //{
//                //    Response = (from i in ProductsList
//                //                orderby i.prod, i.Description
//                //                select new ProductViewModel()
//                //                {
//                //                    AgencyID = i.AgencyID,
//                //                    AllergyID = i.AllergyID,
//                //                    AllergyClassId = i.AllergyClassId,
//                //                    AllergyType = i.AllergyType.GetValueByShortName<AllergyType>(),
//                //                    Description = i.Description,
//                //                    ProviderID = i.ProviderID,
//                //                    Status = i.Status,
//                //                    CUSTOMSTRING_1 = i.Status == 1 ? "Active" : "In Active",
//                //                }).ToList();
//                //}
//            }
//            catch (Exception ex)
//            {
//                //_logger.LogError(ex.ToString());
//            }

//            return Response;
//        }

//        public Task<ProductViewModel> GetProductDetails(int id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
