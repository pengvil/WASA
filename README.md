<div align="center">

<img src="https://raw.githubusercontent.com/pengvil/WASA/main/gear64x64.ico" width="80" alt="App Icon"/>

# 💧 Water & Sewage Management System

**A role-based desktop application for water billing, complaints, maintenance, and reporting**

[![Platform](https://img.shields.io/badge/Platform-Windows-0078D4?style=flat-square&logo=windows&logoColor=white)](https://github.com/pengvil/WASA )
[![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat-square&logo=csharp&logoColor=white)](https://github.com/pengvil/WASA)
[![Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://github.com/pengvil/WASA)
[![Database](https://img.shields.io/badge/Database-SQL%20Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)](https://github.com/pengvil/WASA)
[![IDE](https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?style=flat-square&logo=visualstudio&logoColor=white)](https://github.com/pengvil/WASA)
[![Course](https://img.shields.io/badge/Course-CSC2210%20OOP%202-blue?style=flat-square)](https://github.com/pengvil/WASA)

[📋 Overview](#-project-overview) · [🎯 Objectives](#-objectives) · [👥 Team](#-team-members) · [👤 Actors](#-actors--features) · [🔄 Workflows](#-actor-workflows) · [🗃️ Database](#️-database-schema) · [⚙️ Setup](#️-setup-instructions)

</div>

---

## 📋 Project Overview

The **Water & Sewage Management System** is a role-based desktop application built with **C# Windows Forms** and **Microsoft SQL Server**, developed for the **CSC2210 Object Oriented Programming 2** course at AIUB (Spring 2025–2026).

The system focuses on common water service operations — user registration, bill generation, bill dispute handling, complaint submission, complaint assignment, connection application processing, notice publication, and maintenance task tracking. The codebase is organized into separate folders by actor role, keeping UI code, database logic, and business logic cleanly separated.

> **Supervisor:** Kazi Sadia &nbsp;|&nbsp; **Section:** P &nbsp;|&nbsp; **Group:** 11

### ✨ Key Highlights

| Feature | Description |
|---|---|
| 🔐 **Role-Based Access** | Four distinct actors — Admin, Customer, Service Officer, Maintenance Engineer |
| 🧾 **Billing System** | Meter reading input, automated bill generation, payment tracking, and dispute resolution |
| 🛠️ **Complaint Management** | Submit, assign, track, and resolve complaints end-to-end |
| 🔌 **Connection Applications** | Apply for new water connections with document verification and scheduling |
| 📢 **Notices & Reports** | Admin broadcasts notices; system generates billing and maintenance reports |
| 🗄️ **SQL Server Backend** | Fully relational database normalized to 3NF with 10 tables |

---

## ❗ Problem Statement

Manual management of water services can cause billing mistakes, slow complaint handling, poor application tracking, weak communication, and difficulty monitoring field-level maintenance work. Customers often need to contact the office repeatedly just to check bill status, complaint progress, or connection application updates.

This system solves these administrative problems by **centralizing all records** and providing **separate dashboards for each actor**, eliminating repeated manual follow-ups and reducing human error.

---

## 🎯 Objectives

- Develop a desktop OOP2 project using **C# Windows Forms**
- Use **Microsoft SQL Server** to store users, customers, bills, complaints, connection applications, notices, payments, maintenance tasks, and reports
- Provide **role-based login** and redirect each user to their correct dashboard
- Allow **Admin** to approve employee accounts, manage users, publish notices, assign complaints, and view reports
- Allow **Service Officers** to generate bills, review disputes, verify connection applications, and produce billing reports
- Allow **Customers** to view bills, submit disputes, submit complaints, apply for connections, and track status
- Allow **Maintenance Engineers** to view assigned tasks, update repair progress, set visit dates, write inspection notes, and submit completion reports
- Demonstrate OOP concepts such as **classes, objects, encapsulation, inheritance, separation of responsibilities**, and reusable methods

---

## 👥 Team Members

| Name | Student ID | Module |
|---|:---:|---|
| Md. Zahidul Islam Navil | 24-58087-2 | Admin |
| Afsan Abid Anik | 24-58455-2 | Customer |
| Kazi Shafiqul Alam | 24-58488-2 | Service Officer |
| Md Arafat Hossain | 24-58459-2 | Maintenance Engineer |

---

## 🛠️ Technologies Used

| Technology | Purpose |
|---|---|
| **C#** | Core application language |
| **Windows Forms** | Desktop GUI framework |
| **.NET Framework 4.7.2** | Application runtime |
| **Microsoft SQL Server** | Relational database |
| **Microsoft.Data.SqlClient** | Database connectivity |
| **Visual Studio** | Development IDE |
| **Git & GitHub** | Version control and team collaboration |

---

## 👤 Actors & Features

<details>
<summary><b>🔑 Admin</b> — User management, complaints, notices, and system reports</summary>

- Login / Logout
- Register
- View and Update Profile
- Change Password / Forgot Password
- Approve Pending Employees
- Manage Users
- Assign Complaints to Maintenance Engineers
- Manage Notices
- Check System Reports

</details>

<details>
<summary><b>🏠 Customer</b> — Bills, complaints, and connection applications</summary>

- Login / Logout
- Register
- View and Update Profile
- Change Password / Forgot Password
- View Current Bill
- View Bill History
- Submit Bill Dispute
- Submit Complaint
- Track Complaint Status
- Apply for New Connection
- Track Connection Application

</details>

<details>
<summary><b>📊 Service Officer</b> — Billing, disputes, and connection processing</summary>

- Login / Logout
- Register
- View and Update Profile
- Change Password / Forgot Password
- Enter Meter Reading
- Generate Bill
- View Customer Bill List
- Review Disputes
- Correct Bill Amount
- Review Connection Applications
- Verify Documents
- Schedule Installations
- Generate Billing Report

</details>

<details>
<summary><b>🔧 Maintenance Engineer</b> — Assigned complaints and maintenance tasks</summary>

- Login / Logout
- Register
- View and Update Profile
- Change Password / Forgot Password
- View Assigned Complaints
- View Maintenance Tasks
- Set Expected Visit Date
- Add Inspection Notes
- Update Repair Progress
- Submit Completion Report

</details>

---

## 🔄 Actor Workflows

### 🔐 Role-Based Login Flow

After login, the system reads the user's role from the `Users` table and redirects to the appropriate dashboard:

```
Login
  │
  ├── Admin                → AdminDashboardForm
  ├── Customer             → CustomerDashboardForm
  ├── Service Officer      → ServiceOfficerDashboardForm
  └── Maintenance Engineer → MaintenanceDashboardForm
```

---

### 🔑 Admin Workflow

```
Admin Logs In
      │
      ├── 1. Approve Pending Employees
      │         └── Pending Service Officers / Engineers become active accounts
      │
      ├── 2. Manage Users
      │         └── View, update, or delete any user record
      │
      ├── 3. View Submitted Complaints
      │         └── Assign complaint to a Maintenance Engineer
      │
      ├── 4. Manage Notices
      │         ├── Create new notice (area-based announcements)
      │         └── Delete outdated notices
      │
      └── 5. Check System Reports
                └── View billing and maintenance summaries
```

---

### 🏠 Customer Workflow

```
Customer Registers / Logs In
      │
      ├── 1. View Current Bill
      │         ├── Pay bill
      │         └── Submit Bill Dispute (if amount seems incorrect)
      │
      ├── 2. View Bill History
      │         └── Browse all past bills and payment records
      │
      ├── 3. Submit Complaint
      │         └── Track Complaint Status
      │                   └── Status updates as Engineer progresses
      │
      └── 4. Apply for New Water Connection
                └── Track Connection Application Status
                          └── Status updates as Officer reviews
```

---

### 📊 Service Officer Workflow

```
Service Officer Logs In
      │
      ├── 1. Enter Meter Reading → Generate Bill
      │         └── Bill is created for the customer's account
      │
      ├── 2. View Customer Bill List
      │         └── Browse all generated bills per customer
      │
      ├── 3. Review Bill Disputes
      │         ├── Dispute is valid → Correct Bill Amount
      │         └── Dispute is invalid → Reject and close
      │
      ├── 4. Review Connection Applications
      │         ├── Verify submitted documents
      │         ├── Schedule installation date
      │         └── Approve or reject application
      │
      └── 5. Generate Billing Report
                └── Export billing summary for the period
```

---

### 🔧 Maintenance Engineer Workflow

```
Maintenance Engineer Logs In
      │
      ├── 1. View Assigned Complaints
      │         └── Complaints assigned by Admin appear here
      │
      ├── 2. View Maintenance Tasks
      │         └── Tasks auto-created from assigned complaints
      │
      ├── 3. Set Expected Visit Date
      │         └── Schedule on-site visit for the complaint
      │
      ├── 4. Add Inspection Notes
      │         └── Document findings after visiting the site
      │
      ├── 5. Update Repair Progress
      │         └── Mark task as In Progress / Completed
      │
      └── 6. Submit Completion Report
                └── Final report submitted → Complaint status updated to Resolved
```

---

## 🏗️ Project Structure

```
WaterSewageManagementSystem/
│
├── 📁 Properties/
├── 📁 References/
│
├── 📁 database/
│   └── WaterSewageManagementDB.bak       ← SQL Server backup file
│
├── 📁 Forms/
│   ├── 📁 Admin/
│   │   ├── AdminDashboardForm.cs
│   │   ├── ApproveEmployeesForm.cs
│   │   ├── AssignComplaintsForm.cs
│   │   ├── ManageUsersForm.cs
│   │   ├── NoticeManagementForm.cs
│   │   └── SystemReportForm.cs
│   │
│   ├── 📁 Common/
│   │   ├── ChangePasswordForm.cs
│   │   ├── ForgotPasswordForm.cs
│   │   ├── LoginForm.cs
│   │   ├── ProfileForm.cs
│   │   └── RegisterForm.cs
│   │
│   ├── 📁 Customer/
│   │   ├── BillHistoryForm.cs
│   │   ├── ConnectionApplicationForm.cs
│   │   ├── CurrentBillForm.cs
│   │   ├── CustomerDashboardForm.cs
│   │   ├── SubmitBillDisputeForm.cs
│   │   ├── SubmitComplaintForm.cs
│   │   ├── TrackApplicationForm.cs
│   │   └── TrackComplaintForm.cs
│   │
│   ├── 📁 MaintenanceEngineer/                  
│   │   ├── AssignedComplaints.cs
│   │   ├── CompletionReportForm.cs
│   │   ├── InspectionNotesForm.cs
│   │   ├── MaintenanceDashboardForm.cs
│   │   ├── MaintenanceTasksForm.cs
│   │   ├── RepairProgressForm.cs
│   │   └── VisitDateForm.cs
│   │
│   └── 📁 ServiceOfficer/
│       ├── BillingReportForm.cs
│       ├── CorrectBillForm.cs
│       ├── CustomerBillListForm.cs
│       ├── MeterReadingBillGenerateForm.cs
│       ├── ReviewConnectionApplicationsForm.cs
│       ├── ReviewDisputesForm.cs
│       ├── ScheduleInstallationForm.cs
│       ├── ServiceOfficerDashboardForm.cs
│       └── VerifyDocumentsForm.cs
│
├── 📁 Resources/
├── .gitignore
├── App.config
├── gear64x64.ico
├── packages.config
├── Program.cs
└── README.md
```
---

## 🗃️ Database Schema

| Table | Attributes |
|---|---|
| `Users` | UserID, FullName, Email, Phone, Password, Role, Address, Status, CreatedAt, Gender, DOB |
| `Customers` | CustomerID, UserID, MeterNumber, HoldingNumber, ConnectionType |
| `Bills` | BillID, CustomerID, BillingMonth, PreviousReading, CurrentReading, UnitUsed, Amount, Arrears, Status, CreatedAt |
| `Payments` | PaymentID, BillID, CustomerID, PaymentDate, Amount, Method, ReceiptNo |
| `BillDisputes` | DisputeID, BillID, CustomerID, Reason, Status, ReviewedBy, SubmittedAt |
| `Complaints` | ComplaintID, CustomerID, Category, Description, Priority, Status, AssignedEngineerID, DateSubmitted |
| `ConnectionApplications` | ApplicationID, CustomerID, ApplicationDate, DocumentStatus, ApprovalStatus, RejectionReason, AssignedOfficer, InstallationDate |
| `MaintenanceTasks` | TaskID, ComplaintID, EngineerID, VisitDate, ProgressStatus, Notes, CompletionReport, UpdatedAt |
| `Notices` | NoticeID, Title, Description, Area, NoticeType, PublishedBy, PublishDate |
| `Reports` | ReportID, CreatedBy, ReportType, CreatedDate, Description |

### 🔗 Table Relationships (3NF Normalization)

The database is fully normalized to **Third Normal Form (3NF)**, eliminating transitive dependencies across all tables. Key relationships:

| Relationship | Tables Involved |
|---|---|
| Has Customers | `Users` → `Customers` |
| Publishes Notices | `Users` → `Notices` |
| Creates Reports | `Users` → `Reports` |
| Receives Bills | `Customers` → `Bills` |
| Has Payments | `Bills` → `Payments` |
| Has Disputes | `Bills` + `Users` → `BillDisputes` |
| Applies For Connection | `Customers` + `Users` → `ConnectionApplications` |
| Submits Complaints | `Customers` + `Users` → `Complaints` |
| Creates Maintenance Tasks | `Complaints` + `Users` → `MaintenanceTasks` |
| Assigned To Tasks | `Users` → `MaintenanceTasks` |

---

## 🧠 OOP Concepts Demonstrated

### Classes & Objects
Each form is a class. Objects are instantiated when navigating between forms.
```csharp
AdminDashboardForm adminDashboard = new AdminDashboardForm();
adminDashboard.Show();
```

### Encapsulation
Each form class manages its own controls, state, validation, and SQL operations — no leaking of internal logic.

### Inheritance
All Windows Forms classes inherit from the base `Form` class.
```csharp
public partial class LoginForm : Form { ... }
```

### Event-Driven Programming
UI interactions are handled through event methods such as button clicks and form load events.
```csharp
private void btnLogin_Click(object sender, EventArgs e)
{
    // Authentication logic
}
```

### Separation of Responsibilities
Code is organized by actor into separate folders — Admin, Customer, Service Officer, Maintenance — keeping each module self-contained and maintainable.

---

## 📊 CRUD Operations in the System

| Operation | Example |
|---|---|
| **Create** | Customer submits complaint · Admin creates notice · Service Officer generates bill |
| **Read** | DataGridViews display users, bills, complaints, notices, tasks, and reports |
| **Update** | Admin updates user records · Service Officer corrects bill · Engineer updates repair progress |
| **Delete** | Admin removes notice or user · Customer deletes own account from profile |

---

## ⚙️ Setup Instructions

### Prerequisites

- Windows OS
- [Visual Studio](https://visualstudio.microsoft.com/) (2019 or later recommended)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server) (Express edition is fine)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

### Step-by-Step

**1. Clone the repository**
```bash
git clone https://github.com/pengvil/WASA.git
```

**2. Restore the database**

Open SSMS → Right-click **Databases** → **Restore Database** → Select the backup file:
```
database/WaterSewageManagementDB.bak
```

**3. Open the solution**

Launch Visual Studio and open the `.sln` file from the cloned folder.

**4. Update the connection string**

Make sure the SQL Server connection string in your forms matches your local server setup:
```csharp
string connectionString = @"Data Source=.\SQLEXPRESS;
                            Initial Catalog=WaterSewageManagementDB;
                            Integrated Security=True;
                            TrustServerCertificate=True";
```

**5. Build and run**

Press `F5` or click **Start** in Visual Studio. Make sure SQL Server is running before launching.

---

## 🔑 Demo Credentials

Pre-loaded sample accounts for testing all four roles:

| Role | Email | Password |
|---|---|:---:|
| Admin | admin@gmail.com | `1234` |
| Customer | customer@gmail.com | `1234` |
| Service Officer | service@gmail.com | `1234` |
| Maintenance Engineer | engineer@gmail.com | `1234` |

---

## ⚠️ Known Limitations

- Desktop-only — not available as a web or mobile application
- Online payment gateway not implemented
- SMS / email notifications not implemented
- Cannot directly resolve physical water supply or pipeline infrastructure issues
- Some dashboard counters and reports may require final UI polish before presentation

---

## 🚀 Future Improvements

- [ ] Online payment gateway for water bills
- [ ] SMS and email notifications for bill generation, complaint assignment, and connection status
- [ ] Map/GPS support for complaint locations
- [ ] Dashboard charts for monthly bills, complaints, and maintenance statistics
- [ ] In-app database backup and restore feature
- [ ] Child form panel navigation instead of separate popup windows
- [ ] Stronger password hashing and role-based permission enforcement

---

## 📝 Conclusion

The **Water & Sewage Management System** is a practical C# Windows Forms application built as an OOP2 final project. It includes four well-defined actors, role-based login, a relational SQL Server database normalized to 3NF, and complete modules for billing, complaint management, connection applications, maintenance tracking, notices, and reports.

The project is realistic and scope-appropriate for a four-member team, while clearly demonstrating core Object-Oriented Programming concepts through a working desktop application.

---

## 📎 References

| Resource | Link |
|---|---|
| GitHub Repository | [pengvil/WASA](https://github.com/pengvil/WASA) |
| ER Diagram Tool | [app.diagrams.net](https://app.diagrams.net/) |
| C# Windows Forms Docs | [Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/) |
| SQL Server Docs | [Microsoft SQL Server](https://learn.microsoft.com/en-us/sql/sql-server/) |

---

<div align="center">

**Developed for CSC2210 — Object Oriented Programming 2**  
**Supervised by Kazi Sadia &nbsp;|&nbsp; Section P, Group 11 &nbsp;|&nbsp; Spring 2025–2026**  
American International University-Bangladesh (AIUB)

</div>
