using InvoiceManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManager.Data.Repositories
{
    public interface IInvoiceRepository
    {
        IEnumerable<Invoice> GetAllInvoices();
        Invoice GetInvoice(int key);
        void AddInvoice(Invoice invoice);
        void UpdateInvoice(Invoice invoice);
        void UpdateAll(Invoice[] invoices);
        void DeleteInvoice(Invoice invoice);
    }
}
