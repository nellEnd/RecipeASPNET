

using Microsoft.EntityFrameworkCore;
using Receptbas_ASPNET.Repository.Entities;
using Receptbas_ASPNET.Repository.Interfaces;
using Receptbas_ASPNET.Repository.Repos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


builder.Services.AddDbContext<RecipeContext>(
            options => options.UseSqlServer(@"Data Source=localhost;Initial Catalog=RecipeDB;Integrated Security=SSPI;TrustServerCertificate=True;")
            );

builder.Services.AddTransient<IRecipeRepo, RecipeRepo>();
builder.Services.AddTransient<IUserRepo, UserRepo>();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => {  endpoints.MapControllers(); });

app.Run();

