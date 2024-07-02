using ApplicationSettings;
using AppObjectOlusturucu.Concrete.Service;
using JSGABackend.Business;
using JSGABackend.Contexts;
using JSGABackend.DataAccess.Concrete;
using JSGABackend.Security;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


#region Olusturucu Build 
// Benim  eklediklerim 
builder.Services.OlusturcuServiceCreate<BusinessCreateHandler>();
builder.Services.OlusturcuServiceCreate<SecurityCreateHandler>();

builder.AppSettingsConfigure();


builder.Services.AddDbContext<EntityFrameworkContextMsSql>(op =>
{
    op.UseSqlServer(
        Configuration.create().ConfigManager.GetConnectionString(ConfigurationConnectionStringNames.MsSql),
        b=>b.MigrationsAssembly("JSGABackend.WebApi")
        );
});

#endregion

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
