var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");



// 1

// 2

//TEST TOTO
app.Run();
