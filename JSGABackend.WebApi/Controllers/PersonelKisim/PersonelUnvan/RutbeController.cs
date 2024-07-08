﻿using JSGABackend.Business.Abstract.Other.PersonelKismi.PersonelUnvan;
using JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelUnvan;
using JSGABackend.WebApi.Base.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JSGABackend.WebApi.Controllers.PersonelKisim.PersonelUnvan
{
    [ApiController]
    public class RutbeController : BaseController<Rutbe, IRutbeBusiness>
    {
    }
}