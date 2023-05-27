using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(option=>option.JsonSerializerOptions.ReferenceHandler=ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBrandService, BrandManager>();
builder.Services.AddScoped<IBrandDal, BrandDal>();
builder.Services.AddScoped<IModelService,ModelManager>();
builder.Services.AddScoped<IModelDal, ModelDal>();

builder.Services.AddCors(opt => opt.AddDefaultPolicy(p => { p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); }));

 

var app = builder.Build();

app.UseCors(opt =>
                opt.WithOrigins("http://localhost:4200")
                   .AllowAnyHeader()
                   .AllowAnyMethod()
                   .AllowCredentials());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
