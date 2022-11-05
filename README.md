# seller asp-net-core-mvc

## General architecture

- View
- Controller
- Model (Services-Repositories (Entities))

## Checklist:

- wwwroot: application resources (css, imagens, etc.)
- Controllers: application's MVC controllers
- Models: entities and "view models"
- Views: pages (notice naming conventions against controllers)
  - Shared: views used for more than one controller
- appsettings.json: external resources configuration (logging, connection strings, etc.)
- Program.cs: entry point
- Startup.cs: app configuration

## Database

- MySql
