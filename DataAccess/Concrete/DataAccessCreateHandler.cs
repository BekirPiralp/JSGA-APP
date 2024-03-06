using JSGABackend.DataAccess.Abstract.Other.AkademiKismi;
using JSGABackend.DataAccess.Abstract.Other.BirimKismi;
using JSGABackend.DataAccess.Abstract.Other.DersAlmaVermeKismi;
using JSGABackend.DataAccess.Abstract.Other.DersKismi;
using JSGABackend.DataAccess.Abstract.Other.DerslikKismi;
using JSGABackend.DataAccess.Abstract.Other.GuvenlikKismi;
using JSGABackend.DataAccess.Abstract.Other.HaftalikPlanKismi;
using JSGABackend.DataAccess.Abstract.Other.OgrenciKismi;
using JSGABackend.DataAccess.Abstract.Other.OkulKismi;
using JSGABackend.DataAccess.Abstract.Other.PersonelKismi.PersonelCesit;
using JSGABackend.DataAccess.Abstract.Other.PersonelKismi.PersonelUnvan;
using JSGABackend.DataAccess.Abstract.Other.SahisKismi;
using JSGABackend.DataAccess.Abstract.Other.SahisKismi.SahisBilgi;
using JSGABackend.DataAccess.Concrete.Other.AkademikKisimi;
using JSGABackend.DataAccess.Concrete.Other.BirimKismi;
using JSGABackend.DataAccess.Concrete.Other.DersAlmaVermeKismi;
using JSGABackend.DataAccess.Concrete.Other.DersKismi;
using JSGABackend.DataAccess.Concrete.Other.DerslikKismi;
using JSGABackend.DataAccess.Concrete.Other.GuvenlikKismi;
using JSGABackend.DataAccess.Concrete.Other.HaftalikPlanKismi;
using JSGABackend.DataAccess.Concrete.Other.OgrenciKismi;
using JSGABackend.DataAccess.Concrete.Other.OkulKismi;
using JSGABackend.DataAccess.Concrete.Other.PersonelKismi.PersonelCesit;
using JSGABackend.DataAccess.Concrete.Other.PersonelKismi.PersonelUnvan;
using JSGABackend.DataAccess.Concrete.Other.SahisKismi;
using JSGABackend.DataAccess.Concrete.Other.SahisKismi.SahisBilgi;
using JSGAOlusturucu;

namespace JSGABackend.DataAccess.Concrete
{
	public class DataAccessCreateHandler : OlusuturCreateHandler, IOlusturucuCreateHandler
	{

		public override void CreateObj()
		{
			this._nextHandler = null;

			#region Akademik Kısım

			OlusturCreator.CreateObject<IAkademikDonemDataAccess, AkademikDonemDataAccess>();
			OlusturCreator.CreateObject<IAkademikEgitimDataAccess, AkademikEgitimDataAccess>();
			OlusturCreator.CreateObject<IAkademikEgitimTuruDataAccess, AkademikEgitimTuruDataAccess>();
			OlusturCreator.CreateObject<IAkademikHaftaDataAccess, AkademikHaftaDataAccess>();
			OlusturCreator.CreateObject<IAkademikHaftaOzelGunleriDataAccess, AkademikHaftaOzelGunleriDataAccess>();
			OlusturCreator.CreateObject<IAkademikYilDataAccess, AkademikYilDataAccess>();
			OlusturCreator.CreateObject<IOzelGunOlayDataAccess, OzelGunOlayDataAccess>();

			#endregion

			#region Birim Kısım

			OlusturCreator.CreateObject<IDaireDataAccess, DaireDataAccess>();
			OlusturCreator.CreateObject<ISubeBilgiDataAccess, SubeBilgiDataAccess>();
			OlusturCreator.CreateObject<ISubeDataAccess, SubeDataAccess>();

			#endregion

			#region Ders Alma Verme Kısmı

			OlusturCreator.CreateObject<IEgitmenDersVermeDataAccess, EgitmenDersVermeDataAccess>();
			OlusturCreator.CreateObject<IHarfNotuDataAccess, HarfNotuDataAccess>();
			OlusturCreator.CreateObject<INotHesapYuzdesiDataAccess, NotHesapYuzdesiDataAccess>();
			OlusturCreator.CreateObject<IOgrenciDersAlmaDataAccess, OgrenciDersAlmaDataAccess>();

			#endregion


			#region Ders Kısmı

			OlusturCreator.CreateObject<IDersBransDataAccess, DersBransDataAccess>();
			OlusturCreator.CreateObject<IDersDataAccess, DersDataAccess>();
			OlusturCreator.CreateObject<IDersIcerikDataAccess, DersIcerikDataAccess>();

			#endregion

			#region Derslik Kısmı

			OlusturCreator.CreateObject<IDerslikDataAccess, DerslikDataAccess>();
			OlusturCreator.CreateObject<IOzelDerslikDataAccess, OzelDerslikDataAccess>();

			#endregion

			#region Guvenlik Kısmı

			OlusturCreator.CreateObject<IJetonDataAccess, JetonDataAccess>();
			OlusturCreator.CreateObject<IJetonSureDataAccess, JetonSureDataAccess>();
			OlusturCreator.CreateObject<ISahisKullaniciAdiDataAccess, SahisKullaniciAdiDataAccess>();
			OlusturCreator.CreateObject<ISahisSifreDataAccess, SahisSifreDataAccess>();

			#endregion

			#region Haftalik Plan Kısmı

			OlusturCreator.CreateObject<IGunlukIslemSaatiDataAccess, GunlukIslemSaatiDataAccess>();
			OlusturCreator.CreateObject<IOgrenciDersHariciSaatDataAccess, OgrenciDersHariciSaatDataAccess>();

			#endregion

			#region Ogrenci Kısmı

			OlusturCreator.CreateObject<IOgrenciDataAccess, OgrenciDataAccess>();

			#endregion

			#region Okul Kısmı

			OlusturCreator.CreateObject<IKisimDataAccess, KisimDataAccess>();
			OlusturCreator.CreateObject<IOkulDataAccess, OkulDataAccess>();
			OlusturCreator.CreateObject<IOkulDuzeyiDataAccess, OkulDuzeyiDataAccess>();
			OlusturCreator.CreateObject<ISinifCesitDataAccess, SinifCesitDataAccess>();
			OlusturCreator.CreateObject<ISinifDataAccess, SinifDataAccess>();

			#endregion

			#region Personel Kısmı

			//Perosnel Çeşit
			OlusturCreator.CreateObject<IEgitmenDataAccess, EgitmenDataAccess>();
			OlusturCreator.CreateObject<IMemurDataAccess, MemurDataAccess>();
			OlusturCreator.CreateObject<IPersonelDataAccess, PersonelDataAccess>();

			// Personel Ünvan
			OlusturCreator.CreateObject<IDereceDataAccess, DereceDataAccess>();
			OlusturCreator.CreateObject<IRutbeDataAccess, RutbeDataAccess>();
			OlusturCreator.CreateObject<IUnvanDataAccess, UnvanDataAccess>();

			#endregion

			#region Şahıs Kısmı

			//Şahıs Bilgi
			OlusturCreator.CreateObject<IAcikAlinanPersonelDataAccess, AcikAlinanPersonelDataAccess>();
			OlusturCreator.CreateObject<IAdresBilgisiDataAccess, AdresBilgisiDataAccess>();
			OlusturCreator.CreateObject<IEmailBilgisiDataAccess, EmailBilgisiDataAccess>();
			OlusturCreator.CreateObject<ISicilDataAccess, SicilDataAccess>();
			OlusturCreator.CreateObject<ITelefonBilgisiDataAccess, TelefonBilgisiDataAccess>();

			OlusturCreator.CreateObject<ISahisDataAccess, SahisDataAccess>();

			#endregion
		}
	}
}
