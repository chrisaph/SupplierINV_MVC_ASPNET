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

```
Controllers/
Models/
Views/
Repositories/
Migrations/
```

## Screenshots

### Login

![Login](screenshots/login.png)

### Register

![Register](screenshots/register.png)

### Supplier Management

![Supplier Management](screenshots/suppliers.png)

### Product Management

![Product Management](screenshots/products.png)

## Getting Started

### Prerequisites

- Visual Studio 2022
- SQL Server
- .NET SDK (compatible with the project)

### Installation

1. Clone the repository.

```bash
git clone https://github.com/your-username/SupplierINV_MVC_ASPNET.git
```

2. Open the solution in Visual Studio 2022.

3. Update the SQL Server connection string in `appsettings.json`.

4. Open **Tools → NuGet Package Manager → Package Manager Console**.

5. Apply the database migrations.

If migrations already exist, run:

```powershell
Update-Database
```

If this is the first time setting up the database and no migrations exist, run:

```powershell
Add-Migration InitialCreate
Update-Database
```

6. Press **F5** or click **Start** to run the application.

## License

This project is licensed under the MIT License.
