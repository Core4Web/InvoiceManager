using InvoiceManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManager.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> opts): base(opts) { }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceAccount> InvoiceAccounts { get; set; }
        public DbSet<Period> Periods { get; set; }
    }
}
