using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.OkulKismi
{
	public class Okul : BaseEntity
	{
		public required string Ad { get; set; }
		public required OkulDuzeyi OkulDuzeyi { get; set; }
	}
}
