using AppObjectOlusturucu.Concrete;
using JSGABackend.Business.Abstract.Other.GuvenlikKismi;
using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;
using JSGABackend.Security.Abstract;
using JSGABackend.Security.Concrete.Model;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace JSGABackend.Security.Concrete
{
    internal class TokenHandler : ITokenHandler
    {
        IJetonBusiness _jetonBusiness;
        IJetonSureBusiness _jetonSureBusiness;
        ISignToken _signToken;
        JwtSecurityTokenHandler _jwtSecurityTokenHandler;

        TokenOption _tokenOption;

        public TokenHandler(ISignToken signToken = null!,TokenOption tokenOption = null!) {
            this._jetonBusiness = Olusturucu.olustur.GetObj<IJetonBusiness>()!;
            this._jetonSureBusiness = Olusturucu.olustur.GetObj<IJetonSureBusiness>()!;

            _jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

            this._signToken = signToken ?? new SignToken(); // if signToken param equals to null, set default new SignToken class

            var jetonSure = _jetonSureBusiness.GetLastOrDefault().Result;

           

            _tokenOption = tokenOption ?? new TokenOption(
                issuser: "Ben çalarım.",
                audience: "Ben dinlerim.",
                securityKeyString: "Büyük bir sessizlik içinde..., sesiz ve yorgun..., agaa bee...",
                expires:jetonSure != null && jetonSure.Status ? jetonSure.Value!.SureDakika : 10,
                refreshTokenSonKullanım: 15,
                notBefore:0,
                gecikmeSuresi:0
                );
             
        }

        

        public async Task<Jeton> CreateToken(SahisKullaniciAdi kullaniciAdi)
        {
            if (kullaniciAdi == null || kullaniciAdi.PasiflikDurumu)
                throw new ArgumentNullException();

            var securityKey = this._signToken.GetSecurityKey( this._tokenOption.securityKeyString);

            var signingCredentials = new SigningCredentials(securityKey,SecurityAlgorithms.RsaSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: this._tokenOption.issuer,
                audience: this._tokenOption.audience,
                expires: DateTime.UtcNow.AddMinutes(this._tokenOption.expires),
                notBefore: DateTime.UtcNow.AddMinutes(this._tokenOption.notBefore),
                claims: [

                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    new(JwtRegisteredClaimNames.Name,kullaniciAdi.Sahis.Ad),
                    new Claim("user-name",kullaniciAdi.KullaniciAdi),
                    new(JwtRegisteredClaimNames.Exp,DateTime.UtcNow.AddMinutes(this._tokenOption.expires).ToString()),
                    new(JwtRegisteredClaimNames.Nbf,DateTime.UtcNow.AddMinutes(this._tokenOption.notBefore).ToString())
       
                    ],
                signingCredentials: signingCredentials
                );

            var token = this._jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);

            var jeton = new Jeton
            {
                Sahis = kullaniciAdi.Sahis,
                Token = token ?? throw new Exception(),
                RefreshToken = this.CreateRefreshToken(),
                TokenTimeEnd = DateTime.UtcNow.AddMinutes(this._tokenOption.refreshTokenSonKullanim)
            };

            var Response = await this._jetonBusiness.Add(jeton);

            if (!Response.Status)
                throw new Exception("Jeton kaydedilemedi.");

            return jeton;
        }

        public async Task<bool> RemoveRefreshToken(Jeton token)
        {
            try
            {
                var result = await (_jetonBusiness.PasifeAl(token.Sahis.Id));

                if (result.Status!)
                    throw new Exception("Pasife almada hata");

                return true;

            }catch(Exception)
            {
                throw new Exception("Refresh token kaldırmada hata");
            }
            
        }

        
        public string CreateRefreshToken(int length = 128)
        {
            string response;

            var byteArray = new Byte[length]; //128 byte uzunluğunda (1 byte = 8 bit) byte dizisi oluşturduk

            using (var rndmNumGnrtor = RandomNumberGenerator.Create())
            {
                rndmNumGnrtor.GetBytes(byteArray); // rasgele oluşan sayıların byte karşılığına çevirerek byte diziyi dolduruyoruz

                response = Convert.ToBase64String(byteArray);

            }

            return response;
        }

    }
}
