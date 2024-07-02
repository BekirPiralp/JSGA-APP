using JSGABackend.Business.Abstract.Other.PersonelKismi.PersonelCesit;
using JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelCesit;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.PersonelKisim.PersonelCesit
{
    [ApiController]
    public class PersonelController : BaseController<Personel, IPersonelBusiness>
    {
    }
}
