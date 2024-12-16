# 🌟 Together Culture CRM 🌟

Welcome to the **Together Culture CRM** system! 🚀 This is a Customer Relationship Management (CRM) solution built in **C#** for managing customer data, improving relationships, and boosting customer retention for **Together Culture**. This CRM is tailored to suit the unique needs of our organization, ensuring **efficiency**, **transparency**, and **seamless communication** between departments and clients.

## 📚 Table of Contents

- [✨ Features](#features)
- [🛠️ Technologies Used](#technologies-used)
- [🚀 Getting Started](#getting-started)
- [⚙️ Installation](#installation)
- [🔧 Configuration](#configuration)
- [💻 Usage](#usage)
- [🗂️ Database Schema](#database-schema)
- [🤝 Contributing](#contributing)
- [📄 License](#license)

## ✨ Features

- **👤 Customer Management**: Add, update, delete, and manage customer records.
- **📈 Sales Tracking**: Keep track of deals, pipelines, and customer interactions.
- **📝 Communication Logging**: Record communication history with customers.
- **✅ Task Management**: Create and assign tasks related to customer follow-ups.
- **🔐 User Roles & Permissions**: Role-based access control for different user types (admin, sales, support).
- **📊 Reports & Analytics**: Generate customer and sales reports to monitor performance.
- **🔍 Search and Filter**: Efficient searching and filtering capabilities for quick access to customer data.
- **📊 Dashboard Overview**: Visual representation of sales pipelines, upcoming tasks, and communication stats.

## 🛠️ Technologies Used

- **C# (ASP.NET Core)**: Core language and framework for backend.
- **Entity Framework Core**: For object-relational mapping (ORM) with the database.
- **SQL Server**: Relational database management.
- **HTML/CSS/JavaScript**: Frontend components for user interface.
- **Bootstrap**: Responsive UI design framework.
- **RESTful APIs**: For integration with third-party services and internal communication.
- **Automapper**: Object mapping for DTOs (Data Transfer Objects).
- **JWT Authentication**: JSON Web Tokens for secure API authentication.

## 🚀 Getting Started

These instructions will help you get a copy of the project up and running on your local machine for development and testing purposes.

### 📋 Prerequisites

- **.NET Core SDK**: Version 5.0 or higher.
- **SQL Server**: Any recent version.
- **Visual Studio** (or any C#-compatible IDE).

### ⚙️ Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/karanjagani494/CRM_TC.git
   cd crm 

2. **Set up the upstream repository**:
   ```bash
   git remote add upstream https://github.com/karanjagani494/CRM_TC.git


3. **Fetch and merge changes from upstream**
   ```bash
   git fetch upstream
   git merge upstream/main

4. **Install dependencies**
   ```bash
   dotnet add package MySql.Data --version 9.1.0
   dotnet add package WinForms.DataVisualization --version 1.10.0-pr2

## 💻 Usage

Once the CRM application is set up, you can start using it to manage customer data, track sales, and generate reports.

- **Login**: Use the login page to authenticate based on your assigned role.
- **Customer Management**: Navigate to the **Customer Management** section to add or update customer records.
- **Sales Tracking**: Track deals and manage your sales pipeline.
- **Reports**: Generate reports to monitor CRM performance.
- **Task Management**: Create and assign tasks related to customer follow-ups.

## 🗂️ Database Structure

The CRM system is powered by a relational database that organizes various data into tables. Below is an overview of the main tables used in the system:

### **📊 Attendance Log**
This table tracks the attendance of members at various events. It stores information like member ID, event ID, check-in time, and status.

### **📚 Bookings**
The Bookings table records all booking information for events and services. It includes fields such as booking date, member ID, event ID, and booking status.

### **🎉 Events**
The Events table contains details about the various events organized by Together Culture. It includes event name, date, time, location, and description.

### **💡 Interests**
This table stores information about different interests that members may have. These interests could be related to specific events, groups, or activities within the organization.

### **👥 Members**
The Members table stores personal and contact information for each member. Fields include name, email, phone number, membership status, and other essential details.

### **📄 Membership**
This table tracks membership details, including membership types, renewal dates, and member status.

### **🧩 Member Interest**
The Member Interest table links members to their respective interests, associating members with specific activities or events they are interested in.

### **💳 Payments**
The Payments table stores transaction information for payments made by members. This includes payment date, amount, payment method, and membership renewals.

### **📝 Queries & Feedback**
This table stores queries and feedback submitted by members. It helps the organization track questions, suggestions, or complaints submitted by the members.

### **👨‍💼 Staff**
The Staff table holds information about the employees or administrative staff within the organization, including their roles, departments, and personal information.

### **🏷️ Tags**
Tags help categorize and label various entities such as events, members, or bookings. This table contains tags that can be assigned to different records for easier filtering and searching.

---

Each of these tables is designed to interact with each other, making the Together Culture CRM a dynamic and flexible system for managing members, events, and payments.

## 🤝 Contributing

We welcome contributions to the Together Culture CRM! If you'd like to contribute, please follow these steps:

1. **Fork** the repository.
2. **Clone** your fork to your local machine.
3. **Create** a new branch for your feature or bug fix.
4. **Make your changes** and commit them with a clear message.
5. **Push** your changes to your fork.
6. **Create a pull request** to merge your changes into the main repository.

## 📄 License

This project is licensed under the MIT License - see the [KARAN][SHAURYA][BURHAN][RASHID] for details.
