# 📝 Todo API - ASP.NET Core Web API

[![.NET Version](https://img.shields.io/badge/.NET-9.0-512BD4?logo=.net)](https://dotnet.microsoft.com/)
[![EF Core](https://img.shields.io/badge/EF%20Core-9.0-5C2D91?logo=csharp)](https://docs.microsoft.com/en-us/ef/core/)
[![Swagger](https://img.shields.io/badge/Swagger-UI-85EA2D?logo=swagger)](https://swagger.io/)
[![AutoMapper](https://img.shields.io/badge/AutoMapper-12.0-A31F34)](https://automapper.org/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](http://makeapullrequest.com)

A **production-ready RESTful Todo Management API** built with ASP.NET Core 9.0, following clean architecture principles and industry best practices.

## 🚀 Quick Features
- ✅ Full CRUD Operations
- ✅ Repository Pattern Implementation
- ✅ DTO & AutoMapper Integration
- ✅ Global Exception Handling
- ✅ Swagger/OpenAPI Documentation
- ✅ Async/Await Pattern
- ✅ SQL Server LocalDB Support

---

## 📋 Table of Contents
- [Project Overview](#-project-overview)
- [Technology Stack](#-technology-stack)
- [Features](#-features)
- [Architecture](#-architecture)
- [Project Structure](#-project-structure)
- [Installation Guide](#-installation-guide)
- [API Documentation](#-api-documentation)
- [Database Schema](#-database-schema)
- [Error Handling](#-error-handling)
- [Testing Guide](#-testing-guide)
- [Performance](#-performance)
- [Future Roadmap](#-future-roadmap)
- [Contributing](#-contributing)
- [FAQ](#-faq)
- [Contact](#-contact)
- [License](#-license)

---

## 🎯 Project Overview

This **Todo Management API** is a backend service that allows clients to manage tasks efficiently. Built with modern .NET practices, it serves as an excellent foundation for learning ASP.NET Core Web API development.

### Business Value
- **Task Management**: Create, track, and manage daily tasks
- **Scalable Architecture**: Easy to extend with new features
- **Production Ready**: Follows industry best practices
- **Well Documentated**: Complete Swagger documentation

### Use Cases
- Personal task management applications
- Team collaboration tools
- Project management systems
- Learning resource for ASP.NET Core
- Mobile app backend for todo apps

---

## 🛠 Technology Stack

| Technology | Version | Purpose |
|------------|---------|---------|
| ASP.NET Core | 9.0 | Web API Framework |
| Entity Framework Core | 9.0 | ORM & Data Access |
| SQL Server LocalDB | 2022 | Relational Database |
| AutoMapper | 12.0.1 | Object Mapping |
| Swagger/Swashbuckle | 7.0 | API Documentation |
| .NET CLI | 9.0 | Development Tools |

### Development Tools Required
- **IDE**: Visual Studio 2022 / VS Code / JetBrains Rider
- **Version Control**: Git & GitHub
- **API Testing**: Postman / Swagger UI / cURL
- **Database Management**: SQL Server Management Studio (SSMS)

---

## ✨ Features

### Core Features
- ✅ **Create Todo** - Add new tasks with title and description
- ✅ **Read Todos** - Retrieve single or all todos
- ✅ **Update Todo** - Modify existing tasks and mark completion
- ✅ **Delete Todo** - Remove tasks permanently

### Technical Features
- ✅ **Repository Pattern** - Abstraction layer for data access
- ✅ **DTO Pattern** - Secure data transfer between layers
- ✅ **AutoMapper** - Automatic object-object mapping
- ✅ **Global Exception Middleware** - Centralized error handling
- ✅ **Swagger Integration** - Interactive API documentation
- ✅ **Async Programming** - Non-blocking database operations
- ✅ **Dependency Injection** - Loose coupling and testability
- ✅ **SQL Server LocalDB** - Local development database

### Security Features (Coming Soon)
- 🔐 JWT Authentication
- 🔐 Role-based Authorization
- 🔐 Input Validation
- 🔐 Rate Limiting

---

## 🏗 Architecture

### Layered Architecture
┌─────────────────────────────────────────────────────────┐
│ Presentation Layer │
│ (Controllers/API) │
└─────────────────────────────────────────────────────────┘
│
▼
┌─────────────────────────────────────────────────────────┐
│ Application Layer │
│ (DTOs, Mappings, Validators) │
└─────────────────────────────────────────────────────────┘
│
▼
┌─────────────────────────────────────────────────────────┐
│ Domain Layer │
│ (Models/Entities) │
└─────────────────────────────────────────────────────────┘
│
▼
┌─────────────────────────────────────────────────────────┐
│ Infrastructure Layer │
│ (Repositories, Data Context, Middleware) │
└─────────────────────────────────────────────────────────┘
│
▼
┌─────────────────────────────────────────────────────────┐
│ Database Layer │
│ (SQL Server) │
└─────────────────────────────────────────────────────────┘

### Data Flow Diagram
Client Request → Controller → Repository → Database
↑ ↓ ↓ ↓
└── Response ←─ DTO ←── Model ←─── SQL Query

---

## 📁 Project Structure

# Project Structure
TodoApi/
│
├── Controllers/
│ └── TodoController.cs
│
├── Models/
│ └── TodoItem.cs
│
├── DTOs/
│ ├── TodoCreateDto.cs
│ ├── TodoUpdateDto.cs
│ └── TodoResponseDto.cs
│
├── Repositories/
│ ├── ITodoRepository.cs
│ └── TodoRepository.cs
│
├── Data/
│ └── TodoContext.cs
│
├── Mappings/
│ └── MappingProfile.cs
│
├── Middlewares/
│ └── GlobalExceptionMiddleware.cs
│
├── Migrations/ # Auto-generated
│
├── Program.cs
├── appsettings.json
├── appsettings.Development.json
├── .gitignore
└── TodoApi.csproj
