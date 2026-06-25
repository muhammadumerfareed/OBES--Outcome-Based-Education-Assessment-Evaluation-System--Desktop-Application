# Student Evaluation System (OBE)

A C# WinForms desktop application built to automate Outcome Based Education (OBE) evaluation for lab instructors.

Before this system, university lab marks were calculated by hand, requiring instructors to manually map fractional marks across multiple learning outcomes and rubrics. This project digitizes that entire administrative workflow.

---

## 🚀 The Problem & Solution

The CS department runs on an Outcome Based Education (OBE) model. Each lab assessment component maps to Course Learning Outcomes (CLOs) and specific Rubric Levels. Marks are calculated using the following formula:

$$Obtained\ Marks = \left( \frac{Student\ Rubric\ Level}{Max\ Rubric\ Level} \right) \times Component\ Marks$$

This application automates this entire calculation process, provides a management interface, and auto-generates PDF reports.

---

## 🏗️ Architecture & Engineering Constraints

This project was built under strict academic engineering constraints to demonstrate low-level database proficiency:

* **Zero ORM:** Entity Framework was strictly forbidden. Every database operation uses hand-written, parameterized SQL queries via `MySqlConnection` (ADO.NET).
* **3-Layer Architecture:** Clean separation of concerns:
    * **UI Layer:** WinForms with DataGridViews and event handlers (No business logic).
    * **Business Logic Layer (BLL):** Handles mark calculations, data validation, and report triggers.
    * **Data Access Layer (DAL):** Dedicated solely to executing raw SQL queries.
* **Read-Only Schema:** The database schema was fixed and could not be altered dynamically.

---

## 🗄️ Database Schema

Backed by MySQL 8.0, the database is fully normalized with 9 tables.

* **Core Dependency Chain:** `CLO` → `Rubric` → `RubricLevel` → `AssessmentComponent` → `StudentResult`.
* **Data Integrity:** Utilizes composite primary keys, such as `(StudentId, AssessmentComponentId)` on the `StudentResult` table.
* **Enum Store Optimization:** Instead of multiple distinct status tables, a single `Lookup` table with a `Category` column handles all attendance and student status codes (Active/Inactive).

---

## ✨ Features

* **Student & Class Management:** Full CRUD operations for managing students and toggling statuses.
* **OBE Mapping:** Create and track Course Learning Outcomes (CLOs), attach evaluation Rubrics, and define Rubric Levels (1–4).
* **Assessments:** Map specific lab tasks/questions to a rubric and assign weightage/marks.
* **Mark Evaluations:** Select a student and component, assign a rubric level, and let the system auto-calculate the final marks.
* **Attendance Tracking:** Record class sessions as Present, Absent, Late, or Leave via the `Lookup` table.
* **Automated PDF Reports:** Export data using a specialized PDF generator:
    * CLO-wise class results (level attainment per student).
    * Assessment-wise results (marks across all components).
    * Class attendance summaries.

---

## 🛠️ Tech Stack

* **Frontend/UI:** C# WinForms
* **Backend Logic:** C# (.NET)
* **Database:** MySQL 8.0
* **Data Access:** ADO.NET (Raw SQL via `MySqlConnection`)
* **Reporting:** PDF Export Generation

---

## ⚙️ Running Setup & Installation

Follow these steps to configure the database and run the application locally:

### 1. Clone & Open
Clone the repository and open the solution (`.sln`) in Visual Studio.

### 2. Setup the Database
1. Open **MySQL Workbench**.
2. Create a new database by running the following SQL command:
   ```sql
   CREATE DATABASE projectbdb26;
   ```
3. Open the provided `.sql` script file in MySQL Workbench. Ensure `projectbdb26` is set as your default/active schema, and execute the script to generate all 9 tables.

### 3. Configure the Connection String
In Visual Studio, navigate to your **Data Access Layer (DAL)** and open the `DatabaseHelper.cs` class. Locate the `connectionString` variable and update it (make sure to add your local MySQL root password after `Pwd=`):

```csharp
private static string connectionString = "Server=localhost;Port=3306;Database=projectbdb26;Uid=root;Pwd=YOUR_PASSWORD_HERE;";
```

### 4. Build and Run
Build and Run the project in Visual Studio (`F5`).
