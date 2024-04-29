using JSGABackend.Business.Abstract.Other.SahisKismi;
using JSGABackend.DataAccess.Abstract.Base;
using JSGABackend.Entity.Concrete.Other.SahisKismi;
using JSGABackend.Responses;

namespace JSGABackend.Business.Concrete.Base
{
    public class BaseForSahisBulunanForBusiness<TIDataAccess, TEntity> : BaseForBusiness<TIDataAccess, TEntity>, ISahisBulunanBase<TEntity>
        where TIDataAccess : class, IEntityBaseDataAccess<TEntity>
        where TEntity : SahisBulunanBase
    {
        public BaseForSahisBulunanForBusiness():base()
        {
        }

        public async Task<Response<List<TEntity>>> GetAllBySahis(int Id)
        {
            Response<List<TEntity>> response;

            try
            {
                if (Id <= 0)
                    throw new ArgumentNullException(nameof(Id));

                var result = await this.dataAccess.GetByFilterAsync(p => p.Sahis.Id == Id);

                if (result == null || result.Count <=0)
                    throw new NullReferenceException("İlgili şahıs bulunan bir nesneler getirilemedi.");

                response = new(result, true);
            }
            catch (Exception ex)
            {
                response = new(ex.Message);
            }

            return response;
        }

        public async Task<Response<TEntity>> GetBySahis(int Id)
        {
            Response<TEntity> response;

            try
            {
                if(Id <= 0)
                    throw new ArgumentNullException(nameof(Id));

                var result = (await this.dataAccess.GetByFilterAsync(p=>p.Sahis.Id == Id)).FirstOrDefault();

                if (result == null)
                    throw new NullReferenceException("İlgili şahıs bulunan bir nesne getirilemedi.");

                response = new(result, true);
            }
            catch (Exception ex)
            {
                response = new(ex.Message);
            }

            return response;
        }

        public async Task<Response<TEntity>> GetBySahis(Sahis sahis)
        {
            Response<TEntity> response;

            try
            {
                if (sahis == null || sahis.Id <= 0)
                    throw new ArgumentNullException(nameof(sahis));

                var result = (await this.dataAccess.GetByFilterAsync(p => p.Sahis.Id == sahis.Id)).FirstOrDefault();

                if (result == null)
                    throw new NullReferenceException("İlgili şahıs bulunan bir nesne getirilemedi.");

                response = new(result, true);
            }
            catch (Exception ex)
            {
                response = new(ex.Message);
            }

            return response;
        }

        public async Task<Response<bool>> PasifeAl(int Id)
        {
            Response<bool> response;

            try
            {
                if (Id <= 0)
                    throw new ArgumentNullException(nameof(Id));

                var result = (await this.dataAccess.GetByFilterAsync(p => p.Sahis.Id == Id && p.PasiflikDurumu == false)).FirstOrDefault();

                if (result == null)
                    throw new NullReferenceException("İlgili şahıs bulunan bir nesne getirilemedi.");

                result.PasiflikDurumu = true;
                result.PasifAlZamani = DateTime.UtcNow;

                var resultUpdate = await this.dataAccess.UpdateAsync(result,DateTime.UtcNow);

                if (resultUpdate == null || resultUpdate.PasiflikDurumu != result.PasiflikDurumu || resultUpdate.PasifAlZamani != result.PasifAlZamani)
                    throw new NullReferenceException("Daha önce ya pasife alınmış yada bir sıkıntı oldu");

                response = new(true, true);
            }
            catch (Exception ex)
            {
                response = new(ex.Message);
            }

            return response;
        }

        public async Task<Response<bool>> PasifeAl(Sahis sahis)
        {
            Response<bool> response;

            try
            {
                if (sahis == null || sahis.Id <= 0)
                    throw new ArgumentNullException(nameof(sahis));

                var result = (await this.dataAccess.GetByFilterAsync(p => p.Sahis.Id == sahis.Id && p.PasiflikDurumu == false)).FirstOrDefault();

                if (result == null)
                    throw new NullReferenceException("İlgili şahıs bulunan bir nesne getirilemedi.");

                result.PasiflikDurumu = true;
                result.PasifAlZamani = DateTime.UtcNow;

                var resultUpdate = await this.dataAccess.UpdateAsync(result, DateTime.UtcNow);

                if (resultUpdate == null || resultUpdate.PasiflikDurumu != result.PasiflikDurumu || resultUpdate.PasifAlZamani != result.PasifAlZamani)
                    throw new NullReferenceException("Daha önce ya pasife alınmış yada bir sıkıntı oldu");

                response = new(true, true);
            }
            catch (Exception ex)
            {
                response = new(ex.Message);
            }

            return response;
        }

        public async Task<Response<bool>> PasifeAlAll(int Id)
        {
            Response<bool> response;

            try
            {
                if (Id <= 0)
                    throw new ArgumentNullException(nameof(Id));

                var result = await this.dataAccess.GetByFilterAsync(p => p.Sahis.Id == Id && p.PasiflikDurumu == false);

                if (result == null || result.Count <= 0)
                    throw new NullReferenceException("İlgili şahıs bulunan bir nesneler getirilemedi.");

                for ( var i = 0; i < result.Count; i++ )
                {
                    result[i].PasiflikDurumu = true;
                    result[i].PasifAlZamani = DateTime.UtcNow;

                    var resultUpdate = await this.dataAccess.UpdateAsync(result[i], DateTime.UtcNow);

                    if (resultUpdate == null || resultUpdate.PasiflikDurumu != result[i].PasiflikDurumu || resultUpdate.PasifAlZamani != result[i].PasifAlZamani)
                        throw new NullReferenceException("Daha önce ya pasife alınmış yada bir sıkıntı oldu");
                }

                response = new(true, true);
            }
            catch (Exception ex)
            {
                response = new(ex.Message);
            }

            return response;
        }
    }
}
