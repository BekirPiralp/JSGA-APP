using JSGABackend.DataAccess.Abstract.Base;
using JSGABackend.Entity.Abstract;
using JSGABackend.Entity.Extensions;
using JSGABackend.Exceptions;
using JSGABackend.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JSGABackend.DataAccess.Concrete.Base
{
	public class EntityBaseDataAccess<TEntity, TContext> : IEntityBaseDataAccess<TEntity>
		where TEntity : class, IEntity, new()
		where TContext : DbContext, new()
	{

		#region Getirme
		public async Task<List<TEntity>> GetByFilterAsync(Expression<Func<TEntity, bool>>? filter = null)
		{
			List<TEntity> _response;

			using(TContext context = new()) // new() == new TContext()
			{
				DbSet<TEntity> dataBaseEntity= context.Set<TEntity>();

				_response = filter != null ?
					await dataBaseEntity.Where(filter).ToListAsync()
					: await dataBaseEntity.ToListAsync();
			}
			return _response;
		}
		public async Task<int> GetTotalCountByFilterAsync(Expression<Func<TEntity, bool>>? filter = null)
		{
			int _response;

			using(TContext  ctx = new()) // new() == new TContext()
			{
				var dbE = ctx.Set<TEntity>();
				
				_response = filter != null ? 
					(await dbE.Where(filter).ToListAsync()).Count : 
					(await dbE.ToListAsync()).ToList().Count;
			}
			return _response;
		}

		public async Task<List<TEntity>> GetPaginationByFilterAsync(
			int pageItemsCount,
			int pageIndex,
			bool desc = false,
			Expression<Func<TEntity, bool>>? filter = null)
		{
			List<TEntity> _response;
			int count;
			int mod;
			int totalPage;
			int itemIndex;

			count = await this.GetTotalCountByFilterAsync(filter);

			if (count <= 0)
				throw new ArgumentNullException(nameof(count) + " value: " + count);

			if (pageItemsCount <= 0)
				throw new ArgumentException(nameof(pageItemsCount) + " value: " + pageItemsCount);

			if (pageIndex < 0)
				throw new ArgumentException(nameof(pageIndex) + " value: " + pageIndex);
			
			mod = count % pageItemsCount;
			totalPage = mod > 0 ? 
				((count - mod) / pageItemsCount) +1: // mod 0 dan büyük ise bir sayfa daha var demektir(count - mod == 0 => tek sayfa vardır.)
				count / pageItemsCount; // mod == 0 => sayfa sayısı tamdır.

			itemIndex = pageItemsCount * (pageIndex-1); // 4. sayfayı isterken 3. sayfadan itibaren deriz...
			itemIndex = itemIndex < 0 ? 0 : itemIndex; //0. index te sonuç negatif olacağı için 0. indexi veriyoruz.

			if(totalPage<= 1) // istenilen sayfalama sayısında tek sayfa var ise (ör: toplam 100 verili dizide 150 verilik sayfalama yapılırsa...)
				_response= await this.GetByFilterAsync(filter);

			if (pageIndex > totalPage) // istenilen sayfa, toplam sayfadan fazla ise o sayfa yoktur. 
				throw new ArgumentException("Geçersiz istek");

			else
				using (TContext context = new TContext())
				{

					var dataBaseEntity = context.Set<TEntity>();

					if (!desc) // (tersten sıralama == evet) değil ise
					_response = filter != null ?
						await dataBaseEntity.Where(filter)			// filtreye göre
											.Skip(itemIndex)		// ilgili indexten itibaren
											.Take(pageItemsCount)	// ilgili sayıda (yoksa olan miktarını)
											.ToListAsync():			//liste gönder
						await dataBaseEntity
											.Skip(itemIndex)
											.Take(pageItemsCount)
											.ToListAsync();
					else
						_response = filter != null ?
						await dataBaseEntity.Where(filter)          // filtreye göre
											.OrderDescending()
											.Skip(itemIndex)        // ilgili indexten itibaren
											.Take(pageItemsCount)   // ilgili sayıda (yoksa olan miktarını)
											.ToListAsync() :            //liste gönder
						await dataBaseEntity
											.OrderDescending()
											.Skip(itemIndex)
											.Take(pageItemsCount)
											.ToListAsync();
				}

			return _response;
		}
		public async Task<List<TEntity>> GetPaginationByFilterAsync<TKey>(
			int pageItemsCount,
			int pageIndex,
			bool desc = false,
			Expression<Func<TEntity, bool>>? filter = null,
			Expression<Func<TEntity, TKey>>? orderFilter = null)
		{
			List<TEntity> _response;

			int mod;
			int toplamSayi;
			int toplamSayfaSayisi;
			int yer;

			Func<TEntity, int> func = P => P.Id;

			if (pageItemsCount <=0)
				throw new ArgumentException(nameof(pageItemsCount)+" value: "+pageItemsCount);
			if (pageIndex < 0)
				throw new ArgumentException(nameof(pageIndex) + " value: " + pageIndex);

			toplamSayi = await GetTotalCountByFilterAsync(filter);
			mod = toplamSayi % pageItemsCount;
			toplamSayfaSayisi = mod == 0 ? (toplamSayi - mod / pageItemsCount) + 1 : toplamSayi - mod / pageItemsCount;

			if (pageIndex > toplamSayfaSayisi)
				throw new ArgumentException("Olmayan sayfa");
			
			pageIndex = pageIndex <= 0 ? 1 : pageIndex;

			yer = (pageIndex - 1) * pageItemsCount;

			using (TContext context = new TContext())
			{
				var dataBaseEntity = context.Set<TEntity>();

				_response = !desc ?
					filter == null ?
						orderFilter == null ?
							await dataBaseEntity.Skip(yer)
										  .Take(pageItemsCount)
										  .ToListAsync()
							:
							await dataBaseEntity.OrderBy(orderFilter)
										  .Skip(yer)
										  .Take(pageItemsCount)
										  .ToListAsync()
						:
						orderFilter == null ?
							await dataBaseEntity.Where(filter)
										  .Skip(yer)
										  .Take(pageItemsCount)
										  .ToListAsync()
							:
							await dataBaseEntity.Where(filter)
										  .OrderBy(orderFilter)
										  .Skip(yer)
										  .Take(pageItemsCount)
										  .ToListAsync()
					:
					filter == null ?
						orderFilter == null ?
							await dataBaseEntity.OrderDescending()
										  .Skip(yer)
										  .Take(pageItemsCount)
										  .ToListAsync ()
							:
							await dataBaseEntity.OrderByDescending(orderFilter)
										  .Skip(yer)
										  .Take(pageItemsCount)
										  .ToListAsync()
						:
						orderFilter == null ?
							await dataBaseEntity.Where(filter)
										  .OrderDescending()
										  .Skip(yer)
										  .Take(pageItemsCount)
										  .ToListAsync()
							:
							await dataBaseEntity.Where(filter)
										  .OrderByDescending(orderFilter)
										  .Skip(yer)
										  .Take(pageItemsCount)
										  .ToListAsync()
				;
					
			}

			return _response;
		}

		#endregion

		#region Kaydetme
		public async Task<TEntity> CreateAsync(TEntity entity, DateTime createTime)
		{
			entity.KayitZamani = createTime;
			using(TContext context = new TContext())
			{
				context.Entry(entity).State = EntityState.Added;
				int response = await context.SaveChangesAsync();
				if (response <= 0)
					throw new CreateException();
			}
			return entity;
		}

		#endregion

		#region Günclleme
		public async Task<TEntity> UpdateAsync(TEntity entity, DateTime updateTime)
		{
			entity.GuncellemeZamani=updateTime;
			using(TContext context = new TContext())
			{
				
				context.Entry(entity).State = EntityState.Modified;
				int response = await context.SaveChangesAsync();

				if(response <= 0) throw new UpdateException();	
			}
			return entity;
		}

		#endregion

		#region Silme
		public async Task<TEntity> DeleteAsync(TEntity entity, DateTime deletedTime)
		{
			if (entity.isDeleted())
				throw new DeletedException();
			using(TContext context = new TContext())
			{
				context.Entry(entity).State= EntityState.Deleted;
				int response = await context.SaveChangesAsync();

				if(response <= 0) throw new DeleteException();
			}
			return entity;
		}

		#endregion
	}
}
