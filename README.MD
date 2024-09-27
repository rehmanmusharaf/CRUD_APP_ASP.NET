# ASP.NET CRUD App

This is a basic CRUD (Create, Read, Update, Delete) application built using ASP.NET and SQL Server. The project demonstrates how to perform CRUD operations with an ASP.NET MVC structure.

## Technologies Used

- **ASP.NET Core MVC**: For building the web application.
- **Entity Framework Core**: For interacting with the SQL Server database.
- **SQL Server**: As the database engine.
- **Bootstrap**: For styling and front-end design.

## Project Structure

- `ASP_CRUD_APP/`: The root directory of the project, containing the solution file and the project folder.
  - `ASP_CRUD_APP.sln`: The solution file that opens the project in Visual Studio.
  - `ASP_CRUD_APP/`: The main project folder containing all source code and configurations, including:
    - `Controllers/`: Contains the MVC controllers.
    - `Views/`: Contains the Razor views (HTML files).
    - `Models/`: Contains the entity models for interacting with the database.
    - `bin/`: Compiled binaries (generated after building the project).
    - `appsettings.json`: Contains the database connection string and other configuration settings.
    - `wwwroot/`: Static files like CSS, JavaScript, and images.
  
## Prerequisites

Before you begin, ensure you have the following installed:

- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) or later.
- [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet) version 6.0 or higher.
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or SQL Server Express.
- [Git](https://github.com/rehmanmusharaf/CRUD_APP_ASP.NET.git) for cloning the repository.

## Setting Up the Project

1. **Clone the repository:**

   Open your terminal or Git Bash and run the following command:

   ```bash
   git clone https://github.com/rehmanmusharaf/CRUD_APP_ASP.NET.git
2. Open the solution:

Navigate to the cloned repository.
Open the solution file (ASP_CRUD_APP.sln) in Visual Studio.
Configure the database:

Open the appsettings.json file located in the root of the project (ASP_CRUD_APP/appsettings.json).

Update the ConnectionStrings section with your SQL Server credentials:
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Replace YOUR_SERVER with your SQL Server instance name and YOUR_DATABASE with the name of the database you wish to use.

4. Run Database Migrations (optional):

If you are using Entity Framework migrations, you might need to run the following commands in the Package Manager Console to create or update the database:
Update-Database
This will create the database schema based on the models defined in the project.

5. Run the application:

In Visual Studio, click on the green "Start" button or press F5 to build and run the application.
The application should launch in your default web browser.
5. Accessing the app:

Once the application is running, you can navigate through the app and perform CRUD operations on the data.
License
This project is licensed under the MIT License - see the LICENSE file for details.

### Key points for customization:
- Replace `YOUR_SERVER` and `YOUR_DATABASE` with actual values for your SQL Server.
- If you want to add more detailed instructions or any other specific tools you used (e.g., NuGet packages), you can update the guide accordingly.

Let me know if you need further customizations!
