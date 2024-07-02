using JSGABackend.Business.Abstract.Other.SahisKismi.SahisBilgi;
using JSGABackend.Entity.Concrete.Other.SahisKismi.SahisBilgi;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.SahisKisim.SahisBilgi
{
    [ApiController]
    public class SicilController : BaseController<Sicil, ISicilBusiness>
    {
    }
}
