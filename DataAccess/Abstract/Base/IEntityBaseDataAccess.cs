using JSGABackend.Entity.Abstract;
using System.Linq.Expressions;

namespace JSGABackend.DataAccess.Abstract.Base
{
	public interface IEntityBaseDataAccess<TEntity> where TEntity : class, IEntity, new()
	{
		/**
		 * Getirme
		 * Ekleme
		 * Silme
		 * Güncelleme
		 */

		#region Getirme
		Task<List<TEntity>> GetByFilterAsync (Expression<Func<TEntity, bool>>? filter = null);
		Task<int> GetTotalCountByFilterAsync(Expression<Func<TEntity, bool>>? filter = null);

		Task<List<TEntity>> GetPaginationByFilterAsync(
			int pageItemsCount, 
			int pageIndex,
			bool desc = false, 
			Expression<Func<TEntity, bool>>? filter = null);
		Task<List<TEntity>> GetPaginationByFilterAsync<TKey>( 
			int pageItemsCount,
			int pageIndex,
			bool desc = false,
			Expression<Func<TEntity,bool>>? filter = null,
			Expression<Func<TEntity,TKey>>? orderFilter = null);

		#endregion

		#region Kaydetme
		Task<TEntity> CreateAsync(TEntity entity,DateTime createTime);

		#endregion

		#region Günclleme
		Task<TEntity> UpdateAsync(TEntity entity,DateTime updateTime);

		#endregion

		#region Silme
		Task<TEntity> DeleteAsync(TEntity entity,DateTime deletedTime);

		#endregion
	}
}
