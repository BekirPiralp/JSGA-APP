using JSGABackend.Entity.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.DersKismi;

namespace JSGABackend.Entity.Concrete.Other.DerslikKismi
{
	public class OzelDerslik : BaseEntity
	{
		public required Ders Ders { get; set; }
		public required Derslik Derslik { get; set; }
	}
}
