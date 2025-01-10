# BillSplitter  

**BillSplitter** is a .NET-based desktop application designed to simplify bill management and splitting among users. The application leverages a well-structured architecture with a focus on user management and efficient bill calculations.  

## Features  
- **Bill Calculation**: Splits bills accurately among multiple users.  
- **User Management**: Add, update, and manage user details through an intuitive interface.  
- **Database Integration**: Uses Entity Framework Core for managing user and bill data.  
- **User-Friendly Interface**: Simple and effective forms for seamless interaction.  

## Technologies Used  
- **Framework**: .NET (WinForms)  
- **Language**: C#  
- **Database**: Entity Framework Core with SQLite  
- **IDE**: Visual Studio  

## Project Structure  
- **Dependencies**: Required packages for the application.  
- **Migrations**: Entity Framework migrations for database setup:  
  - `InitialCreate.cs`: Sets up the initial database structure.  
  - `ApplicationDbContextModelSnapshot.cs`: Keeps track of the current database model.  
- **Models**: Contains `ApplicationDbContext.cs` for database context configuration.  
- **Services**: Includes `EmployeesService.cs` for business logic related to employees.  
- **Forms**:  
  - `BillCalculator`: Handles bill splitting calculations.  
  - `Form1`: The main application form, acting as the entry point.  
  - `Users`: Manages user-related operations.  
- **GlobalUsings.cs**: Centralized namespace imports for cleaner code.  
- **Program.cs**: Application entry point.  

## How to Run  
1. Clone the repository to your local machine.  
2. Open the solution file in Visual Studio.  
3. Restore NuGet packages and ensure all dependencies are installed.  
4. Apply migrations to set up the database:  
   ```bash
   Update-Database
