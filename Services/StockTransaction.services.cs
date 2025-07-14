using InventoryManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Data;
namespace InventoryManagementSystem.Services
{
    class StockTransactionService
    {
        InventoryDbContext context;
        public StockTransactionService()
        {
            context = new InventoryDbContext();
        }
        public StockTransaction getStockTransactionByID(int id)
        {
            return context.StockTransactions.FirstOrDefault(x => x.Id == id);
        }
        public List<StockTransaction> getAllStockTransactions()
        {
            return context.StockTransactions.ToList();
        }
        public void addStockTransaction(StockTransaction stockTransaction)
        {
            context.StockTransactions.Add(stockTransaction);
            context.SaveChanges();
        }
        public void updateStockTransaction(StockTransaction stockTransaction)
        {
            context.StockTransactions.Update(stockTransaction);
            context.SaveChanges();
        }
        public void deleteStockTransaction(StockTransaction stockTransaction)
        {
            context.StockTransactions.Remove(stockTransaction);
            context.SaveChanges();
        }

    }
}
