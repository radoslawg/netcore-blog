using Blog.Data;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

// Initialize SQLite
Batteries.Init();

var builder = WebApplication.CreateBuilder(args);

// Configure services before building the app
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

// Read connection string from configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(connectionString));

var app = builder.Build();

app.UseMvcWithDefaultRoute();

app.Run();
