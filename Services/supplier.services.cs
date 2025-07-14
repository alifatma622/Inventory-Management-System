using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagementSystem.Services
{
    class SupplierService
    {
        private readonly InventoryDbContext context;

        public SupplierService()
        {
            context = new InventoryDbContext();
        }

        public Supplier getSupplierByID(int id)
        {
            return context.Suppliers.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public List<Supplier> getAllSuppliers()
        {
            return context.Suppliers.AsNoTracking().ToList();
        }

        public void addSupplier(Supplier supplier)
        {
            context.Suppliers.Add(supplier);
            context.SaveChanges();
        }

        public void updateSupplier(Supplier supplier)
        {
            var existingSupplier = context.Suppliers.Find(supplier.Id);
            if (existingSupplier != null)
            {
                existingSupplier.Name = supplier.Name;
                existingSupplier.ContactInfo = supplier.ContactInfo;
                existingSupplier.Address = supplier.Address;
                context.SaveChanges();
            }
        }

        public void deleteSupplier(int supplierId)
        {
            var supplier = context.Suppliers.Find(supplierId);
            if (supplier != null)
            {
                context.Suppliers.Remove(supplier);
                context.SaveChanges();
            }
        }
    }
}
