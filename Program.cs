using Blog.Data;
using Blog.Services;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });

builder.Services.AddDbContext<BlogDataContext>();
builder.Services.AddTransient<TokenService>(); // Sempre cria um novo
//builder.Services.AddScoped(); // Um por transação
//builder.Services.AddSingleton(); // Singleton -> 1 por App

var app = builder.Build();

app.MapControllers();

app.Run();
