using JSGABackend.Business.Abstract.Base;
using JSGABackend.DataAccess.Abstract.Base;
using JSGABackend.Entity.Abstract;
using AppObjectOlusturucu.Concrete;
using JSGABackend.Responses;
using JSGABackend.Entity.Extensions;
using AppObjectOlusturucu.Concrete.Exceptions;
using System;
using Microsoft.EntityFrameworkCore.Query;
using QueryToExpression;
using System.Linq.Expressions;

namespace JSGABackend.Business.Concrete.Base
{
    public class BaseForBusiness<TIDataAccess,TEntity> : IBaseForBusiness<TEntity>
    where TIDataAccess : class, IEntityBaseDataAccess<TEntity>
    where TEntity : class, IEntity
    {
        private TIDataAccess _dataAccess;

        protected TIDataAccess dataAccess{
            get
            {
                return this._dataAccess;
            }
        }

        public BaseForBusiness()
        {
            var result = Olusturucu.olustur.GetObj<TIDataAccess>();

            if(result == null)
                throw new NullReferenceException(nameof(TIDataAccess));
            
            this._dataAccess = result;
        }

        #region  Ekleme
        public async Task<Response<TEntity>> Add(TEntity entity)
        {
            Response<TEntity> response;
            if(entity.isEmpity()){
                try
                {
                    var result = await this._dataAccess.CreateAsync(entity,DateTime.UtcNow);

                    if(result.isNotEmpity())
                        response = new Response<TEntity>(result,true);
                    else
                        response = new Response<TEntity>(false,$"{(typeof (TEntity)).FullName} is empity");
                }
                catch (Exception e)
                {
                    response = new Response<TEntity>(false,e.Message);
                }
                
            }
            else
            {
                response = new Response<TEntity>(false,$"This {(typeof (TEntity)).FullName} has been created before!");
            }

            return response;
        }

        public async Task<Response<bool>> Add(List<TEntity> entities)
        {
            Response<bool> response = null!;

            if(entities != null && entities.Count > 0){
                foreach (var entity in entities)
                {
                    if(entity.isEmpity()){
                        var result = await this.Add(entity);

                        if(!result.Status){
                            response = new Response<bool>(result.Message);
                            break;
                        }
                    }
                    else{
                        response = new Response<bool>("Nesne yüklü geldi");
                        break;
                    }
                }
                if(response == null)
                    response = new(true,true);
            }
            else
            response = new Response<bool>("Eksik parametre");

            return response;
        }

        #endregion





        #region  Getirme
        public async Task<Response<List<TEntity>>> GetAll()
        {
            Response<List<TEntity>> response;
            try
            {
                var result = await this._dataAccess.GetByFilterAsync();

                if (result != null && result.Count > 0)
                {
                    response = new(result,true);
                }
                else
                throw new NullReferenceException("Nesneler gelmedi.");
            }
            catch (Exception e)
            {
                response = new(e.Message);
            }
            return response;
        }

        public async Task<Response<List<TEntity>>> GetAllRemoved()
        {
            Response<List<TEntity>> response;
            try
            {
                var result = await this._dataAccess.GetByFilterAsync(P=>P.isDeleted());
                
                if(result == null || result.Count <= 0)
                throw new NullReferenceException("Nesneler getirilemedi.");

                response = new(result,true);
            }
            catch (Exception e)
            {
                response = new(e.Message);
            }

            return response;
        }

        public async Task<Response<int>> GetAllTotalCount()
        {
            Response<int> response;
            try
            {
                var result = await this._dataAccess.GetTotalCountByFilterAsync();

                if(result < 0)
                throw new NullReferenceException("Nesne sayısı negatif döndü");

                response = new(result,true);

            }
            catch (Exception e)
            {
                response = new(e.Message);
            }

            return response;
        }

        public async Task<Response<TEntity>> GetByID(int Id)
        {
            Response<TEntity> response;
            try
            {
                if(Id <= 0)
                throw new ArgumentNullException("Id değeri olarak geçersiz parametre verildi.");

                var result = (await this._dataAccess.GetByFilterAsync(P=>P.Id==Id)).FirstOrDefault();

                if(result!.isNull() || result!.isEmpity())
                throw new NullReferenceException($"Aranan {Id} ID'li {typeof(TEntity).Name} nesnesi getirilemedi.");

                response = new(result!,true);
            }
            catch (Exception e)
            {
                response = new(e.Message);
            }
            return response;
        }

        public async Task<Response<int>> GetCount()
        {
            
            Response<int> response;
            try
            {
                var result = await this._dataAccess.GetTotalCountByFilterAsync(P=>!P.isDeleted());

                if(result < 0)
                throw new NullReferenceException("Nesne sayısı negatif döndü");

                response = new(result,true);

            }
            catch (Exception e)
            {
                response = new(e.Message);
            }

            return response;
        }

        public async Task<Response<List<TEntity>>> GetPage(int pageIndex, int pageItemSize, string? orderField, bool desc = false)
        {
            Response<List<TEntity>> response;
            try{
                if(pageIndex < 0 || pageItemSize <= 0 )
                    throw new ArgumentException("Geçersiz parametreler");

                Expression<Func<TEntity,object>> resultFilter = null!;

                if(orderField != null && orderField.Trim().Count() > 0)
                    resultFilter = await Converter<TEntity>.OrderExpressionConverter(orderField);

                var result = await this._dataAccess.GetPaginationByFilterAsync(pageItemSize, pageIndex, desc, null, resultFilter);

                if(result == null || result.Count() <= 0)
                    throw new NullReferenceException("İstenilen nesneler getirilemedi.");

                response = new(result,true);

            }
            catch(Exception e){
                response = new(e.Message);
            }

            return response;
        }

        public async Task<Response<int>> GetRemovedCount()
        {
            
            Response<int> response;
            try
            {
                var result = await this._dataAccess.GetTotalCountByFilterAsync(p=>p.isDeleted());

                if(result < 0)
                throw new NullReferenceException("Nesne sayısı negatif döndü");

                response = new(result,true);

            }
            catch (Exception e)
            {
                response = new(e.Message);
            }

            return response;
        }

        
        public async Task<Response<List<TEntity>>> GetAllNotRemoved()
        {
            Response<List<TEntity>> response;
            try
            {
                var result = await this._dataAccess.GetByFilterAsync(p=>!p.isDeleted());

                if(result == null || result.Count <= 0)
                throw new NullReferenceException("Nesneler getirelemedi.");

                response = new(result,true);
            }
            catch (Exception e)
            {
                response = new(e.Message);
            }
            return response;
        }

        public async Task<Response<int>> GetNotRemovedCount()
        {
            Response<int> response;
            try
            {
                var result = await this._dataAccess.GetTotalCountByFilterAsync(p=>!p.isDeleted());

                if(result < 0)
                throw new NullReferenceException("Negatif sayı döndü.");

                response = new(result,true);
            }
            catch (Exception e)
            {
                response = new(e.Message);
            }
            return response;
        }

        public async Task<Response<List<TEntity>>> GetSearch(string? searchKey)
        {
            Response<List<TEntity>> response;
            Expression<Func<TEntity,bool>> searchQuery;
            try
            {
                if(searchKey == null || searchKey.Trim().Length <= 0)
                    throw new ArgumentNullException($"{nameof(searchKey)} parametresi geçersizdir.");

                searchQuery = await Converter<TEntity>.SearchExpressionConverter(searchKey,nameof(IEntity.Id));

                var result = await this._dataAccess.GetByFilterAsync(searchQuery);

                if(result == null || result.Count <= 0)
                    throw new NullReferenceException("Aranan nesneler bulunamadı.");
                response = new(result, true);
            }
            catch (Exception e)
            {
                response = new(e.Message);
            }
            return response;
        }

        public async Task<Response<List<TEntity>>> GetSearchAndPage(int pageIndex, int pageItemSize, string? orderFileds, string? searchString, bool desc = false, params string[]? removeColumns)
        {
            Response<List<TEntity>> response;
            Expression<Func<TEntity,bool>> searchQuery = null!;
            Expression<Func<TEntity,object>> orderQuery = null!;

            try
            {
                if(pageIndex < 0 || pageItemSize <= 0 || searchString == null || searchString.Trim().Length <= 0 )
                    throw new ArgumentException("Geçersiz parametreler");

                if(orderFileds != null && orderFileds.Trim().Length > 0)
                    orderQuery = await Converter<TEntity>.OrderExpressionConverter(orderFileds);

                if(searchString != null && searchString.Trim().Length > 0 && ( removeColumns == null || removeColumns.Length <= 0 ))
                    searchQuery = await Converter<TEntity>.SearchExpressionConverter(searchString);

                if(searchString != null && searchString.Trim().Length > 0 && removeColumns != null && removeColumns!.Length > 0 )
                    searchQuery = await Converter<TEntity>.SearchExpressionConverter(searchString, removeColumns!);
                
                var result = await this._dataAccess.GetPaginationByFilterAsync(pageItemSize, pageIndex, desc, searchQuery, orderQuery);

                if(result == null || result.Count <= 0)
                    throw new NullReferenceException("Aranan nesneler bulunamadı.");
                
                response = new(result, true);
            }
            catch (Exception e)
            {
                response = new(e.Message);
            }
            return response;
        }
        #endregion




        
        #region Silme
        public async Task<Response<bool>> Remove(TEntity entity)
        {
            Response<bool> response;
            try
            {
                if(entity.isNull() || entity.isEmpity())
                    throw new ArgumentNullException("Geçersiz parametre");
                
                if(entity.isDeleted())
                    response = new(true,true);
                
                else
                {
                    var result = await this._dataAccess.DeleteAsync(entity,DateTime.UtcNow);
                    
                    if(result.isDeleted())
                        response = new( true, true);
                    else
                        throw new Exception("Nesne silinemedi."); 
                }

            }
            catch (Exception e)
            {
                response = new(e.Message);
            }
            return response;
        }

        public async Task<Response<bool>> Remove(int Id)
        {
            Response<bool> response;
            try
            {
                if(Id <= 0)
                    throw new ArgumentNullException("Geçersiz Id"); 
                
                var entity = (await this._dataAccess.GetByFilterAsync( p => p.Id == Id )).FirstOrDefault();

                if(entity!.isNull()||entity!.isEmpity())
                    throw new NullReferenceException("İlgili nesne bulunamadı.");
                
                var result = await this._dataAccess.DeleteAsync( entity!, DateTime.UtcNow);

                if(result.isDeleted())
                    response = new( true, true);
                else
                    throw new Exception("Nesne silinemedi");
            }
            catch (Exception e)
            {
                response = new(e.Message);
            }

            return response;
        }

        #endregion





        #region Güncelleme
        public async Task<Response<TEntity>> Update(TEntity entity)
        {
            Response<TEntity> response;
            try
            {
                if(entity.isNull() || entity.isEmpity())
                    throw new ArgumentException("Geçersiz nesne");
                
                var result = await this._dataAccess.UpdateAsync( entity, DateTime.UtcNow);

                if(result.isNull() || result.isEmpity())
                    throw new NullReferenceException(" Nesne geri çevrilemedi.");
                
                response = new(result, true);
            }
            catch (Exception e)
            {
                response = new(e.Message);
            }
            return response;
        }

        public async Task<Response<List<TEntity>>> Update(List<TEntity> entity)
        {
            Response<List<TEntity>> response;
            try
            {
                if(entity == null || entity.Count <= 0)
                    throw  new ArgumentNullException("Geçersiz parametre");
                
                for(int a = 0; a < entity.Count; a++){
                    var result = await this.Update(entity[a]);

                    if(!result.Status){
                        throw new Exception("Güncelleme esnasında hata ile karşılaşıldı");
                    } 

                    entity[a] = result.Value!;
                }

                response = new(entity , true);
            }
            catch (Exception e)
            {
                response = new(e.Message);
            }
            return response;
        }

        #endregion
    }
}