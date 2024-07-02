using JSGABackend.Business.Abstract.Other.AkademikKismi;
using JSGABackend.Entity.Concrete.Other.AkademikKisim;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.AkademikKisim
{
    [ApiController]
    public class AkademikYilController : BaseController<AkademikYil, IAkademikYilBusiness>
    {
    }
}
