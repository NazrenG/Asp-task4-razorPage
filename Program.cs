using Asp_Razor_Page.Data;
using Asp_Razor_Page.Repositories;
using Asp_Razor_Page.Services;
using Microsoft.EntityFrameworkCore; 

var builder = WebApplication.CreateBuilder(args);

// Retrieve the connection string from the configuration
var connectionString = builder.Configuration.GetConnectionString("Default");

// Add the DbContext to the services
builder.Services.AddDbContext<ProductDbContext>(options =>
	options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();	

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
