using BusinessObjects.Models;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PRN231PE_FA22_StudentCodeContext>(option => option.UseInMemoryDatabase("PRN231PE_FA22_StudentCodeContext"));
builder.Services.AddControllers().AddOData(option => option.Select().Filter().Count().OrderBy().Expand().SetMaxTop(100).AddRouteComponents("odata", GetEdmModel()));
builder.Services.AddDbContext<PRN231PE_FA22_StudentCodeContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("prn_db")));

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

static IEdmModel GetEdmModel()
{
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    //var entityBookSet = builder.EntitySet<Book>("Books");
    //entityBookSet.EntityType.HasKey(entity => entity.Id);
    builder.EntitySet<Company>("Company");
    builder.EntitySet<HRStaff>("HRStaff");
    builder.EntitySet<Renting>("Renting");
    builder.EntitySet<PropertyProfile>("PropertyProfile");
    return builder.GetEdmModel();
}