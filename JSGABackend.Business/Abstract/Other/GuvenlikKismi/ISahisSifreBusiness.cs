using JSGABackend.Business.Abstract.Base;
using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;
using JSGABackend.Responses;

namespace JSGABackend.Business.Abstract.Other.GuvenlikKismi
{
    public interface ISahisSifreBusiness : IBaseForBusiness<SahisSifre>
    {
        public Task<Response<SahisSifre>> GetByPassword(string password);
    }
}
