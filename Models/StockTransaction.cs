using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class StockTransaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string TransactionType { get; set; } // IN , OUT
        public DateTime TransactionDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
