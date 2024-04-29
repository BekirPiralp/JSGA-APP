using JSGABackend.Business.Abstract.Other.GuvenlikKismi;
using JSGABackend.Business.Concrete.Base;
using JSGABackend.DataAccess.Abstract.Other.GuvenlikKismi;
using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;
using JSGABackend.Responses;

namespace JSGABackend.Business.Concrete.Other.GuvenlikKismi
{
    public class SahisKullaniciAdiBusiness : BaseForSahisBulunanForBusiness<ISahisKullaniciAdiDataAccess, SahisKullaniciAdi>, ISahisKullaniciAdiBusiness
    {

        public async Task<Response<SahisKullaniciAdi>> GetByUserName(string userName)
        {
            Response<SahisKullaniciAdi> response;
            try
            {
                SahisKullaniciAdi? result;
                try
                {
                    result = (await this.dataAccess.GetByFilterAsync(p => p.KullaniciAdi.Equals(userName.Trim()))).FirstOrDefault();
                }
                catch
                {
                    throw new Exception("Kullanıcı adı getirilirken hata oluştu");
                }

                if (result == null)
                    throw new NullReferenceException("Kullanıcı adı getirilemedi.");

                if (result.PasiflikDurumu)
                    throw new Exception("Bu kullanıcı adı pasife alınmış");

                if (result.SilDurum)
                    throw new Exception("Bu kullanıcı adı silinmiş");

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
