using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using userapi.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Thread.Sleep(1000);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(
                    builder.Configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("crawl1")
                    )
                );

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//    IServiceScope scope = app.Services.CreateScope();
//    AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
//    context.Database.Migrate();
//}

app.UseAuthorization();

app.MapControllers();

app.Run();
