using InvoiceManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManager.Data.Repositories
{
    public interface IInvoiceAccountRepository
    {
        IEnumerable<InvoiceAccount> InvoiceAccounts { get; }
        void AddInvoiceAccount(InvoiceAccount entity);
        void UpdateInvoiceAccount(InvoiceAccount entity);
        void DeleteInvoiceAccount(InvoiceAccount entity);

    }
}
