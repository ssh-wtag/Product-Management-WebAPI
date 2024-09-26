


using data_access.Context;
using data_access.Implementation;
using domain.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add Entity Framework
builder.Services.AddDbContext<ProductManagementDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductConnection")));


// Add Unit Of Work Dependency
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>(); // Whenever it encounters IUnitOfWork, It goes to find UnitOfWork


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
