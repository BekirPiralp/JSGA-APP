using JSGABackend.Business.Abstract.Base;
using JSGABackend.Business.Abstract.Other.SahisKismi;
using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;
using JSGABackend.Responses;

namespace JSGABackend.Business.Abstract.Other.GuvenlikKismi
{
    public interface IJetonBusiness : ISahisBulunanBase<Jeton>
    {
        public Task<Response<Jeton>> GetByRefreshToken(string refreshToken);
    }
}
