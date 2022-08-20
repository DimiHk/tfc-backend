var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();

    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();
}

builder.Configuration
   .SetBasePath(Directory.GetCurrentDirectory() + "\\Settings")
   .AddJsonFile($"appsettings.{app.Environment.EnvironmentName}.json", true, true);

app.Run();