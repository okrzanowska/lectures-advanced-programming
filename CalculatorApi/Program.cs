var builder = WebApplication.CreateBuilder(args);

// Rejestracja us³ug MVC (obs³uga kontrolerów)
builder.Services.AddControllers();

var app = builder.Build();

// Mapowanie kontrolerów
app.MapControllers();

app.Run();
