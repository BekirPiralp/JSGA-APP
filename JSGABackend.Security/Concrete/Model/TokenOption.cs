using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace JSGABackend.Security.Concrete.Model
{
    public class TokenOption
    {
        public TokenOption()
        {
            
        }
        /// <summary>
        /// integer value of minutes - tamsayı olana değerler dakikalardır...
        /// </summary>
        /// <param name="audience">Dinleyici</param>
        /// <param name="issuser">Yayıncı</param>
        /// <param name="expires">Son kullanım / geçerlilik</param>
        /// <param name="refreshTokenSonKullanım"> yenileme jetonunun en son kullanım zamanı</param>
        /// <param name="notBefore"> Gecerlilik başlaması - önce değil xx dk yada xx.xx.xx tarihten sonra</param>
        /// <param name="gecikmeSuresi"> gecikmes süresi opsiyoneldir (işleme alınmaya bilir)</param>
        /// <param name="securityKeyString"> Security key of string - Güvenlik kelimesi ;)</param>
        public TokenOption(string audience=null!,string issuser = null!,int expires = 5,int refreshTokenSonKullanım = 10, int notBefore = 0, int gecikmeSuresi = 0 , string securityKeyString = null!,List<Claim> claims = null!)
        {
            if (notBefore >= expires || notBefore < 0)
                throw new ArgumentException(nameof(notBefore));

            if (expires < 5)
                throw new ArgumentException(nameof(expires) + " 5 dk dan küçük olamaz");

            if (refreshTokenSonKullanim < 10)
                throw new ArgumentException(nameof(refreshTokenSonKullanim) + "10 dk dan küçük olamaz");

            this.audience = audience;
            this.expires = expires;
            this.refreshTokenSonKullanim = refreshTokenSonKullanım;
            this.notBefore = notBefore;
            this.gecikmeSuresi = gecikmeSuresi;
            this.securityKeyString = securityKeyString;
            this.claims = claims;

        }

        public string audience { get; set; } //dinleyici
        public string issuer { get; set; } = default!; //yayıncı

        /* Dk cünsinden tamsayı*/
        public int expires { get; set; } // Access Token Son Kulanim
        public int refreshTokenSonKullanim { get; set; }
        public int notBefore { get; set; } //GecerlilikBaslamasi
        public int gecikmeSuresi { get; set; }
        public string securityKeyString { get; set; } //GuvenlikAnahtari

        public List<Claim> claims { get; set; } // istekler
    }
}
