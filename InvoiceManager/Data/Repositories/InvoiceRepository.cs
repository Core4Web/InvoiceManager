using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceManager.Models;

namespace InvoiceManager.Data.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private AppDBContext _context;

        public InvoiceRepository(AppDBContext dataContext) => _context = dataContext;

        public IEnumerable<Invoice> Invoices => _context.Invoices.ToArray();

        public Invoice GetInvoice(int key) => _context.Invoices.Find(key);

        public void AddInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }

        public void UpdateInvoice(Invoice invoice)
        {
            var entity =GetInvoice(invoice.Id);
            entity.Number = invoice.Number;
            entity.Note = invoice.Note;
            entity.Sum=invoice.Sum;
            //_context.Invoices.Update(invoice);
            _context.SaveChanges();
        }

        public void UpdateAll(Invoice[] invoices)
        {
            int[] keys = invoices.Select(x => x.Id).ToArray();
            IEnumerable<Invoice> entities = _context.Invoices
                .Where(x => keys.Contains(x.Id));
            foreach (var entity in entities)
            {
                var invoice = invoices.Single(x => x.Id == entity.Id);
                entity.Number = invoice.Number;
                entity.Note = invoice.Note;
                entity.Sum = invoice.Sum;
            }
            _context.SaveChanges();
        }

        public void DeleteInvoice(Invoice invoice)
        {
            _context.Invoices.Remove(invoice);
            _context.SaveChanges();
        }
    }
}
