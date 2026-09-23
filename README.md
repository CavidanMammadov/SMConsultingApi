# SM Consulting API

ASP.NET Core backend for the **SM Consulting** website, with APIs for consultancy services, training content, applications and company information.

[Live website](https://www.smconsulting.az/) · [Developer profile](https://github.com/CavidanMammadov)

## Features

- Consultancy services and sector-specific content.
- Training, application and blog management.
- Team members, partners, company values, vision and contact information.
- Paginated service listings and content-management endpoints.
- JWT authentication, refresh tokens and role-based authorization.
- Cloudinary media integration, DTO validation and Swagger documentation.

## Technology & structure

**C# · .NET 8 · ASP.NET Core Web API · EF Core · SQL Server · JWT · Cloudinary · FluentValidation · AutoMapper · Swagger**

| Project | Responsibility |
| --- | --- |
| `SMConsulting.API` | Controllers, HTTP pipeline and application configuration |
| `SMConsulting.BL` | Business services, DTOs, validation and external integrations |
| `SMConsulting.Core` | Domain entities and shared contracts |
| `SMConsulting.DAL` | Database context, repositories, mappings and migrations |

## Local setup

Prerequisites: .NET 8 SDK, SQL Server, EF Core CLI tools (8.x), and your own Cloudinary account for media functionality.

```sh
git clone https://github.com/CavidanMammadov/SMConsultingApi.git
cd SMConsultingApi
dotnet restore SMConsulting.API/SMConsulting.API.csproj
```

Create `SMConsulting.API/appsettings.Development.json` (ignored by Git):

```json
{
  "ConnectionStrings": {
    "MsSql": "Server=localhost;Database=SMConsultingDev;Integrated Security=True;TrustServerCertificate=True"
  },
  "Jwt": {
    "Issuer": "SMConsulting.Local",
    "Audience": "SMConsulting.Local.Client",
    "SecretKey": "<your-own-random-secret-at-least-32-bytes>"
  },
  "CloudinarySettings": {
    "CloudName": "<your-cloud-name>",
    "ApiKey": "<your-api-key>",
    "ApiSecret": "<your-api-secret>"
  }
}
```

Adjust the connection string to your local SQL Server. Windows integrated authentication and `TrustServerCertificate=True` are development settings, not a production template. Keep real credentials out of source control.

```sh
dotnet ef database update --project SMConsulting.DAL --startup-project SMConsulting.API -- --environment Development
dotnet run --project SMConsulting.API --launch-profile https
```

Open **https://localhost:7060/swagger**. If needed, trust the local development certificate using `dotnet dev-certs https --trust`.

## Example endpoints

| Method | Route | Purpose |
| --- | --- | --- |
| GET | `/api/Services` | List services |
| GET | `/api/Services/GetWithPagination?page=1&take=10` | Retrieve a page of services |
| GET | `/api/Services/{id}` | Read a service |
| POST | `/api/Services` | Create a service (authorized role required) |

```sh
curl "https://localhost:7060/api/Services/GetWithPagination?page=1&take=10"
```

Use Swagger to inspect DTOs and the full endpoint list. Protected requests use `Authorization: Bearer <access-token>`; service management currently requires role `1`.

## Scope

This repository contains the backend implementation. The live website is the project reference, not a public API sandbox. Production data, credentials and frontend source are not bundled here. Local setup instructions are based on the checked-in configuration and have not been validated against a production environment.

[LinkedIn](https://www.linkedin.com/in/cavidan-m%C9%99mm%C9%99dov-780305216/)
