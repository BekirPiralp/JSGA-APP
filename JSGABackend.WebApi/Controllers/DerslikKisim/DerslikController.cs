using JSGABackend.Business.Abstract.Other.DerslikKismi;
using JSGABackend.Entity.Concrete.Other.DerslikKismi;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.DerslikKisim
{
    [ApiController]
    public class DerslikController : BaseController<Derslik, IDerslikBusiness>
    {
    }
}
