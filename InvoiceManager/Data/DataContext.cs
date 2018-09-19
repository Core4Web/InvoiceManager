using InvoiceManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManager.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts): base(opts) { }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
