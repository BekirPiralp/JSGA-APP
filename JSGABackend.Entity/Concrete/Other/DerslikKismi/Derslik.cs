using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.DerslikKismi
{
	public class Derslik : BaseEntity
	{
		public required string Adi { get; set; }
		public required string Aciklama { get; set; }
		public required int Kapasite { get; set; }
	}
}
