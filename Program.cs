using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieDbRazor.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MovieDbRazorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieDbRazorContext") ?? throw new InvalidOperationException("Connection string 'MovieDbRazorContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); //redirects http requeststo https
app.UseStaticFiles(); //delivery of static files

app.UseRouting();

app.UseAuthorization(); //authorizes user to access resources (could be removed where not applicable)

app.MapRazorPages();

app.Run();
