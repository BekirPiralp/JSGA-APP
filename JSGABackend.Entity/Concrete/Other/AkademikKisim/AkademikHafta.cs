using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.AkademikKisim
{
	public class AkademikHafta:BaseEntity
	{
		public required string Ad { get; set; }
		public required AkademikYil AkademikYil { get; set; }
		public required AkademikDonem AkademikDonem { get; set; }
		public required DateTime BaslangicTarihi { get; set; }
		public required DateTime BitisTarihi { get; set; }
	}
}
