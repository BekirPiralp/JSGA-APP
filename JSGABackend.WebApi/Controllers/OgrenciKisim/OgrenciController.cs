using JSGABackend.Business.Abstract.Other.OgrenciKismi;
using JSGABackend.Entity.Concrete.Other.OgrenciKismi;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.OgrenciKisim
{
    [ApiController]
    public class OgrenciController : BaseController<Ogrenci, IOgrenciBusiness>
    {
    }
}
