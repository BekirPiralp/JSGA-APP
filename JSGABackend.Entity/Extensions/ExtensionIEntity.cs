using JSGABackend.Entity.Abstract;

namespace JSGABackend.Entity.Extensions
{
	public static class ExtensionIEntity
	{
		/// <summary>
		/// Veri Boş ise Null yollar
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public static bool isNull( this IEntity entity) => entity == null;

		/// <summary>
		/// Id is not empity or zero. 
		/// Id > 0 && entity isn't empity => return True .
		/// Id <= 0 || entity isn't empity => return False .
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public static bool isId( this IEntity entity)
		{
			bool response;
			/**
			 * !entity.isNull() && entity.Id != null || 
			 * ifadesinde int değeri null olamayacağı için
			 * çıkarılmıştır.
			 */
			response = !entity.isNull() && entity.Id > 0;
			return response;
		}

		/// <summary>
		/// This is return true to Entity is not null and, entity id is less than or equals to zero
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public static bool isNotId ( this IEntity entity)
		{
			bool response;
			response = !entity.isNull() && entity.Id <= 0;
			return response;
		}

		/// <summary>
		///  Return True if entity is not null, entity id is not zero and entity created time is not null
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public static bool isNotEmpity ( this IEntity entity)
		{
			bool response;
			response = entity.isId() && entity.KayitZamani != null;
			return response;
		}

		/// <summary>
		/// Return true is entity isn't null and it's id equals to zero or kayitZamani equals to null 
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public static bool isEmpity ( this IEntity entity)
		{
			bool response;
			response = !entity.isNull() && (entity.Id == 0 || entity.KayitZamani == null);
			return response;
		}

		/// <summary>
		/// Entity is not empity and 
		/// entity sildurum is equals to true or 
		/// entity silmezamani is not equals null 
		/// return true
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public static bool isDeleted(this IEntity entity)
		{
			bool response;
			response = entity.isNotEmpity() && (entity.SilDurum == true || entity.SilmeZamani != null);
			return response;
		}
	}
}
