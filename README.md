# Inventory Management System

## Table of Contents
1. [Project Overview](#project-overview)
2. [Project Structure](#project-structure)
3. [Use Cases](#use-cases)
4. [Database Design](#database-design)
5. [Entity Classes](#entity-classes)
6. [Services & Business Logic](#services--business-logic)
7. [UI Components](#ui-components)
8. [Conclusion](#conclusion)

---

## 1. Project Overview
The Inventory Management System is designed to streamline the process of managing stock, tracking sales, and handling supplier relationships efficiently. This system ensures that businesses can maintain accurate inventory records, reduce errors, and optimize resource allocation.

- **Code-First Approach:** Database structures are defined using entity classes before generating the database.
- **Modular Architecture:** Separate layers for database management, business logic, and user interface, making it scalable and maintainable.

### Key Features
- **User Authentication & Role Management:** Admins, Managers, and Staff have access to specific functionalities based on their roles.
- **Inventory Tracking:** Real-time records of stock levels, product details, and supplier information.
- **Sales Management:** Smooth sales transactions with automatic stock updates.
- **Supplier Management:** Seamless interaction with suppliers for stock replenishment.
- **Transaction Logging:** Records of stock inflows and outflows for audit purposes.
- **User-Friendly Interface:** Intuitive UI for administrators and employees.

This system is ideal for businesses seeking a structured, automated, and efficient way to manage inventory operations while ensuring data accuracy and security.

---

## 2. Project Structure
The project is organized into the following main folders:
- **Data/** – Contains `DbContext` for database management.
- **Migrations/** – Contains migration history for database schema changes.
- **Models/** – Entity classes representing database tables.
- **Services/** – Business logic for inventory operations.
- **UI/** – Main form, welcome, signup, and login forms.
- **Admin_Controls/** – UI controls for the Admin main form.

---

## 3. Use Cases
- **Login:** Authenticate users into the system
- **SignUp:** Register a new user account
- **Manage Users:** (Admin Only) Add, edit, or remove users
- **Manage Products:** (Admin & Manager) Add, edit, or delete products
- **Measure Stock:** (Admin, Manager & Staff) Check and manage stock levels
- **Assign Supplier:** (Admin & Manager) Assign new suppliers
- **Supply Products:** (Supplier) Provide products to the system
- **Generate Reports:** (Admin & Manager) Create stock and sales reports
- **Manage Sales:** (Admin, Manager & Staff) Handle sales transactions

---

## 4. Database Design
The project uses the Code-First approach to define entity relationships. Entity classes are used to create the database schema.

---

## 5. Entity Classes

### User
```csharp
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Role { get; set; } // Admin, Manager, Staff
    public virtual List<Sale> Sales { get; set; } = new List<Sale>();
}
```

### Supplier
```csharp
public class Supplier
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ContactInfo { get; set; }
    public string Address { get; set; }
    public virtual List<Product> Products { get; set; } = new List<Product>();
}
```

### StockTransaction
```csharp
public class StockTransaction
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public string TransactionType { get; set; } // IN, OUT
    public DateTime TransactionDate { get; set; }
    public virtual Product Product { get; set; }
}
```

### Sale
```csharp
public class Sale
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public string CustomerName { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime SaleDate { get; set; }
    public virtual Product Product { get; set; }
    public virtual User User { get; set; }
}
```

### Product
```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public int SupplierId { get; set; }
    public virtual Supplier Supplier { get; set; } = new Supplier();
    public virtual List<Sale> Sales { get; set; } = new List<Sale>();
    public virtual List<StockTransaction> StockTransactions { get; set; } = new List<StockTransaction>();
}
```

---

## 6. Services & Business Logic
Business logic is implemented in service classes that handle CRUD operations and enforce business rules for inventory management.

### User Authentication & Role Management
- Supports Admin, Manager, and Staff roles with different access levels.
- Uses secure password hashing for authentication.
- Grants role-based access to dashboards.

### Inventory Management
- Admins/Managers can add, update, and delete products.
- System checks stock levels before processing sales.
- Sends low-stock alerts for timely restocking.
- Links products to suppliers for tracking.

### Sales Processing & Revenue Calculation
- Only authorized users can process sales.
- Automatically updates stock levels after a sale.
- Calculates total price based on product quantity.
- Logs all transactions for auditing.

### Supplier Management & Procurement
- Admins manage supplier details.
- Managers request stock replenishments.
- Tracks supplier-product associations.

### Stock Transactions (Inbound & Outbound)
- Logs stock additions (IN) and sales usage (OUT).
- Maintains transaction history for transparency.

### Reporting & Data Analytics
- Generates sales, inventory, and supplier reports.
- Provides insights for decision-making.

### Security & Data Integrity
- Implements role-based access control.
- Ensures data validation and error handling.
- Logs key system operations for auditing.

---

## 7. UI Components
- **Admin Control Forms:** Manage users, products, suppliers, and reports.
- **User Forms:** Allow staff to handle stock, sales, and inventory tracking.

---

## 8. Conclusion
The Inventory Management System is an essential tool for modern businesses, enabling efficient stock tracking, secure user role management, streamlined sales processing, and effective supplier coordination. By leveraging automation and structured workflows, the system enhances productivity, reduces human error, and ensures a seamless inventory management experience. With its scalability, security, and real-time data accuracy, the system is well-equipped to support businesses of all sizes, providing a robust foundation for sustainable growth and long-term success.
