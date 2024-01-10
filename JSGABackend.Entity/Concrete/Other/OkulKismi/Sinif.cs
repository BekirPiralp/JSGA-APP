using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.OkulKismi
{
	public class Sinif : BaseEntity
	{
		public required Okul Okul { get; set; }
		public required SinifCesit SinifCesit { get; set; }
	}
}
