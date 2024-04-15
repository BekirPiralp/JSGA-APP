using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.DersAlmaVermeKismi;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.DersAlmaVermeKismi;

namespace JSGABackend.DataAccess.Concrete.Other.DersAlmaVermeKismi
{
	public class HarfNotuDataAccess :
		EntityBaseForEntityFrameworkDataAccess<HarfNotu, EntityFrameworkContextMsSql>,
		IHarfNotuDataAccess
	{
	}
}
