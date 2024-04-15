using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.OkulKismi;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.OkulKismi;

namespace JSGABackend.DataAccess.Concrete.Other.OkulKismi
{
	public class KisimDataAccess : EntityBaseForEntityFrameworkDataAccess<Kisim,EntityFrameworkContextMsSql>,
		IKisimDataAccess
	{
	}
}
