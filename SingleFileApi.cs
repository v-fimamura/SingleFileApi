#:sdk Microsoft.NET.Sdk.Web

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from .NET 10 on a single file!");
app.MapGet("/time", () => DateTime.Now.ToString("F"));
app.MapGet("/greet/{name}", (string name) => $"Hello, {name}!");
app.MapPost("/echo", (string message) => $"You said: {message}");

app.Run();