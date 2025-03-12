var builder = WebApplication.CreateBuilder(args);

// Configure services before building the app
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

var app = builder.Build();

app.UseMvcWithDefaultRoute();

app.Run();
