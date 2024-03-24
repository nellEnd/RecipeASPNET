

using Microsoft.EntityFrameworkCore;
using Receptbas_ASPNET.Repository.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


builder.Services.AddDbContext<RecipeContext>(
            options => options.UseSqlServer(@"Data Source=localhost;Initial Catalog=RecipeDB;Integrated Security=SSPI;TrustServerCertificate=True;")
            );

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => {  endpoints.MapControllers(); });

app.Run();

