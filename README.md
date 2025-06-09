# School System APIs

![GitHub last commit](https://img.shields.io/github/last-commit/01124833532mo/School_System.Apis)
![GitHub repo size](https://img.shields.io/github/repo-size/01124833532mo/School_System.Apis)
![GitHub license](https://img.shields.io/github/license/01124833532mo/School_System.Apis)

A comprehensive API system for managing school operations: student records, course administration, attendance tracking, and grade reporting.

---

## 📦 Features

- **Student Management**: CRUD operations for student records
- **Course Administration**: Manage courses, schedules, and enrollments
- **Attendance Tracking**: Record and track student attendance
- **Gradebook System**: Store and calculate grades
- **User Authentication**: Secure access with role-based permissions
- **Reporting**: Generate academic performance reports
- **Pagination**: Efficient data retrieval
- **Localization**: Multi-language support for responses
- **Validation**: Robust request validation

---

## 🛠 Technologies & Architecture

### 🎯 Tech Stack

- **Framework:** ASP.NET Core 6.0+
- **Database:** SQL Server 2019+
- **ORM:** Entity Framework Core
- **Authentication:** JWT (JSON Web Token)
- **API Docs:** Swagger (OpenAPI)
- **Validation:** FluentValidation
- **Localization:** Built-in ASP.NET Core Localization

---

### 🏛 Architectural Design

#### ✅ Core Patterns

| Pattern               | Purpose                                                       |
|-----------------------|---------------------------------------------------------------|
| **CQRS**              | Separate read and write operations for scalability            |
| **Repository**        | Encapsulate data access logic                                 |
| **Dependency Injection** | Decoupled architecture with service registration           |
| **FluentValidation**  | Centralized request validation logic                          |

#### ✅ Project Structure
---

## 📂 Project Architecture
The project follows **Clean Architecture** principles, with a clear separation of concerns:

```plaintext
School_System.Apis/
├── src/
│   ├── SchoolSystem.Core/            # 🧠 Domain Layer
│   │   ├── Entities/                 # Core domain models (Student, Course, etc.)
│   │   ├── Domain.Interfaces/        # Domain-level contracts (e.g. IRepository)
│   │   ├── Specifications/           # Business rules specifications
│   │   └── Routing/                  # Domain-level routing abstractions
│   │
│   ├── SchoolSystem.Application/     # 🚀 Application Layer (CQRS)
│   │   ├── Features/                 # Use cases: Commands, Queries, Handlers
│   │   │   ├── Students/
│   │   │   └── Auth/
│   │   ├── DTOs/                     # Input/Output models
│   │   ├── Services/                 # Business logic & orchestration
│   │   ├── Interfaces/               # Service contracts (IAuthService, etc.)
│   │   ├── Bases/                    # Common Response / ResponseHandler
│   │   │   ├── Response/
│   │   │   └── ResponseHandler/
│   │   └── Mapping/                  # AutoMapper profiles
│   │
│   ├── SchoolSystem.Infrastructure/  # 🛠 Infrastructure Layer
│   │   ├── Persistence/
│   │   │   ├── SchoolDbContext.cs   # EF Core DbContext
│   │   │   ├── Configurations/      # Fluent API entity configs
│   │   │   ├── Migrations/
│   │   │   └── UnitOfWork.cs?
│   │   └── Repositories/            # EF Core repository implementations
│   │
│   └── SchoolSystem.APIs/           # 🌐 Presentation Layer
│       ├── Controllers/              # REST API endpoints
│       ├── Middlewares/             # Custom middleware (errors, logging)
│       ├── DTOs/                     # Models for API layer if needed
│       ├── Filters/                  # Validation & exception filters
│       └── Program.cs / Startup.cs  # App setup (DI, Swagger, CORS, Routing)
│
│
├── README.md                        # Project documentation
└── LICENSE                          # License information

```


#### ✅ Data Layer

- **Entity Framework Core**: Database operations and migrations
- **Fluent API / Data Annotations**: Model configurations
- **Migrations**: Database versioning
- **Pagination Support**: Efficient large dataset retrieval

#### ✅ Security

- **JWT Authentication**: Token-based authentication
- **ASP.NET Core Identity**: User and role management
- **Role-based Access Control**: Secure endpoint access

#### ✅ API Design

- **RESTful Principles**: Standardized HTTP methods
- **CORS Support**: Cross-origin resource sharing enabled
- **Swagger**: Interactive documentation and testing

#### ✅ Localization & Globalization

- **Response Localization**: Multi-language support
- **Request Localization**: Culture-specific handling

---

## 🚀 Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- SQL Server 2022 or later
- Visual Studio 2022 / VS Code

### Installation Steps

1. **Clone the repository**  
   ```bash
   git clone https://github.com/01124833532mo/School_System.Apis.git
   cd School_System.Apis



