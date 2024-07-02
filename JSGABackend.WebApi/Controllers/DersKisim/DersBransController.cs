using JSGABackend.Business.Abstract.Other.DersKismi;
using JSGABackend.Entity.Concrete.Other.DersKismi;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.DersKisim
{
    [ApiController]
    public class DersBransController : BaseController<DersBrans, IDersBransBusiness>
    {
    }
}
