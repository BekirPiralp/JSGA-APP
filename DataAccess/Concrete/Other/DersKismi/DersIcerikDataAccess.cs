using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.DersKismi;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.DersKismi;

namespace JSGABackend.DataAccess.Concrete.Other.DersKismi
{
	public class DersIcerikDataAccess :
		EntityBaseForEntityFrameworkDataAccess<DersIcerik,EntityFrameworkContextMsSql>,
		IDersIcerikDataAccess
	{
	}
}
