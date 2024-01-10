using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.SahisKismi
{
	public class SahisBulunanBase : BaseEntity
	{
		public required Sahis Sahis { get; set; }
		public bool PasiflikDurumu { get; set; } = false;
		public DateTime? PasifAlZamani { get; set; }
	}
}
