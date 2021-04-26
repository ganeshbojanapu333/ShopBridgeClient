using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ShopBridgeClient.Controllers
{
    public class ErrorController : Controller
    {
        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            // Retrieve the exception Details
            var exceptionHandlerPathFeature =
                    HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            string path = @"C:\Users\ganeshkumar\Error.txt";  // file path
            using (StreamWriter sw = new StreamWriter(path, true))
            { // If file exists, text will be appended ; otherwise a new file will be created
                sw.Write(exceptionHandlerPathFeature.Error.Message);
                sw.Write(exceptionHandlerPathFeature.Error.StackTrace);
            }
            return View("Error");
        }
    }
}