using AppObjectOlusturucu.Abstract;
using AppObjectOlusturucu.Concrete;
using JSGABackend.DataAccess.Concrete;

namespace JSGABackend.Business;

public class BusinessCreateHandler : OlusturCreateHandler, IOlusturucuCreateHandler
{

    public override void CreateObj()
    {
        this._nextHandler = new DataAccessCreateHandler();

        #region Akademik Kısım

			OlusturCreator.CreateObject<IAkademikDonemBusiness, AkademikDonemBusiness>();
			OlusturCreator.CreateObject<IAkademikEgitimBusiness, AkademikEgitimBusiness>();
			OlusturCreator.CreateObject<IAkademikEgitimTuruBusiness, AkademikEgitimTuruBusiness>();
			OlusturCreator.CreateObject<IAkademikHaftaBusiness, AkademikHaftaBusiness>();
			OlusturCreator.CreateObject<IAkademikHaftaOzelGunleriBusiness, AkademikHaftaOzelGunleriBusiness>();
			OlusturCreator.CreateObject<IAkademikYilBusiness, AkademikYilBusiness>();
			OlusturCreator.CreateObject<IOzelGunOlayBusiness, OzelGunOlayBusiness>();

		#endregion

        #region Birim Kısım

			OlusturCreator.CreateObject<IDaireBusiness, DaireBusiness>();
			OlusturCreator.CreateObject<ISubeBilgiBusiness, SubeBilgiBusiness>();
			OlusturCreator.CreateObject<ISubeBusiness, SubeBusiness>();

		#endregion

        #region Ders Alma Verme Kısmı

			OlusturCreator.CreateObject<IEgitmenDersVermeBusiness, EgitmenDersVermeBusiness>();
			OlusturCreator.CreateObject<IHarfNotuBusiness, HarfNotuBusiness>();
			OlusturCreator.CreateObject<INotHesapYuzdesiBusiness, NotHesapYuzdesiBusiness>();
			OlusturCreator.CreateObject<IOgrenciDersAlmaBusiness, OgrenciDersAlmaBusiness>();

		#endregion

        #region Ders Kısmı

			OlusturCreator.CreateObject<IDersBransBusiness, DersBransBusiness>();
			OlusturCreator.CreateObject<IDersBusiness, DersBusiness>();
			OlusturCreator.CreateObject<IDersIcerikBusiness, DersIcerikBusiness>();

		#endregion

        #region Derslik Kısmı

			OlusturCreator.CreateObject<IDerslikBusiness, DerslikBusiness>();
			OlusturCreator.CreateObject<IOzelDerslikBusiness, OzelDerslikBusiness>();

		#endregion

        #region Guvenlik Kısmı

			OlusturCreator.CreateObject<IJetonBusiness, JetonBusiness>();
			OlusturCreator.CreateObject<IJetonSureBusiness, JetonSureBusiness>();
			OlusturCreator.CreateObject<ISahisKullaniciAdiBusiness, SahisKullaniciAdiBusiness>();
			OlusturCreator.CreateObject<ISahisSifreBusiness, SahisSifreBusiness>();

        #endregion

        #region Haftalik Plan Kısmı

			OlusturCreator.CreateObject<IGunlukIslemSaatiBusiness, GunlukIslemSaatiBusiness>();
			OlusturCreator.CreateObject<IOgrenciDersHariciSaatBusiness, OgrenciDersHariciSaatBusiness>();

        #endregion

        #region Ogrenci Kısmı

			OlusturCreator.CreateObject<IOgrenciBusiness, OgrenciBusiness>();

        #endregion

        #region Okul Kısmı

			OlusturCreator.CreateObject<IKisimBusiness, KisimBusiness>();
			OlusturCreator.CreateObject<IOkulBusiness, OkulBusiness>();
			OlusturCreator.CreateObject<IOkulDuzeyiBusiness, OkulDuzeyiBusiness>();
			OlusturCreator.CreateObject<ISinifCesitBusiness, SinifCesitBusiness>();
			OlusturCreator.CreateObject<ISinifBusiness, SinifBusiness>();

        #endregion

        #region Personel Kısmı

			//Perosnel Çeşit
			OlusturCreator.CreateObject<IEgitmenBusiness, EgitmenBusiness>();
			OlusturCreator.CreateObject<IMemurBusiness, MemurBusiness>();
			OlusturCreator.CreateObject<IPersonelBusiness, PersonelBusiness>();

			// Personel Ünvan
			OlusturCreator.CreateObject<IDereceBusiness, DereceBusiness>();
			OlusturCreator.CreateObject<IRutbeBusiness, RutbeBusiness>();
			OlusturCreator.CreateObject<IUnvanBusiness, UnvanBusiness>();

        #endregion

        #region Şahıs Kısmı

			//Şahıs Bilgi
			OlusturCreator.CreateObject<IAcikAlinanPersonelBusiness, AcikAlinanPersonelBusiness>();
			OlusturCreator.CreateObject<IAdresBilgisiBusiness, AdresBilgisiBusiness>();
			OlusturCreator.CreateObject<IEmailBilgisiBusiness, EmailBilgisiBusiness>();
			OlusturCreator.CreateObject<ISicilBusiness, SicilBusiness>();
			OlusturCreator.CreateObject<ITelefonBilgisiBusiness, TelefonBilgisiBusiness>();

			OlusturCreator.CreateObject<ISahisBusiness, SahisBusiness>();

        #endregion
    }
}
