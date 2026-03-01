
---

# Assignment: Books CRUD

In this assignment, I implemented a full CRUD (Create, Read, Update, Delete) system for managing a Book collection, integrated with the existing student database structure.

---

## 1- Features Implemented

* **List Books:** Professional  view displaying all books with styled action buttons (Edit/Delete).
* **Create Book:** A form with full server-side and client-side validation.
* **Edit Book:** Update existing book details with validation feedback.
* **Delete Book:** Secure delete confirmation page to prevent accidental data loss.
* **UI Enhancements:** Applied Bootstrap classes, improved layout margins and some color changes.

---

## 2- How to Run the Project Locally

### Option A: Using IDE (Visual Studio / Rider)

1. Clone the repository:

```bash
git clone [GITHUB_LINK]
```

2. Open the `.sln` file in your preferred IDE.
3. Build the project.
4. Run the project (F5 or Run button).

---

### Option B: Using Terminal (CLI)

1. Navigate to the project directory:

```bash
cd CetStudentBook
```

2. Restore dependencies:

```bash
dotnet restore
```

3. Build the project:

```bash
dotnet build
```

4. Run the project:

```bash
dotnet run
```

---

## 3- Database & Migration Setup

This project uses **Entity Framework Core (EF Core) – Code-First Migrations**.
Before running the application, synchronize the database schema with your local SQL Server instance.

---

### Using Visual Studio (Package Manager Console)

1. Open:

`Tools > NuGet Package Manager > Package Manager Console`

2. Ensure the **Default Project** is set to the project containing `ApplicationDbContext`.

3. Run:

```powershell
Update-Database -Context ApplicationDbContext
```

---

### Using Terminal / CLI (Rider or Command Line)

1. Install EF Core CLI tool (if not installed):

```bash
dotnet tool install --global dotnet-ef
```

2. Apply the migrations:

```bash
dotnet ef database update --context ApplicationDbContext
```

---

## Important Notes

* Ensure the connection string in `appsettings.json` points to your local SQL Server.
* If multiple startup projects exist, verify that the correct one is selected.
* Make sure the project builds successfully before applying migrations.

---

## 4- Screenshots

### Books List Page

![Books List Page](Screenshots/books_list_page.png)

### Edit Page (Validation Example)

![Edit Page with Validation](Screenshots/edit_page_with_validation.png)

###  Delete Confirmation Page

![Delete Confirmation Page](Screenshots/delete_confirmation.png)

---

