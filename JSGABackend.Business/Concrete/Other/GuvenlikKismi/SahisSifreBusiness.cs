using JSGABackend.Business.Abstract.Other.GuvenlikKismi;
using JSGABackend.Business.Concrete.Base;
using JSGABackend.DataAccess.Abstract.Other.GuvenlikKismi;
using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;
using JSGABackend.Responses;

namespace JSGABackend.Business.Concrete.Other.GuvenlikKismi
{
    public class SahisSifreBusiness : BaseForBusiness<ISahisSifreDataAccess, SahisSifre>, ISahisSifreBusiness
    {
        public async Task<Response<SahisSifre>> GetByPassword(string password)
        {
            Response<SahisSifre> response;
            try
            {
                SahisSifre? result;
                try
                {
                    result = (await this.dataAccess.GetByFilterAsync(p => p.Sifre.Equals(password))).FirstOrDefault();
                }
                catch
                {
                    throw new Exception("Şifre getirilirken hata oluştu");
                }

                if (result == null)
                    throw new NullReferenceException("Şifre getirilemedi.");

                if (result.SilDurum)
                    throw new Exception("Bu şifre silinmiş");

                response = new(result!, true);
            }
            catch (Exception ex)
            {
                response = new(ex.Message);
            }

            return response;
        }
    }
}
