using AppObjectOlusturucu.Concrete;
using JSGABackend.Business.Abstract.Other.GuvenlikKismi;
using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;
using JSGABackend.Responses;
using JSGABackend.Security.Abstract;

namespace JSGABackend.Security.Concrete
{
    public class Security : ISecurity
    {
        ISahisKullaniciAdiBusiness _kullaniciAdiBusiness;
        ISahisSifreBusiness _sifreBusiness;
        IJetonBusiness _jetonBusiness;
        ITokenHandler _tokenHandler;
        internal Security(ITokenHandler tokenHandler = null!)
        {
            this._kullaniciAdiBusiness = Olusturucu.olustur.GetObj<ISahisKullaniciAdiBusiness>()!;
            this._sifreBusiness = Olusturucu.olustur.GetObj<ISahisSifreBusiness>()!;
            this._jetonBusiness = Olusturucu.olustur.GetObj<IJetonBusiness>()!;

            _tokenHandler = tokenHandler ?? new TokenHandler();

        }

        public Security() : this(null!)
        {
            
        }

        public async Task<Response<bool>> Close(string kullaniciAdi)
        {
            Response<bool> response;

            try
            {
                if (string.IsNullOrEmpty(kullaniciAdi))
                    throw new ArgumentException(nameof(kullaniciAdi));

                Response<SahisKullaniciAdi> resultKullanıcı;

                try
                {
                    resultKullanıcı = await this._kullaniciAdiBusiness.GetByUserName(kullaniciAdi);
                }
                catch (Exception) {
                    throw new Exception("Kullanıcı geitirliken hata oluştu");
                }

                if (!resultKullanıcı.Status)
                    throw new NullReferenceException("Kullanıcı bulunamadı.");

                Response<bool> result;
                try
                {
                    result = await this._jetonBusiness.PasifeAlAll(resultKullanıcı.Value!.Sahis.Id);
                }
                catch (Exception)
                {

                    throw new Exception("Pasife almada hata");
                }

                if (result == null || !result.Status)
                    response = new("Daha önce çıkış yapılmış");

                // diğer tüm durumlarda true
                response = new(true, true);
            }
            catch (Exception ex)
            {
                response = new(ex.Message);
            }
            return response;
        }

        public async Task<Response<Jeton>> Open(string kullaniciAdi, string sifre)
        {
            Response<Jeton> response;
            try
            {
                if (kullaniciAdi == null || sifre == null)
                    throw new ArgumentNullException();

                if (kullaniciAdi.Trim().Length <= 0 || sifre.Trim().Length <= 0)
                    throw new ArgumentException();

                var sahisKullaniciAdi = await this._kullaniciAdiBusiness.GetByUserName(kullaniciAdi);
                var sahisSifre = await this._sifreBusiness.GetByPassword(sifre);

                if (!sahisKullaniciAdi.Status)
                    throw new Exception(sahisKullaniciAdi.Message);

                if (!sahisSifre.Status)
                    throw new Exception(sahisSifre.Message);

                if (sahisSifre.Value!.SahisKullaniciAdi.Id != sahisKullaniciAdi.Value!.Id)
                    throw new Exception("Yanlış password");

                if (sahisKullaniciAdi.Value.Sahis.SilDurum)
                    throw new Exception("Bu kullanıcı silinmiş");

                if (sahisSifre.Value.SilDurum)
                    throw new Exception("Geçersiz şifre");

                Jeton? result;
                try
                {
                    result = await this._tokenHandler.CreateToken(sahisKullaniciAdi.Value);
                }
                catch (Exception)
                {

                    throw new Exception("Token kaydedilirken hata");
                }

                if (result == null)
                    throw new Exception("Token oluşturulamadı");

                response = new(result!, true);

            }catch (Exception ex)
            {
                response = new(ex.Message);
            }
            return response;
        }

        public async Task<Response<Jeton>> Refresh(string kullaniciAdi, string yenileyiciJeton)
        {
            Response<Jeton> response;
            try
            {
                if (kullaniciAdi == null || yenileyiciJeton == null)
                    throw new ArgumentNullException();

                if (kullaniciAdi.Trim().Length <= 0 || yenileyiciJeton.Trim().Length <= 0)
                    throw new ArgumentException();

                var sahisKullaniciAdi = await this._kullaniciAdiBusiness.GetByUserName(kullaniciAdi);
                var jeton = await this._jetonBusiness.GetByRefreshToken(yenileyiciJeton);

                if (!sahisKullaniciAdi.Status)
                    throw new Exception(sahisKullaniciAdi.Message);

                if (!jeton.Status)
                    throw new Exception(jeton.Message);

                if (jeton.Value!.Sahis.Id != sahisKullaniciAdi.Value!.Sahis.Id)
                    throw new Exception("");

                if (sahisKullaniciAdi.Value.Sahis.SilDurum)
                    throw new Exception("Bu kullanıcı silinmiş");

                Jeton? result;
                try
                {
                    result = await this._tokenHandler.CreateToken(sahisKullaniciAdi.Value);
                }
                catch (Exception)
                {
                    throw new Exception("Token kaydedilirken hata");
                }

                if (result == null)
                    throw new Exception("Token oluşturulamadı");

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
