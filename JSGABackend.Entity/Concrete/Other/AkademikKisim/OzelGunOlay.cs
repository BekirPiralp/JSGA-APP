using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.AkademikKisim
{
	public class OzelGunOlay : BaseEntity
	{
		public required string Ad { get; set; }
		public required string Aciklama { get; set; }
		public required DateTime BaslangicTarihi { get; set; }
		public required DateTime BitisTarihi { get; set; }
	}
}
