using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelUnvan
{
	public class UnvanBase : BaseEntity
	{
		public required string Ad { get; set; }
		public required string Kisaltma { get; set; }
	}
}
