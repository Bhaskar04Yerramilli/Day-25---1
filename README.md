# SecureShopApp

A secure ASP.NET Core MVC web application developed for implementing secure coding practices such as authentication, authorization, input validation, SQL Injection prevention, and Cross-Site Scripting (XSS) protection.

---

# Project Objective

The objective of this project is to build a secure online shopping platform using ASP.NET Core MVC while following secure development practices.

The application allows users to:

* Register and log in securely
* View product listings
* Access admin dashboard based on roles
* Prevent common web vulnerabilities

---

# Technologies Used

* ASP.NET Core MVC
* Entity Framework Core
* SQL Server LocalDB
* ASP.NET Core Identity
* C#
* Razor Views

---

# Features Implemented

## User Authentication

* User Registration
* User Login
* Secure Logout
* Password Hashing and Salting using ASP.NET Identity

---

## Role-Based Authorization

Two roles are implemented:

* Admin
* Customer

### Access Rules

| Role     | Access          |
| -------- | --------------- |
| Admin    | Admin Dashboard |
| Customer | Product Listing |

Unauthorized users are restricted from accessing admin pages.

---

# Security Features

## Input Validation

Implemented using Data Annotations:

* Required fields
* Email validation
* Password validation
* String length restrictions

Example:

```csharp
[Required]
[StringLength(100)]
public string Name { get; set; }
```

---

## Strong Password Policy

Password rules enforced:

* Minimum 8 characters
* At least one uppercase letter
* At least one number
* At least one special character

---

## SQL Injection Prevention

Entity Framework Core and LINQ queries are used instead of dynamic SQL queries.

This prevents direct SQL Injection attacks through parameterized queries.

Example:

```csharp
var products = _context.Products.ToList();
```

---

## Cross-Site Scripting (XSS) Prevention

Razor Views automatically encode user-generated content before rendering.

Example:

```html
@item.Description
```

This prevents malicious JavaScript execution.

---

# Database

The application uses:

* SQL Server LocalDB
* Entity Framework Core Migrations

Tables created:

* AspNetUsers
* AspNetRoles
* AspNetUserRoles
* Products

---

# Project Structure

```text
SecureShopApp
│
├── Controllers
│   ├── ProductController.cs
│   ├── AdminController.cs
│   └── RoleController.cs
│
├── Models
│   └── Product.cs
│
├── Data
│   └── ApplicationDbContext.cs
│
├── Views
│   ├── Product
│   └── Admin
│
├── Program.cs
│
└── appsettings.json
```

---

# How to Run the Project

## Step 1

Clone the repository:

```bash
git clone <repository-url>
```

---

## Step 2

Open the project in Visual Studio 2026.

---

## Step 3

Open Package Manager Console and run:

```powershell
Add-Migration InitialCreate
Update-Database
```

---

## Step 4

Run the project using:

```text
F5
```

---

# Testing

## Registration Testing

* Weak passwords are rejected
* Valid users can register successfully

---

## Authorization Testing

* Customers cannot access Admin Dashboard
* Only Admin users can access restricted routes

---

## Product Page

Accessible at:

```text
/Product
```

---

# Admin Dashboard

Accessible at:

```text
/Admin/Dashboard
```

Only Admin role users can access this page.

---

# Learning Outcomes

Through this assignment, the following concepts were implemented and understood:

* ASP.NET Core MVC Architecture
* Entity Framework Core
* Authentication and Authorization
* Secure Password Policies
* SQL Injection Prevention
* XSS Prevention
* Role-Based Security
* Dependency Injection

---

# Conclusion

This project demonstrates how secure coding practices can be implemented in ASP.NET Core MVC applications using built-in security features such as Identity Framework, Entity Framework Core, and Razor View Encoding.
