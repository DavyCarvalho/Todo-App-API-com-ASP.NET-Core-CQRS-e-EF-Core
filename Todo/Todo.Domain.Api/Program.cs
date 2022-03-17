using Microsoft.EntityFrameworkCore;
using Todo.Domain.Handlers;
using Todo.Domain.Infra.Contexts;
using Todo.Domain.Infra.Repositories;
using Todo.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder);

var app = builder.Build();

ConfigureApps(app);

void ConfigureServices(WebApplicationBuilder builder)
{
    builder.Services.AddControllers();
    builder.Services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("Database"));
    builder.Services.AddTransient<ITodoRepository, TodoRepository>();
    builder.Services.AddTransient<TodoHandler, TodoHandler>();
}

void ConfigureApps(WebApplication app)
{
    app.MapControllers();
    app.Run();
}
