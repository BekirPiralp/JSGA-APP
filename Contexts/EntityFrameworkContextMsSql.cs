using Microsoft.EntityFrameworkCore;

namespace Contexts
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
			base.OnConfiguring(optionsBuilder);
		}
	}
}
