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
School_System.Apis/
│
├── src/                              # Source files
│   ├── SchoolSystem.Api/             # Presentation layer (Web API)
│   │   ├── Controllers/              # API controllers
│   │   ├── Filters/                  # Filters for request validation, error handling
│   │   ├── DTOs/                     # Data Transfer Objects (input/output models)
│   │   ├── Middlewares/              # Custom middlewares
│   │   ├── Program.cs                # Entry point & dependency injection
│   │   ├── appsettings.json          # Configuration
│   │   └── ...                       
│   │
│   ├── SchoolSystem.Application/     # Application layer (business logic)
│   │   ├── Features/                 # CQRS Handlers & Queries
│   │   │   ├── Students/             # Student-specific commands/queries
│   │   │   ├── Courses/              # Course-specific commands/queries
│   │   │   └── ...                   
│   │   ├── Interfaces/               # Service interfaces (e.g., IStudentService)
│   │   ├── DTOs/                     # DTOs shared with the API
│   │   ├── Validation/               # FluentValidation rules
│   │   └── ...                       
│   │
│   ├── SchoolSystem.Domain/          # Domain layer (core business entities)
│   │   ├── Entities/                 # Core domain models (e.g., Student, Course)
│   │   ├── ValueObjects/             # Value objects (e.g., Address)
│   │   ├── Enums/                    # Domain-specific enums
│   │   ├── Interfaces/               # Domain interfaces (e.g., IAggregateRoot)
│   │   └── ...                       
│   │
│   ├── SchoolSystem.Infrastructure/  # Infrastructure layer
│   │   ├── Data/                     # EF Core DbContext, configurations
│   │   │   ├── SchoolDbContext.cs    
│   │   │   ├── Configurations/       # Entity configurations (Fluent API)
│   │   │   └── Migrations/           # EF migrations
│   │   ├── Repositories/             # Repository implementations
│   │   ├── Services/                 # External service integrations
│   │   ├── Identity/                 # Identity management (if used)
│   │   └── ...                       
│   │
│   └── SchoolSystem.Shared/          # Shared kernel (common utilities)
│       ├── Constants/                # Constant values
│       ├── Helpers/                  # Utility classes
│       ├── Exceptions/               # Custom exceptions
│       └── ...                       
│
├── tests/                            # Unit and integration tests
│   ├── SchoolSystem.Tests/           # Test project
│   │   ├── Application/              # Application layer tests
│   │   ├── Domain/                   # Domain tests
│   │   ├── Infrastructure/           # Infrastructure tests
│   │   └── ...                       
│
├── .editorconfig                     # Editor configuration
├── .gitignore                        # Git ignore file
├── README.md                         # Project readme
└── LICENSE                           # License file


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

- .NET 6.0 SDK or later
- SQL Server 2019 or later
- Visual Studio 2022 / VS Code

### Installation Steps

1. **Clone the repository**  
   ```bash
   git clone https://github.com/01124833532mo/School_System.Apis.git
   cd School_System.Apis



