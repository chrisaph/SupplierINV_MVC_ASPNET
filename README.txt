Entity Framework Code First

Open Package Manager Console and run:

Update-Database

If there are no migrations yet, you may need:

Add-Migration InitialCreate
Update-Database


# SupplierINV_MVC_ASPNET

A simple ASP.NET Core MVC web application for managing suppliers and products. This project demonstrates CRUD operations, user authentication, and database integration using Entity Framework Core.

## Features

- User Registration and Login
- Supplier Management (Create, Read, Update, Delete)
- Product Management (Create, Read, Update, Delete)
- Searchable and sortable data tables
- Delete confirmation dialog
- Responsive Bootstrap interface
- Entity Framework Core with SQL Server

## Technologies Used

- ASP.NET Core MVC
- C#
- Entity Framework Core
- SQL Server
- Bootstrap
- jQuery
- DataTables
- SweetAlert2

## Project Structure

- Controllers
- Models
- Views
- Repository Pattern
- Entity Framework Migrations

## Screenshots

### Login
![Login](screenshots/login.png)

### Register
![Register](screenshots/register.png)

### Supplier Management
![Supplier](screenshots/suppliers.png)

### Product Management
![Product](screenshots/products.png)

## Getting Started

1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Update the SQL Server connection string in `appsettings.json`.
4. Apply the database migrations.
5. Run the application.

## License

MIT License
