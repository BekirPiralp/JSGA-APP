using JSGABackend.Security.Abstract;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace JSGABackend.Security.Concrete
{
    internal class SignToken : ISignToken
    {
        public SecurityKey GetSecurityKey(string securityKeyString)
        {
            Byte[] securityKeyBytes;

            securityKeyBytes = Encoding.UTF8.GetBytes(securityKeyString); // securityKey ifadesini stringden byte a çevirityoruz

            
            SecurityKey securityKey;

            securityKey = new SymmetricSecurityKey(securityKeyBytes);
            

            return securityKey;
        }
    }
}
