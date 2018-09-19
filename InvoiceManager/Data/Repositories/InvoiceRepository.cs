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

        public Invoice GetInvoice(int key) => _context.Invoices.Find(key);

        public void AddInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }

        public void UpdateInvoice(Invoice invoice)
        {
            _context.Invoices.Update(invoice);
            _context.SaveChanges();
        }
    }
}
