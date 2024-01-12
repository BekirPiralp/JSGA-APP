using JSGABackend.Entity.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.AkademikKisim;

namespace JSGABackend.Entity.Concrete.Other.HaftalikPlanKismi
{
	public class OgrenciDersHariciSaat : BaseEntity
	{
		public required AkademikYil AkademikYil { get; set; }
		public required AkademikDonem AkademikDonem { get; set; }
		public required GunlukIslemSaati GunlukIslemSaati { get; set; }
		public required string Aciklama { get; set; }

	}
}
