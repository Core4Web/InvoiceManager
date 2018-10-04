using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceManager.Data.Repositories;
using InvoiceManager.Models;
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
        public IActionResult Index()
        {
            return View(_invoiceRepo.GetAllInvoices());
        }

        public IActionResult AddInvoice() => View();

        [HttpPost]
        public IActionResult AddInvoice(Invoice model)
        {
            _invoiceRepo.AddInvoice(model);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult UpdateInvoice(int key) => View(_invoiceRepo.GetInvoice(key));

        [HttpPost]
        public IActionResult UpdateInvoice(Invoice model)
        {
            _invoiceRepo.UpdateInvoice(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult DeleteInvoice(Invoice model)
        {
            _invoiceRepo.DeleteInvoice(model);
            return RedirectToAction(nameof(Index));
        }
    }
}