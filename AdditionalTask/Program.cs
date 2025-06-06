// Example ASP.NET Core Web API for managing students minimal API style
// Fill all the TODO gaps
using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// In-memory student "database"
var students = new ConcurrentDictionary<int, Student>();

// GET all students
app.MapGet("/students", () =>
{
    // TODO: Return all students from the dictionary
});

// GET a student by ID
app.MapGet("/students/{id:int}", (int id) =>
{
    // TODO: Try to find a student by ID and return it
    // Return 404 if not found
});

// POST - create a new student
app.MapPost("/students", ([FromBody] StudentDto dto) =>
{
    // TODO: Generate a new ID, create a student object, and add it to the dictionary
    // Return 201 Created with the new student
});

// PUT - update the student
app.MapPut("/students/{id:int}", (int id, [FromBody] StudentDto dto) =>
{
    // TODO: Replace all fields of a student with the new values
    // Return 404 if the student does not exist
});

// DELETE - remove a student
app.MapDelete("/students/{id:int}", (int id) =>
{
    // TODO: Remove the student from the dictionary by ID
    // Return 200 OK or 404 Not Found
});

// PATCH - update only the Major field
app.MapMethods("/students/{id:int}/major", new[] { "PATCH" }, (int id, [FromBody] string newMajor) =>
{
    // TODO: Only update the Major of the specified student
    // Return 404 if not found
});

// HEAD - check if student exists (without returning content)
app.MapMethods("/students/{id:int}", new[] { "HEAD" }, (int id) =>
{
    // TODO: Return 200 OK if exists, 404 otherwise
});

// OPTIONS - list supported HTTP methods
app.MapMethods("/students", new[] { "OPTIONS" }, () =>
{
    // TODO: Return a plain text list of supported HTTP methods for this endpoint
});

app.Run();


// Student entity model
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Major { get; set; } = string.Empty;
    public int Year { get; set; }
}

// Data Transfer Object used for POST and PUT
public class StudentDto
{
    public string Name { get; set; } = string.Empty;
    public string Major { get; set; } = string.Empty;
    public int Year { get; set; }
}