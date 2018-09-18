using System;
using System.Collections.Generic;
namespace InvoiceManager.Models {
    public class Invoice
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}