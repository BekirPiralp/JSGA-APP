using JSGABackend.Entity.Concrete.Other.SahisKismi;

namespace JSGABackend.Entity.Concrete.Other.GuvenlikKismi
{
	public class Jeton : SahisBulunanBase
	{
		public required string Token { get; set; }
		public required string RefreshToken { get; set; }
		public required DateTime TokenTimeEnd { get; set; }
	}
}
