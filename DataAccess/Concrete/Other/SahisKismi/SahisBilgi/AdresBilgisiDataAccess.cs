using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.SahisKismi.SahisBilgi;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.SahisKismi.SahisBilgi;

namespace JSGABackend.DataAccess.Concrete.Other.SahisKismi.SahisBilgi
{
	public class AdresBilgisiDataAccess : EntityBaseForEntityFrameworkDataAccess<AdresBilgisi,EntityFrameworkContextMsSql>,
		IAdresBilgisiDataAccess
	{
	}
}
