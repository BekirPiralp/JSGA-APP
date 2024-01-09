using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.BirimKismi
{
	public class Sube: BaseEntity
	{
		public required Daire Daire { get; set; }
		public required SubeBilgi SubeBilgi { get; set; }
	}
}
