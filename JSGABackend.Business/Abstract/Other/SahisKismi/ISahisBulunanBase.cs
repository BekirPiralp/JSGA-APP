using JSGABackend.Business.Abstract.Base;
using JSGABackend.Entity.Concrete.Other.SahisKismi;
using JSGABackend.Responses;

namespace JSGABackend.Business.Abstract.Other.SahisKismi
{
    public interface ISahisBulunanBase <TEntity> : IBaseForBusiness<TEntity>
        where TEntity : SahisBulunanBase
    {
        public Task<Response<bool>> PasifeAl(int Id);

        /// <summary>
        /// Sahis id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<Response<bool>> PasifeAlAll(int Id);

        public Task<Response<bool>> PasifeAl(Sahis sahis);

        /// <summary>
        /// Sahis Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<Response<TEntity>> GetBySahis(int Id);
        public Task<Response<TEntity>> GetBySahis(Sahis sahis);

        public Task<Response<List<TEntity>>> GetAllBySahis(int Id);
    }
}
