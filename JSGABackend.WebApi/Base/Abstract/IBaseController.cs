using JSGABackend.Business.Abstract.Base;
using JSGABackend.Entity.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Base.Abstract
{
    public interface IBaseController<TEntity,TBusiness> where TEntity : class, IEntity
        where TBusiness : IBaseForBusiness<TEntity>
    {
        #region
        public Task<ActionResult<TEntity>> Get(int id);
        public Task<ActionResult<List<TEntity>>> GetAll();
        public Task<ActionResult<int>> GetTotalCount();
        #endregion

        #region Ekleme

        public Task<ActionResult<TEntity>> Add(TEntity entity);

        public Task<ActionResult<bool>> Add(List<TEntity> entities);

        #endregion

        #region Silme

        public Task<ActionResult<bool>> Remove(TEntity entity);

        public Task<ActionResult<bool>> Remove(int Id);

        #endregion

        #region Güncelleme

        public Task<ActionResult<TEntity>> Update(TEntity entity);

        public Task<ActionResult<List<TEntity>>> Update(List<TEntity> entity);

        #endregion
    }
}
