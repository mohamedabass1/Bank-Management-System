# Bank Management System 🏦

A desktop banking management system developed using **C# Windows Forms** and **Microsoft SQL Server**.  
This project demonstrates the implementation of **Three-Tier Architecture**, **Object-Oriented Programming (OOP)**, and structured database interaction using **ADO.NET**.

The system simulates essential banking operations such as managing clients, handling accounts, performing financial transactions, and managing system users with flexible permissions.

---

# Project Architecture

The system follows the **Three-Tier Architecture (3-Layer Architecture)** to ensure maintainability, scalability, and separation of concerns.

## 1. Presentation Layer (UI)

Project: `BankSystemProjectWinForms`

Responsible for:
- User Interface (Windows Forms)
- Handling user input
- Displaying system data
- Interaction between users and the system

---

## 2. Business Logic Layer (BLL)

Project: `BankBuisnessLayer`

Responsible for:
- Implementing business rules
- Processing system operations
- Managing system entities such as:

Examples:
- `clsClient`
- `clsUser`
- `clsAccount`
- `clsTransfer`

This layer ensures that the application logic remains independent from both the UI and the database.

---

## 3. Data Access Layer (DAL)

Project: `BankDataAccessLayer`

Responsible for:
- Communicating with the database
- Executing SQL queries
- Performing CRUD operations (Create, Read, Update, Delete)

Technologies used:
- **ADO.NET**
- **SQL Server**

---

# Key Features

## User Management

- Create and manage system users
- Secure login functionality
- Track login activities using **Login Register Logs**

---

## Flexible Permissions System

The system implements a **bitwise permissions model** that allows assigning specific permissions to each user.

Examples of permissions:
- Manage Clients
- Manage Users
- View Logs
- Full Access

This method allows efficient and scalable permission management.

---

## Client and Person Management

The system uses **Inheritance (OOP concept)** to link:

- `Person`
- `Client`

This design avoids data duplication and maintains a clean system structure.

---

## Account Management

The system allows:

- Creating bank accounts for clients
- Viewing account details
- Managing balances

---

## Financial Transactions

Users can perform common banking operations such as:

- Deposit
- Withdraw
- Transfer between accounts

---

# Technologies Used

| Technology | Description |
|-----------|------------|
| C# | Main programming language |
| .NET Framework | Application framework |
| Windows Forms | Desktop UI framework |
| SQL Server | Relational database |
| ADO.NET | Database communication |
| OOP | Object-Oriented Programming |

---

# Concepts Applied in This Project

This project demonstrates practical implementation of:

- Three-Tier Architecture
- Object-Oriented Programming (OOP)
- Inheritance
- Database Design
- Bitwise Permission System
- ADO.NET Data Access
- Desktop Application Development

---

# How to Run the Project

## 1. Clone the repository

```bash
git clone https://github.com/mohamedabass1/Bank-Management-System.git
```

---

## 2. Open the project

Open the solution file in **Visual Studio**:

```
BankManagementSystem.sln
```

---

## 3. Setup the Database

1. Install **Microsoft SQL Server**
2. Create a database called:

```
BankDB
```

3. Run the SQL script included with the project to create the required tables.

---

## 4. Configure the Connection String

Open the following file:

```
BankDataAccessLayer/clsDataAccessSetting.cs
```

Update the connection string to match your SQL Server configuration:

```csharp
public static string ConnectionString = @"Server=.; DataBase=BankDB; User Id=sa; Password=your_password";
```

---

## 5. Run the Application

Build and run the project using **Visual Studio**.

---

# Screenshots

You can add screenshots of the system here such as:

- Login Screen
- Main Dashboard
- Client Management
- Account Transactions

Example folder structure:

```
/screenshots
    login.png
    dashboard.png
    clients.png
```

---

# Database Diagram

The project includes a database diagram created using **draw.io** to illustrate the database structure.

---

# Future Improvements

Possible future enhancements include:

- Converting the system into a **Web Application using ASP.NET**
- Using **Entity Framework** instead of ADO.NET
- Adding **REST API**
- Implementing **password hashing for better security**
- Adding **unit testing**
- Implementing **report generation**

---

# Author

Developed as a **university project (3rd Year – First Semester)**.

---

⭐ If you find this project useful, feel free to **star the repository**.
