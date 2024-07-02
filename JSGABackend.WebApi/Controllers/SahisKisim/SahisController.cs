using JSGABackend.Business.Abstract.Other.SahisKismi;
using JSGABackend.Entity.Concrete.Other.SahisKismi;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.SahisKisim
{
    [ApiController]
    public class SahisController : BaseController<Sahis, ISahisBusiness>
    {
    }
}
