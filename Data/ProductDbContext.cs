using Asp_Razor_Page.Entities;
using Microsoft.EntityFrameworkCore;

namespace Asp_Razor_Page.Data
{
	public class ProductDbContext : DbContext
	{
		public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
	}
}
