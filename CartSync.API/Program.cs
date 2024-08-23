using CartSync.API;
using CartSync.Infrastructure;
using Microsoft.EntityFrameworkCore;

var webApplicationBuilder = WebApplication.CreateBuilder(args);

webApplicationBuilder.Services.AddCors(options => options.AddDefaultPolicy(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

webApplicationBuilder.Services.AddRouting();

webApplicationBuilder.Services.AddAuthentication();

webApplicationBuilder.Services.AddAuthorization();

webApplicationBuilder.Services.AddRepositories();

webApplicationBuilder.Services.AddServices();

webApplicationBuilder.Services.AddDbContext<CartSyncDbContext>(options => options.UseSqlServer(webApplicationBuilder.Configuration.GetConnectionString("CartSync")));

webApplicationBuilder.Services.AddControllers();

var webApplication = webApplicationBuilder.Build();

webApplication.UseHttpsRedirection();

webApplication.UseCors();

webApplication.UseRouting();

webApplication.UseAuthentication();

webApplication.UseAuthorization();

webApplication.MapControllers();

await webApplication.MigrateDatabaseAsync();

webApplication.Run();
