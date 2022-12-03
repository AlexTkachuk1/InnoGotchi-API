using AutoMapper;
using Microsoft.EntityFrameworkCore;
using InnoGotchi.BLL.Interfaces;
using InnoGotchi.BLL.Services;
using InnoGotchi.DAL.EF;
using InnoGotchi.DAL.Interfaces;
using InnoGotchi.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<InnoGotchiDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IUnitOfWork>(container =>
new EFUnitOfWork(container.GetService<InnoGotchiDbContext>())
);

builder.Services.AddScoped<IUserService>(container =>
new UserService(container.GetService<IUnitOfWork>())
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages()
                .AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
