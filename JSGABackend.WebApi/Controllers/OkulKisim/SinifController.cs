using JSGABackend.Business.Abstract.Other.OkulKismi;
using JSGABackend.Entity.Concrete.Other.OkulKismi;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.OkulKisim
{
    [ApiController]
    public class SinifController : BaseController<Sinif, ISinifBusiness>
    {
    }
}
