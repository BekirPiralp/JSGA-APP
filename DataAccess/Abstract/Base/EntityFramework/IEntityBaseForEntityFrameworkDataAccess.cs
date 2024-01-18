using JSGABackend.Entity.Abstract;

namespace JSGABackend.DataAccess.Abstract.Base.EntityFramework
{
	public interface IEntityBaseForEntityFrameworkDataAccess<TEntity>:IEntityBaseDataAccess<TEntity>
		where TEntity : class,IEntity
	{

	}
}
