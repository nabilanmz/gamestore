// The very first lines of code that execute when you run your app
// Basically bootstraps your app

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Whole purpose is to create an instance of WebApplication

// app here is of type WebApplication
// WebApplication is a host, the host of the app
app.MapGet("/", () => "Hello World!");

app.Run();
