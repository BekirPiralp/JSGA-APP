using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.SahisKismi;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.SahisKismi;

namespace JSGABackend.DataAccess.Concrete.Other.SahisKismi
{
	public class SahisDataAccess : EntityBaseForEntityFrameworkDataAccess<Sahis,EntityFrameworkContextMsSql>,
		ISahisDataAccess
	{
	}
}
