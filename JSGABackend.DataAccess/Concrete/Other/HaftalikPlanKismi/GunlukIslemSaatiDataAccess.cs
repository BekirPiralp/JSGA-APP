using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.HaftalikPlanKismi;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.HaftalikPlanKismi;

namespace JSGABackend.DataAccess.Concrete.Other.HaftalikPlanKismi
{
	public class GunlukIslemSaatiDataAccess : 
		EntityBaseForEntityFrameworkDataAccess<GunlukIslemSaati,EntityFrameworkContextMsSql>,
		IGunlukIslemSaatiDataAccess
	{
	}
}
