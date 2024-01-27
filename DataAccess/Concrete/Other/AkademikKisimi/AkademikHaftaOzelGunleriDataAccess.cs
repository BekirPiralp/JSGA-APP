using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.AkademiKismi;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.AkademikKisim;

namespace JSGABackend.DataAccess.Concrete.Other.AkademikKisimi
{
	public class AkademikHaftaOzelGunleriDataAccess : 
		EntityBaseForEntityFrameworkDataAccess<AkademikHaftaOzelGunleri,EntityFrameworkContextMsSql>,
		IAkademikHaftaOzelGunleriDataAccess
	{
	}
}
