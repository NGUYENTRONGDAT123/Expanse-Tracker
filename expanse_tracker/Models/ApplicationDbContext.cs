using Microsoft.EntityFrameworkCore;

namespace expanse_tracker.Models
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions options): base(options)
		{
		}

		public DbSet<Transaction> Transations { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}

