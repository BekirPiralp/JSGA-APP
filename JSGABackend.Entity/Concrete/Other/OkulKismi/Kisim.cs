using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.OkulKismi
{
	public class Kisim : BaseEntity
	{
		public required Sinif Sinif { get; set; }
		public required string Ad { get; set; }
		public required int Kapasite { get; set; } = 0;
	}
}
