using Microsoft.EntityFrameworkCore;

namespace ShopLife.Identity.Domain
{
	public class TradeContext : DbContext
	{
		public TradeContext(DbContextOptions<TradeContext> options)
			: base(options)
		{
		}

		public DbSet<Product> Products { get; set; }

		public DbSet<User> Users { get; set; }
	}
}
