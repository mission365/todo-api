# 📝 Todo API - ASP.NET Core Web API

[![.NET Version](https://img.shields.io/badge/.NET-9.0-512BD4?logo=.net)](https://dotnet.microsoft.com/)
[![EF Core](https://img.shields.io/badge/EF%20Core-9.0-5C2D91?logo=csharp)](https://docs.microsoft.com/en-us/ef/core/)
[![Swagger](https://img.shields.io/badge/Swagger-UI-85EA2D?logo=swagger)](https://swagger.io/)
[![AutoMapper](https://img.shields.io/badge/AutoMapper-12.0-A31F34)](https://automapper.org/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

A **production-ready RESTful Todo Management API** built with ASP.NET Core 9.0.

---

## 📋 Table of Contents
- Project Overview
- Technology Stack
- Features
- Project Structure
- Installation Guide
- API Documentation
- Error Handling
- Testing Guide
- FAQ
- License

---

## 🎯 Project Overview

This Todo Management API is a backend service that allows clients to manage tasks efficiently.

### Use Cases
- Personal task management apps
- Team collaboration tools
- Project management systems
- ASP.NET Core learning projects

---

## 🛠 Technology Stack

| Technology | Version | Purpose |
|------------|---------|---------|
| ASP.NET Core | 9.0 | Web API Framework |
| Entity Framework Core | 9.0 | ORM |
| SQL Server LocalDB | 2022 | Database |
| AutoMapper | 12.0 | Object Mapping |
| Swagger | 7.0 | API Docs |

---

## ✨ Features

### Core
- Create Todo
- Read Todos
- Update Todo
- Delete Todo

### Technical
- Repository Pattern
- DTO Pattern
- AutoMapper
- Global Exception Handling
- Swagger UI
- Async Programming

---

## 📁 Project Structure

TodoApi/
├── Controllers/
├── Models/
├── DTOs/
├── Repositories/
├── Data/
├── Mappings/
├── Middlewares/
├── Migrations/
├── Program.cs
├── appsettings.json
└── TodoApi.csproj

---

## 🚀 Installation Guide

### 1. Clone
```bash
git clone https://github.com/yourusername/TodoApi.git
cd TodoApi
2. Restore
dotnet restore
3. Database Config
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TodoDb;Trusted_Connection=True;"
}
4. Migrations
dotnet ef migrations add InitialCreate
dotnet ef database update
5. Run
dotnet run
6. Swagger

https://localhost:5001/swagger

📡 API Endpoints
Method	Endpoint
GET	/todo
GET	/todo/{id}
POST	/todo
PUT	/todo/{id}
DELETE	/todo/{id}
🧪 Testing
cURL Example
curl -X POST https://localhost:5001/api/todo \
-H "Content-Type: application/json" \
-d '{"title":"Test","description":"Demo"}'
⚠️ Error Format
{
  "statusCode": 404,
  "message": "Not Found"
}
💬 FAQ

Q: Production ready?
Yes.

Q: Auth support?
Planned (JWT).

📜 License

MIT License © 2026 Your Name
