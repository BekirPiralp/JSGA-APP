using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;
using JSGABackend.Responses;

namespace JSGABackend.Security.Abstract
{
    public interface ISecurity
    {
        public Task<Response<Jeton>> Open(string kullaniciAdi, string sifre);
        public Task<Response<Jeton>> Refresh(string kullaniciAdi,string yenileyiciJeton);
        public Task<Response<bool>> Close(string kullaniciAdi);
    }
}
