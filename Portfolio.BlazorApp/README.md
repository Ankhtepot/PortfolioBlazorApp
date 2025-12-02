### Portfolio project: .NET

This is a portfolio project built using .NET technologies. It showcases my familiarity with .NET environment.
  Including MSSQL, Entity Framework, ASP.NET Core, Blazor, API development, and more.

Ports used:
-1437 - MSSQL
-8081 - ASP.NET Core API - Backend

### Running with Docker
Run the application using the following command in root
directory of Backend Project (currently Portfolio.BlazorApp - TODO: rename Porfolio.Backend):

```bash
docker-compose up --build
```
Run development version (with hot reload) using:
```bash
docker-compose up --build
docker compose stop blazorapp # TODO: might change to Blazor.Backend
dotnet watch run # TODO: might change to Blazor.Backend
```

### Migrate Database
To apply any pending migrations to the database, while in Blazor.Backend project, use the following command:
```bash
dotnet ef migrations add <MigrationName>
dotnet ef database update 
```
