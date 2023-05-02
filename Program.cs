var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/jamelao", () => "Jamelão é muito bom!");
app.MapGet("/", () => "Hello World!");

app.Run();
