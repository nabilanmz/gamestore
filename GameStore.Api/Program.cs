// The very first lines of code that execute when you run your app
// Basically bootstraps your app

var builder = WebApplication.CreateBuilder(args);

// Configuration of the request pipeline
var app = builder.Build();

// Whole purpose is to create an instance of WebApplication

// app here is of type WebApplication
// WebApplication is a host, the host of the app

// The host is to introduce HTTP server implementation
// so that you can listen for HTTP requests,
// also stands up a bunch of middleware component, login services, injection services, configuration services etc.

// If a request comes with the GET verb into the root my app, I'm going to reply with this lambda expression 
app.MapGet("/", () => "Hello World!");

app.Run();
