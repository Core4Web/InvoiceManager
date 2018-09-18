using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceManager.Models;

namespace InvoiceManager.Data.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private List<Invoice> data = new List<Invoice>();

        public IEnumerable<Invoice> Invoices => data;

        public void AddInvoice(Invoice invoice)
        {
            data.Add(invoice);
        }
    }
}
