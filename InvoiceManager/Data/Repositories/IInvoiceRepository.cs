using InvoiceManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManager.Data.Repositories
{
    public interface IInvoiceRepository
    {
        IEnumerable<Invoice> Invoices { get; }
        void AddInvoice(Invoice invoice);
    }
}
