using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceManager.Models;

namespace InvoiceManager.Data.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private DataContext _context;

        public InvoiceRepository(DataContext dataContext) => _context = dataContext;

        public IEnumerable<Invoice> Invoices => _context.Invoices;

        public void AddInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }
    }
}
