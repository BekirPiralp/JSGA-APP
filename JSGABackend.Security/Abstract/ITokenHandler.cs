using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;

namespace JSGABackend.Security.Abstract
{
    internal interface ITokenHandler
    {
        public Task<Jeton> CreateToken(SahisKullaniciAdi kullaniciAdi);
        public Task<bool> RemoveRefreshToken(Jeton token);

        /// <summary>
        /// Yenileme işlemi için gerekli olan yenileme jetonu string bir tümce oluşturur.
        /// </summary>
        /// <param name="length">Oluşturulacak olan jetonun uzunluğunu belirler ör:(x = length => x byte => x . 8 bit => 8x bit) <br />
        /// 6 bit ten ve 64 karakterden oluşan string dönüştürme yapar uzunluğu ise (8x bit / 6 bit)</param>
        /// <returns></returns>
        public string CreateRefreshToken(int length = 128);
    }
}
