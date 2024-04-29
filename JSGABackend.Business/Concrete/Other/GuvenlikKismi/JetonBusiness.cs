using JSGABackend.Business.Abstract.Other.GuvenlikKismi;
using JSGABackend.Business.Concrete.Base;
using JSGABackend.DataAccess.Abstract.Other.GuvenlikKismi;
using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;
using JSGABackend.Responses;

namespace JSGABackend.Business.Concrete.Other.GuvenlikKismi
{
    public class JetonBusiness : BaseForSahisBulunanForBusiness<IJetonDataAccess, Jeton>, IJetonBusiness
    {
        public async Task<Response<Jeton>> GetByRefreshToken(string refreshToken)
        {
            Response<Jeton> response;

            try
            {
                if (string.IsNullOrEmpty(refreshToken))
                    throw new ArgumentNullException();

                Jeton? result;
                try
                {
                    result = (await this.dataAccess.GetByFilterAsync(p => p.RefreshToken.Equals(refreshToken))).FirstOrDefault();
                }
                catch (Exception)
                {
                    throw new Exception("Jeton bilgisi getirilemedi.");
                }

                if (result == null)
                    throw new NullReferenceException("Jeton bulunamadı.");

                if (result.PasiflikDurumu)
                    throw new Exception("Bu jeton geçersiz");

                if (result.SilDurum)
                    throw new Exception("Bu jeton silinmiş");

                response = new(result, true);
               
            }
            catch (Exception ex)
            {
                response = new(ex.Message);
            }

            return response;
        }
    }
}
