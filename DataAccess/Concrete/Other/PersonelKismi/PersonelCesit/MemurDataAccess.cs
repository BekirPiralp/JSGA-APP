using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.PersonelKismi.PersonelCesit;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelCesit;

namespace JSGABackend.DataAccess.Concrete.Other.PersonelKismi.PersonelCesit
{
	public class MemurDataAccess : EntityBaseForEntityFrameworkDataAccess<Memur,EntityFrameworkContextMsSql>,
		IMemurDataAccess
	{
	}
}
