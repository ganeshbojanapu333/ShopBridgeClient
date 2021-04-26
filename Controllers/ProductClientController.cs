//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using ShopBridgeClient.Models;
//using ShopBridgeClient.Models.Repositories;

//namespace ShopBridgeClient.Controllers
//{
//    public class ProductClientController : Controller
//    {
//        private readonly IClientProductRepo ClientProductRepo;

//        public ProductClientController(IClientProductRepo _ClientProductRepo)
//        {
//            ClientProductRepo = _ClientProductRepo;
//        }

//        public async Task<IActionResult> Index()
//        {
//            return await GetProductsList();
//        }

//        public async Task<IActionResult> GetProductsList()
//        {
//            List<ProductViewModel> ViewModel = new List<ProductViewModel>();

//            ViewData["PageTitle"] = "Products List";

//            ViewModel = await ClientProductRepo.GetProductsList();

//            return View("ProductsList", ViewModel);
//        }

//        public async Task<IActionResult> ProductDetails(int? id)
//        {
//            ProductViewModel ViewModel = new ProductViewModel();

//            if (id.HasValue)
//            {
//                ViewModel = await ClientProductRepo.GetProductDetails(id.Value);
//            }

//            return View("ProductDetails", ViewModel);
//        }

//        public async Task<IActionResult> DeleteProduct(int? id)
//        {
//            var Result = await ClientProductRepo.DeleteProduct(id.Value);
//            Result = await ClientProductRepo.GetProductsList();
//            return Json(Result);
//        }


//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> GetProductsList(ProductViewModel Params)
//        {
//            var productsList = await ClientProductRepo.GetProductsList();
//            return new JsonResult(productsList);
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> SaveDetails(ProductViewModel Params)
//        {
//            var Result = await ClientProductRepo.AddModifyAllergyDetails(Params);

//            Result = await ClientProductRepo.GetProductsList();

//            var finalResult = new JsonResult(Result);

//            return finalResult;
//        }
//    }
//}