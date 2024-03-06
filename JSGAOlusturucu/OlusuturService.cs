using Microsoft.Extensions.DependencyInjection;
namespace JSGAOlusturucu
{
	public static class OlusuturService
	{
		public static void OlusturcuServiceCreate(this IServiceCollection service,IOlusturucuCreateHandler createHandler)
		{
			createHandler.HandleAndNext();
			//var a = Olusturucu.olustur;
		}
	}
}
