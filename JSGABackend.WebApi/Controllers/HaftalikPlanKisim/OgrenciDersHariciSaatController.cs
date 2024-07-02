using JSGABackend.Business.Abstract.Other.HaftalikPlanKismi;
using JSGABackend.Entity.Concrete.Other.HaftalikPlanKismi;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.HaftalikPlanKisim
{
    [ApiController]
    public class OgrenciDersHariciSaatController : BaseController<OgrenciDersHariciSaat, IOgrenciDersHariciSaatBusiness>
    {
    }
}
