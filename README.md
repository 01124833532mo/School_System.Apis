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

## 🏗️ Project Structure

```plaintext
SchoolSystem
├── SchoolSystem.Core                  # Domain Layer
│   ├── Entities                       # Core business models
│   ├── Domain.Interfaces              # Domain contracts (e.g., IRepository)
│   ├── Routing
│   └── Specifications
│
├── SchoolSystem.Application           # Application Layer (CQRS)
│   ├── Features                       # Use Cases (Commands, Queries, Handlers)
│   │   ├── Students
│   │   └── Auth
│   ├── DTOs                           # Input/Output models
│   ├── Services                       # Internal application logic
│   ├── Interfaces                     # Services contracts (IAuthService, etc.)
│   ├── Bases                          # Response and ResponseHandler
│   │   ├── Response
│   │   └── ResponseHandler
│   └── Mapping                        # AutoMapper profiles
│
├── SchoolSystem.Infrastructure        # Infrastructure Layer
│   ├── Persistence
│   │   ├── DbContext.cs
│   │   ├── Configurations
│   │   ├── Unit Of Work
│   │   └── Migrations
│   └── Repositories                   # EF Core implementations
│
└── SchoolSystem.APIs                  # Presentation Layer
    └── Controllers                    # REST endpoints
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

- .NET 6.0 SDK or later
- SQL Server 2019 or later
- Visual Studio 2022 / VS Code

### Installation Steps

1. **Clone the repository**  
   ```bash
   git clone https://github.com/01124833532mo/School_System.Apis.git
   cd School_System.Apis



