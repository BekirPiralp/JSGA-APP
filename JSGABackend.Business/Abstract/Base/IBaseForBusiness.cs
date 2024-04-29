using JSGABackend.Entity.Abstract;
using JSGABackend.Responses;
using System.Reflection;

namespace JSGABackend.Business.Abstract.Base
{
	public interface IBaseForBusiness<TEntity>
		where TEntity : class,IEntity
	{
		/**
		 * Getirme
		 * Ekleme
		 * Güncelleme
		 * Silme
		 */

		#region Getirme

		public Task<Response<TEntity>> GetByID(int Id);

		/// <summary>
		/// Last item is not deleted!.
		/// </summary>
		/// <returns></returns>
		public Task<Response<TEntity?>> GetLastOrDefault();

		public Task<Response<List<TEntity>>> GetAll();

		public Task<Response<int>>GetCount();

		public Task<Response<List<TEntity>>> GetPage(int pageIndex, int pageItemSize, string? orderField, bool desc);

		public Task<Response<List<TEntity>>> GetSearch(string? searchKey);

		public Task<Response<List<TEntity>>> GetSearchAndPage(int pageIndex, int pageItemSize, string? orderFileds,
			string? searchString, bool desc,params string[]? removeColumns);

		public Task<Response<List<TEntity>>> GetAllRemoved();

		public Task<Response<List<TEntity>>> GetAllNotRemoved();

		public Task<Response<int>> GetRemovedCount();

		public Task<Response<int>> GetNotRemovedCount();

		public Task<Response<int>> GetAllTotalCount();

		#endregion

		#region Ekleme

		public Task<Response<TEntity>> Add(TEntity entity);

		public Task<Response<bool>> Add(List<TEntity> entities);

		#endregion

		#region Silme

		public Task<Response<bool>> Remove(TEntity entity);

		public Task<Response<bool>> Remove(int Id);

		#endregion

		#region Güncelleme

		public Task<Response<TEntity>> Update(TEntity entity);

		public Task<Response<List<TEntity>>> Update(List<TEntity> entity);

		#endregion
	}
}
