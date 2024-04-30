var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");



// 1

// 2

// 2.5
// 3

//TEST TOTO
app.Run();
