using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.AkademikKisim
{
	public class AkademikHaftaOzelGunleri : BaseEntity
	{
		public required OzelGunOlay OzelGunOlay { get; set; }
		public required AkademikHafta AkademikHafta { get; set; }
	}
}
