using Microsoft.IdentityModel.Tokens;

namespace JSGABackend.Security.Abstract
{
    internal interface ISignToken
    {
        SecurityKey GetSecurityKey(string securityKeyString);
    }
}
