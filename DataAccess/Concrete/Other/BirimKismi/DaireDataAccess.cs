using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.BirimKismi;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.BirimKismi;

namespace JSGABackend.DataAccess.Concrete.Other.BirimKismi
{
	public class DaireDataAccess : 
		EntityBaseForEntityFrameworkDataAccess<Daire,EntityFrameworkContextMsSql>,
		IDaireDataAccess
	{
	}
}
