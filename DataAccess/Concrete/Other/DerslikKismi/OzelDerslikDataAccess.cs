using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.DerslikKismi;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.DerslikKismi;

namespace JSGABackend.DataAccess.Concrete.Other.DerslikKismi
{
	public class OzelDerslikDataAccess : 
		EntityBaseForEntityFrameworkDataAccess<OzelDerslik,EntityFrameworkContextMsSql>,
		IOzelDerslikDataAccess
	{
	}
}
