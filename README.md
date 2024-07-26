# ProductManagementAPI
Product Management Backend Project Using ASP.NET Core Web API
## 1- Introduction
  This is a simple ASP.NET Core Web API application that supports basic CRUD operations on a Product entity, with each product belonging to one or more product categories. The API interacts with a SQL Server database.

## 2- Requirements
  ##### .NET 6.0 SDK or later.
  ##### SQL Server.
  ##### Entity Framework Core.
  ##### Visual Studio 2022 or Visual Studio Code.
## 3- Getting Started
  ### 3.1. Clone the Repository
  ### 3.2. Set Up the Database
       Ensure that SQL Server is running and accessible.
  ### 3.3. Configure Connection String
       Update the connection string in 'appsettings.json' to point to your SQL Server instance:
      "ConnectionStrings": {
        "constr": "Data Source=your Server;Initial Catalog=ProductManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
      }
  ### 3.4. Apply Migrations
       by write the Command Update-database in package manager console
  ### 3.5. Run the Application

# API Endpoints
  #### GET /api/products: Retrieve a list of all products.
  #### GET /api/products/{id}: Retrieve a single product by ID.
  #### POST /api/products: Create a new product.
  #### PUT /api/products/{id}: Update an existing product by ID.
  #### DELETE /api/products/{id}: Delete a product by ID.

# API Documentation
you can test the EndPoints using Swagger

# Project Structure
#### Controllers: Contains API controllers.
#### Entities: Contains entity classes that mapped to Tables in Database.
#### Repositories: Contains repository interfaces and implementations.
#### Services: Contains service interfaces and implementations.
#### Data: Contains the DbContext and database configuration.

  
