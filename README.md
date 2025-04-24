# 🛒 eStore

eStore is a clean architecture-based e-commerce web application built using **.NET Core 8**, with a responsive frontend powered by **Bootstrap 5** and **SQL Server** (SSMS) as the database. It uses **ASP.NET Core Identity** for secure and scalable user authentication and authorization.

---

## 🔧 Project Structure

This solution is structured following the Clean Architecture principles, ensuring a scalable, maintainable, and testable codebase:

- **eStore.Domain**  
  Contains core business models, interfaces, and domain logic.

- **eStore.Application**  
  Holds application logic like use cases and service interfaces.

- **eStore.Infrastructure**  
  Implements repositories, database access using EF Core, and external services.

- **eStore.Web**  
  The entry point of the application. Includes controllers, views (Razor), static files, and Identity UI integration.

---

## 🚀 Technologies Used

- **Backend:** .NET Core 8
- **Frontend:** Bootstrap 5 (Razor Views)
- **Authentication:** ASP.NET Core Identity
- **Database:** SQL Server (via SSMS)
- **Architecture:** Clean Architecture

---

## 📦 Features

- 🔐 User registration and login using Identity
- 📁 Layered architecture for better separation of concerns
- 🧩 Easily extendable with modular components
- 🌐 Web UI designed with Bootstrap 5 for responsive layouts

---

## 📸 Project Overview

> Visual Studio Solution Structure  
> ![eStore Solution Structure](https://github.com/user-attachments/assets/1d4ed186-52de-413a-93c9-d778988f6e00)


---

## 💻 Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/eStore.git
2. Navigate to the eStore.Web project and run the application.
3. Make sure your SQL Server is running and configured correctly in appsettings.json.

## 🤝 Contributions
Contributions are welcome! Feel free to open issues or pull requests.


## 💻 Demo Images 
>![Login(Light Mode)](https://github.com/user-attachments/assets/8323edf1-5d66-44ab-b94f-33355e8622e5)
>![Login(Dark Mode)](https://github.com/user-attachments/assets/94b3fbd8-8b48-4e2b-aea7-ea2df5ed9a42)
>![Register(Dark Mode)](https://github.com/user-attachments/assets/be297246-4bbc-47fc-ba9b-4820125d4560)
>![Register(Light Mode)](https://github.com/user-attachments/assets/3b6bf4d3-6e81-468f-818d-062f7d5be133)
>![HomePage(Dark Mode)](https://github.com/user-attachments/assets/485c2462-fe4f-4a68-b720-1e5035bff4d3)
>![HomePage(Light Mode)](https://github.com/user-attachments/assets/997c139e-ecaa-467e-9eb3-91df3fd31be9)


