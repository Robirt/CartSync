var webApplicationBuilder = WebApplication.CreateBuilder(args);

webApplicationBuilder.Services.AddCors();

webApplicationBuilder.Services.AddRouting();

webApplicationBuilder.Services.AddAuthentication();

webApplicationBuilder.Services.AddAuthorization();

webApplicationBuilder.Services.AddControllers();

var webApplication = webApplicationBuilder.Build();

webApplication.UseHttpsRedirection();

webApplication.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

webApplication.UseRouting();

webApplication.UseAuthentication();

webApplication.UseAuthorization();

webApplication.MapControllers();

webApplication.Run();
