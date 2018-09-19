using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceManager.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceManager.Controllers
{
    public class HomeController : Controller
    {
        private IInvoiceRepository _invoiceRepo;
        public HomeController(IInvoiceRepository invoiceRepo)
        {
            _invoiceRepo = invoiceRepo;
        }
        public IActionResult Index() => View(_invoiceRepo.Invoices);
    }
}