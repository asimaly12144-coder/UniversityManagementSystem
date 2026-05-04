# 🎓 University Management System - ASP.NET Core Web API

A clean, scalable, and production-ready ASP.NET Core Web API project for managing university operations such as students, courses, departments, and enrollments. Built using Entity Framework Core with RESTful architecture.

---

## 📌 Features

* RESTful API (GET, POST, PUT, DELETE)
* Student Management System
* Course Management System
* Department Management
* Enrollment System (Student-Course Mapping)
* Entity Framework Core Integration
* SQL Server Database
* Swagger UI for API Testing
* Clean and maintainable architecture

---

## 🛠️ Tech Stack

* Backend: ASP.NET Core Web API
* Language: C#
* Database: SQL Server
* ORM: Entity Framework Core
* Tools: Visual Studio / VS Code / Swagger

---

## 📁 Project Structure

UniversityManagmentSystem/
├── Controllers/
│   ├── StudentsController.cs
│   ├── CoursesController.cs
│   ├── DepartmentsController.cs
│
├── Models/
│   ├── Student.cs
│   ├── Course.cs
│   ├── Department.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Migrations/
├── appsettings.json
├── Program.cs

---

## ⚙️ Prerequisites

* .NET SDK (6 or later)
* SQL Server
* Visual Studio / VS Code
* Git

---

## 📥 Clone the Repository

git clone https://github.com/your-username/UniversityManagmentSystem.git  
cd UniversityManagmentSystem  

---

## 🔧 Configure Connection String

"ConnectionStrings": {
  "DefaultConnection": "Server=DESKTOP-UC2UT6M;Database=UniversityDataBase;Trusted_Connection=True;TrustServerCertificate=True;"
}

---

## 🧱 Add Migration & Create Database

dotnet ef migrations add InitialCreate  
dotnet ef database update  

---

## ▶️ Run the Application

dotnet run  

Swagger UI:
https://localhost:5001/swagger  

---

## 🗄️ Database Schema

Student Table:
- Id (PK)
- Name
- Email
- DepartmentId (FK)

Course Table:
- Id (PK)
- Title
- Credits

Department Table:
- Id (PK)
- Name

---

## 📚 EF Core Commands

dotnet ef migrations add Name  
dotnet ef database update  
dotnet ef migrations remove  
dotnet ef database drop  

---

## 💻 Sample Code

Student Model:

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int DepartmentId { get; set; }
}

DbContext:

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Department> Departments { get; set; }
}

Controller:

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly AppDbContext _context;

    public StudentsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Students.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var student = _context.Students.Find(id);
        if (student == null)
            return NotFound();

        return Ok(student);
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();
        return Ok(student);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Student student)
    {
        if (id != student.Id)
            return BadRequest();

        _context.Students.Update(student);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var student = _context.Students.Find(id);
        if (student == null)
            return NotFound();

        _context.Students.Remove(student);
        _context.SaveChanges();
        return NoContent();
    }
}

---

## 🔗 API Endpoints

GET /api/students  
GET /api/students/{id}  
POST /api/students  
PUT /api/students/{id}  
DELETE /api/students/{id}  

---

## 👨‍💻 Author

Asim  
asimaly12144@gmail.com  
https://github.com/your-username  

---

## ⭐ Support

If you like this project, give it a ⭐ on GitHub 🚀
