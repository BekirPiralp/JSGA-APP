using JSGABackend.Business.Abstract.Other.SahisKismi;
using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;
using JSGABackend.Responses;

namespace JSGABackend.Business.Abstract.Other.GuvenlikKismi
{
    public interface ISahisKullaniciAdiBusiness : ISahisBulunanBase<SahisKullaniciAdi>
    {
        public Task<Response<SahisKullaniciAdi>> GetByUserName(string userName);
    }
}
