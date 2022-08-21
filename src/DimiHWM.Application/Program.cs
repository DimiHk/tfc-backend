using DimiHWM.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();

    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddSwaggerGen();

    builder.Configuration
   .SetBasePath(Directory.GetCurrentDirectory() + "\\Settings")
   .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true);

    builder.Services.AddInfrastructure(builder.Configuration);
}

var app = builder.Build();
{
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();
}

app.Run();