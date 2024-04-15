using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.PersonelKismi.PersonelUnvan;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelUnvan;

namespace JSGABackend.DataAccess.Concrete.Other.PersonelKismi.PersonelUnvan
{
	public class DereceDataAccess : EntityBaseForEntityFrameworkDataAccess<Derece,EntityFrameworkContextMsSql>,
		IDereceDataAccess
	{
	}
}
