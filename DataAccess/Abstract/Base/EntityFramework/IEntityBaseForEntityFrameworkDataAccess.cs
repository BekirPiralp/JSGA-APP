using JSGABackend.Entity.Abstract;

namespace DataAccess.Abstract.Base.EntityFramework
{
	public interface IEntityBaseForEntityFrameworkDataAccess<TEntity>:IEntityBaseDataAccess<TEntity>
		where TEntity : class,IEntity,new()
	{

	}
}
