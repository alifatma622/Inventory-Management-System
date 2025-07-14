using InventoryManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Admin_Controls
{
    public partial class Dashbord : UserControl
    {
        public Dashbord()
        {
            InitializeComponent();
            LoadDashboardData();
        }
        private void LoadDashboardData()
        {
            using (var db = new InventoryDbContext())
            {
                // Get total purchases
                var totalPurchases = db.StockTransactions
                    .Where(t => t.TransactionType == "Purchase")
                    .Sum(t => t.Quantity);

                // Get total inventory (count of products)
                var totalInventory = db.Products.Count();

                // Get total sales amount
                var totalSales = db.Sales.Sum(s => s.TotalPrice);

                // Get total profit (sales revenue - purchase cost)
                var totalProfit = totalSales - db.StockTransactions
                    .Where(t => t.TransactionType == "Purchase")
                    .Sum(t => t.Quantity * t.Product.Price);

                // Get total number of sale orders
                var saleOrdersCount = db.Sales.Count();

                // Get total number of purchase orders
                var purchaseOrdersCount = db.StockTransactions
                    .Where(t => t.TransactionType == "Purchase")
                    .Count();

                // Get total number of suppliers
                var suppliersCount = db.Suppliers.Count();

                // Get total number of customers
                var customersCount = db.Users.Count();

                // New Features

                // 1️⃣ Total Stock Movements (All transactions)
                int stockMovements = db.StockTransactions.Count();

                // 2️⃣ Low Stock Alerts (Products with low stock)
                int lowStockCount = db.Products.Count(p => p.StockQuantity < 10);

                // 3️⃣ Best-Selling Products (Top product sales)
                var bestSellingProduct = db.Sales
                    .GroupBy(s => s.ProductId)
                    .OrderByDescending(g => g.Sum(s => s.Quantity))
                    .Select(g => db.Products
                        .Where(p => p.Id == g.Key)
                        .Select(p => p.Name)
                        .FirstOrDefault())
                    .FirstOrDefault() ?? "N/A";

                // 4️⃣ Recent Transactions (Last transaction date)
                var lastTransaction = db.StockTransactions
                    .OrderByDescending(t => t.TransactionDate)
                    .Select(t => t.TransactionDate)
                    .FirstOrDefault();

                // Update UI Labels
                lblsalesValue.Text = totalSales.ToString("N2");
                label.Text = totalPurchases.ToString();
                inventory_hrad.Text = totalInventory.ToString();
                lblProfitValue.Text = totalProfit.ToString("N2");
                lblSaleOrdersValue.Text = saleOrdersCount.ToString();
                lblPurchaseOrdersValue.Text = purchaseOrdersCount.ToString();
                lblSuppliersValue.Text = suppliersCount.ToString();
                lblCustomersValue.Text = customersCount.ToString();

                // Update New UI Labels
                lblStockMovementsValue.Text = stockMovements.ToString();
                lblLowStockValue.Text = lowStockCount.ToString();
                lblBestSellingProductValue.Text = bestSellingProduct;
                lblLastTransactionDate.Text = lastTransaction != default(DateTime) ? lastTransaction.ToString("yyyy-MM-dd") : "N/A";
            }
        }


    }
}
