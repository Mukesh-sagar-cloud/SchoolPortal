using Microsoft.EntityFrameworkCore;
using SchoolAPI.CustomClasses;
using SchoolAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add DbContext to the DI container
//builder.Services.AddDbContext<SchoolMangementSystemContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("Data Source=DESKTOP-L9I46P8;uid=sa;pwd=sql2014;Initial Catalog=SchoolMangementSystem;TrustServerCertificate=true;persist security info=True; Integrated Security=SSPI;")));

builder.Services.AddDbContext<SchoolMangementSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Data Source=DESKTOP-GDN6AI3\\SQL2014;uid=sa;pwd=sql2014;Initial Catalog=SchoolMangementSystem; TrustServerCertificate=true;persist security info=True;Integrated Security=SSPI;")));

builder.Services.AddControllers();

// Add CORS service
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowReactApp", policy =>
		policy.WithOrigins("http://localhost:3000") // Replace with your frontend URL
			  .AllowAnyHeader()
			  .AllowAnyMethod());
});

//// Register AutoMapper
//builder.Services.AddAutoMapper(typeof(Program));

// Register AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Enable CORS
app.UseCors("AllowReactApp");

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
