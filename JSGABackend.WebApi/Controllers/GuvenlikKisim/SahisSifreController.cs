using JSGABackend.Business.Abstract.Other.GuvenlikKismi;
using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.GuvenlikKisim
{
    [ApiController]
    public class SahisSifreController : BaseController<SahisSifre, ISahisSifreBusiness>
    {
    }
}
