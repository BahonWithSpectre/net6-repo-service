using net6.DapperAccessor;
using net6.DapperAccessor.Repositories;
using net6.DapperAccessor.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<UnitOfWork>();
builder.Services.AddTransient<UserRepository>();
builder.Services.AddTransient<UserService>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
