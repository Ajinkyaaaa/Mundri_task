

---

# MundriSolutions Task

## Overview

This repository contains the code for an employee management system using the MVC pattern with .NET 8, EF Core, Razor Pages, and Bootstrap. Authentication and authorization are handled through the Identity module.

## Technologies Used

### Backend

- **.NET 8**: The main framework for building the application.
- **EF Core**: Used for database operations.

### Frontend

- **Razor Pages**: For building dynamic web pages.
- **Bootstrap**: For responsive and modern UI design.

### Authentication and Authorization

- **Identity Module**: Used to handle authentication and authorization.

## Project Structure

```plaintext
MundriSolutions/
├── Controllers/
│   ├── HomeController.cs
│   ├── EmployeeController.cs
│   └── ...
├── Models/
│   ├── Employee.cs
│   ├── ApplicationDbContext.cs
│   └── ...
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   ├── Employee/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   └── ...
│   └── Shared/
│       └── _Layout.cshtml
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── ...
├── Program.cs
├── Startup.cs
└── ...
```

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/MundriSolutions.git
   cd MundriSolutions
   ```

2. **Configure the database:**

   Update the `appsettings.json` file with your SQL Server connection string:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
     }
   }
   ```

3. **Apply Migrations:**
   ```bash
   dotnet ef database update
   ```

4. **Run the application:**
   ```bash
   dotnet run
   ```

5. **Open the application:**

   Navigate to `https://localhost:5001` in your web browser.

## Usage

- **Home Page:** Provides an overview of the application.
- **Employee Management:**
  - **List Employees:** View all employees.
  - **Create Employee:** Add a new employee.
  - **Edit Employee:** Update existing employee details.
  - **Delete Employee:** Remove an employee.

### Authentication and Authorization

- **Registration and Login:** Users can register and log in to access the system.
- **Role Management:** Assign roles to users to control access to different parts of the application.

## Contributing

1. **Fork the repository.**
2. **Create a feature branch:**
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. **Commit your changes:**
   ```bash
   git commit -m 'Add some feature'
   ```
4. **Push to the branch:**
   ```bash
   git push origin feature/your-feature-name
   ```
5. **Open a pull request.**

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements

- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core)
- [Bootstrap Documentation](https://getbootstrap.com/docs/5.0/getting-started/introduction/)

---

Feel free to adjust any details as needed.
