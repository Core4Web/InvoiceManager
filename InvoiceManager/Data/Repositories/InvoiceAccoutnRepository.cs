using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceManager.Models;

namespace InvoiceManager.Data.Repositories
{
    public class InvoiceAccountRepository : IInvoiceAccountRepository
    {
        private AppDBContext _context;

        public InvoiceAccountRepository(AppDBContext dataContext) => _context = dataContext;

        public IEnumerable<InvoiceAccount> InvoiceAccounts => _context.InvoiceAccounts.ToArray();


        public void AddInvoiceAccount(InvoiceAccount entity)
        {
            _context.InvoiceAccounts.Add(entity);
            _context.SaveChanges();
        }

        public void UpdateInvoiceAccount(InvoiceAccount entity)
        {
            _context.InvoiceAccounts.Update(entity);
            _context.SaveChanges();
        }

        public void DeleteInvoiceAccount(InvoiceAccount entity)
        {
            _context.InvoiceAccounts.Remove(entity);
            _context.SaveChanges();
        }
    }
}
