# 🎮 GameHubMVC

A simple and clean **ASP.NET Core MVC CRUD application** built to demonstrate a clear understanding of the **Model–View–Controller (MVC)** architecture using **Entity Framework Core**.

This project focuses on building a structured web application from scratch, following backend best practices and clean architecture principles.

---

## 🚀 Features

- Full CRUD operations (Create, Read, Update, Delete)
- ASP.NET Core MVC architecture
- Entity Framework Core with SQLite
- Razor Views
- Clean and organized folder structure
- Asynchronous database operations
- Simple and readable UI

---

## 📦 Project Structure
```
GameHubMVC
├── Controllers
│   ├── GameCharactersController.cs
│   └── HomeController.cs
│
├── Models
│   └── GameCharacter.cs
│
├── Data
│   └── AppDbContext.cs
│
├── Views
│   ├── GameCharacters
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Delete.cshtml
│   │
│   ├── Home
│   │   └── Index.cshtml
│   │
│   └── Shared
│       ├── _Layout.cshtml
│       ├── _ViewImports.cshtml
│       └── _ViewStart.cshtml
│
├── Migrations
│
├── wwwroot
│
├── Program.cs
├── GameHubMVC.csproj
└── appsettings.json
```



---

## 🧠 MVC Explained (Brief)

- **Model**  
  Represents the data and business logic (`GameCharacter`).

- **View**  
  Handles UI rendering using Razor (`.cshtml` files).

- **Controller**  
  Manages HTTP requests and connects Models with Views.

This separation improves maintainability, readability, and scalability.

---

## 🗄️ Database

- SQLite database
- Managed using Entity Framework Core
- Database schema handled through migrations

---

## 🛠️ Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQLite
- Razor Views
- C#
- .NET SDK

---

## ▶️ How to Run the Project

```bash
dotnet restore
dotnet run
Then open your browser at: http://localhost:5200/GameCharacters
```

---


## 📌 Purpose of This Project
### This project was built as a learning-focused application to:

- Understand MVC architecture deeply
- Understand MVC architecture deeply
- Learn how Controllers, Models, and Views interact
- Gain hands-on experience with EF Core and migrations


---


## ⭐ Final Notes

```
This repository reflects a solid foundation in backend web development using ASP.NET Core MVC.
The focus is on clarity, structure, and correct implementation rather than complexity.
```


