var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");



// 1

// 2

// 3

//TEST TOTO
app.Run();
