using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.GuvenlikKismi;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;

namespace JSGABackend.DataAccess.Concrete.Other.GuvenlikKismi
{
	public class SahisSifreDataAccess : 
		EntityBaseForEntityFrameworkDataAccess<SahisSifre,EntityFrameworkContextMsSql>,
		ISahisSifreDataAccess
	{
	}
}
