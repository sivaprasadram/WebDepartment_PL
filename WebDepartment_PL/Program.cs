using DepartmentDataAccessLayer.Entities;
using DepartmentDataAccessLayer.IRepositories;
using DepartmentDataAccessLayer.Repositories;
using DepartmentServiceLayer.IServices;
using DepartmentServiceLayer.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DepartmentDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DeptConnectionString")
));


 builder.Services.AddScoped <IDepartmentService, DepartmentService> ();

 builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Department}/{action=Index}/{id?}");

app.Run();
