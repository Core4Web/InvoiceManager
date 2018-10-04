using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace InvoiceManager.Controllers
{
    public class InvoiceAccountController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
