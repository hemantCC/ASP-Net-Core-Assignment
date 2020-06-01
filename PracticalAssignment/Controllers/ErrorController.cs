using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PracticalAssignment.Controllers
{

    /// <summary>
    /// Custom Error Handling (For Practice added in Develpment mode)
    /// </summary>
    public class ErrorController : Controller
    {
        [Route("Error")]
        public IActionResult Error()
        {
            //Retrive Exception Details
            var ExceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            ViewBag.ExceptionPath = ExceptionDetails.Path;
            ViewBag.ExceptionMessage = ExceptionDetails.Error.Message;
            ViewBag.StackTrace = ExceptionDetails.Error.StackTrace;

            return View();
        }
    }
}