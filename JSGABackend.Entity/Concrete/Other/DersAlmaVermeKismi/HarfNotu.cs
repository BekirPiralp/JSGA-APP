using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.DersAlmaVermeKismi
{
	public class HarfNotu : BaseEntity
	{
		public required string Ad { get; set; }
		public required float AltNot { get; set; }
		public required float UstNot { get; set; }
		public required float KrediKarsiligi { get; set; }
	}
}
