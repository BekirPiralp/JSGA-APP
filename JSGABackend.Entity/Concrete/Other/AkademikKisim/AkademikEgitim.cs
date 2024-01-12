using JSGABackend.Entity.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.OkulKismi;

namespace JSGABackend.Entity.Concrete.Other.AkademikKisim
{
	public class AkademikEgitim : BaseEntity
	{
		public required string Ad { get; set; }
		public required string Aciklama { get; set; }
		public Sinif? Sinif { get; set; }
		public required AkademikHafta AkademikHafta { get; set; }
		public required AkademikEgitimTuru AkademikEgitimTuru { get; set; }
	}
}
