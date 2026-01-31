🍽️ Restaurant Ordering System (C# Console App)

A C# console application for managing restaurant menu items and customer orders.
The project follows a layered architecture separating presentation, business logic, and core models.

📌 Features
📋 Menu Management

View all menu items

Add new menu items

Edit existing menu items

Remove menu items

📦 Order Management

View all orders

Add new orders

Remove orders

Get orders by:

Specific date

Date range

Price range

⚙️ System

Interactive console menu

Asynchronous operations (async/await)

Clean and user-friendly CLI interface

🧱 Project Architecture

The solution is structured into multiple layers:

RestaurantSolution
│

├── Restaurantt.PL
# Presentation Layer (Console UI)

├── Resataraunt.BLL
# Business Logic Layer (Services)

├── Restaurant.Core 
# Core Models (Entities)

Layer Responsibilities

PL (Presentation Layer)
Handles user input/output and menu navigation.

BLL (Business Logic Layer)
Contains services like MenuItemService and OrderService.

Core
Defines models such as MenuItem, Order, etc.

🛠️ Technologies Used

C#

.NET (Console Application)

Async/Await

Object-Oriented Programming (OOP)

▶️ How to Run the Project

Clone the repository:

git clone https://github.com/your-username/restaurant-ordering-system.git


Open the solution in Visual Studio

Make sure Restaurantt.PL is set as the Startup Project

Right-click Restaurantt.PL

Select Set as Startup Project

Run the application:

Press F5 or Ctrl + F5

📸 Sample Console Menu
╔════════════════════════════════════════╗
║  Restaurant Ordering System - Main Menu║
╚════════════════════════════════════════╝

📋 Menu Items Management:
  1. View All Menu Items
  2. Add New Menu Item
  3. Edit Menu Item
  4. Remove Menu Item

📦 Orders Management:
  5. View All Orders
  6. Add New Order
  7. Remove Order
  8. Get Orders by Date
  9. Get Orders by Date Range
  10. Get Orders by Price Range

⚙️ System:
  0. Exit

🚀 Future Improvements

Database integration (SQL Server / SQLite)

Dependency Injection

Logging

Unit testing

Authentication & roles

ASP.NET Web API version

👤 Author

Your Name
GitHub: https://github.com/adalatar

📄 License

This project is for educational purposes.
