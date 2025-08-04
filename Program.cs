using JobTracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();

// SQL Server connection
var connectionString = Environment.GetEnvironmentVariable("postgresql://postgres:HNbddSxZqLnJgVDXDphjkabMyNphScuF@postgres.railway.internal:5432/railway")
    ?? builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));


// Tell Kestrel to listen on all network interfaces on port 80
builder.WebHost.UseUrls("http://0.0.0.0:80");

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// MVC route config
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Jobs}/{action=Index}/{id?}");

// ✅ Seed sample data BEFORE app.Run()
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    // You can add seeding logic here if needed
}

app.Run(); // 👈 KEEP THIS AT THE END
