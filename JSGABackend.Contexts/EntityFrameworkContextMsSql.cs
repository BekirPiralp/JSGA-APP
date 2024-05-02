using ApplicationSettings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace JSGABackend.Contexts
{
	public class EntityFrameworkContextMsSql : DbContext
	{
		public EntityFrameworkContextMsSql() : base()
		{

		}

		public EntityFrameworkContextMsSql(DbContextOptions<EntityFrameworkContextMsSql> options) : base(options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				Configuration.create().ConfigManager.GetConnectionString(
					ConfigurationConnectionStringNames.MsSql
					));
			base.OnConfiguring(optionsBuilder);
		}

		DbSet<>
	}
}
