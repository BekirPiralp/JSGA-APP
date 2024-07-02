using JSGABackend.Business.Abstract.Other.BirimKismi;
using JSGABackend.Entity.Concrete.Other.BirimKismi;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.BirimKisim
{
    [ApiController]
    public class SubeBilgiController : BaseController<SubeBilgi, ISubeBilgiBusiness>
    {
    }
}
