using ApplicationSettings;
using JSGABackend.Entity.Concrete.Other.AkademikKisim;
using JSGABackend.Entity.Concrete.Other.BirimKismi;
using JSGABackend.Entity.Concrete.Other.DersAlmaVermeKismi;
using JSGABackend.Entity.Concrete.Other.DersKismi;
using JSGABackend.Entity.Concrete.Other.DerslikKismi;
using JSGABackend.Entity.Concrete.Other.GuvenlikKismi;
using JSGABackend.Entity.Concrete.Other.HaftalikPlanKismi;
using JSGABackend.Entity.Concrete.Other.OgrenciKismi;
using JSGABackend.Entity.Concrete.Other.OkulKismi;
using JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelCesit;
using JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelUnvan;
using JSGABackend.Entity.Concrete.Other.SahisKismi;
using JSGABackend.Entity.Concrete.Other.SahisKismi.SahisBilgi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace JSGABackend.Contexts
{
    public class EntityFrameworkContextMsSql : DbContext
    {
        public EntityFrameworkContextMsSql() : base()
        {

        }

        public EntityFrameworkContextMsSql(DbContextOptions<EntityFrameworkContextMsSql> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                Configuration.create().ConfigManager.GetConnectionString(
                    ConfigurationConnectionStringNames.MsSql
                    ));
            base.OnConfiguring(optionsBuilder);
        }

        #region Akademik Kısım

        DbSet<AkademikDonem> AkademikDonem { get; set; }
        DbSet<AkademikEgitim> AkademikEgitim { get; set; }
        DbSet<AkademikEgitimTuru> AkademikEgitimTuru { get; set; }
        DbSet<AkademikHafta> AkademikHafta { get; set; }
        DbSet<AkademikHaftaOzelGunleri> AkademikHaftaOzelGunleri { get; set; }
        DbSet<AkademikYil> AkademikYil { get; set; }
        DbSet<OzelGunOlay> OzelGunOlay { get; set; }

        #endregion

        #region Birim Kısım

        DbSet<Daire> Daire { get; set; }
        DbSet<SubeBilgi> SubeBilgi { get; set; }
        DbSet<Sube> Sube { get; set; }

        #endregion

        #region Ders Alma Verme Kısmı

        DbSet<EgitmenDersVerme> EgitmenDersVerme { get; set; }
        DbSet<HarfNotu> HarfNotu { get; set; }
        DbSet<NotHesapYuzdesi> NotHesapYuzdesi { get; set; }
        DbSet<OgrenciDersAlma> OgrenciDersAlma { get; set; }

        #endregion


        #region Ders Kısmı

        DbSet<DersBrans> DersBrans { get; set; }
        DbSet<Ders> Ders { get; set; }
        DbSet<DersIcerik> DersIcerik { get; set; }

        #endregion

        #region Derslik Kısmı

        DbSet<Derslik> Derslik { get; set; }
        DbSet<OzelDerslik> OzelDerslik { get; set; }

        #endregion

        #region Guvenlik Kısmı

        DbSet<Jeton> Jeton { get; set; }
        DbSet<JetonSure> JetonSure { get; set; }
        DbSet<SahisKullaniciAdi> SahisKullaniciAdi { get; set; }
        DbSet<SahisSifre> SahisSifre { get; set; }

        #endregion

        #region Haftalik Plan Kısmı

        DbSet<GunlukIslemSaati> GunlukIslemSaati { get; set; }
        DbSet<OgrenciDersHariciSaat> OgrenciDersHariciSaat { get; set; }

        #endregion

        #region Ogrenci Kısmı

        DbSet<Ogrenci> Ogrenci { get; set; }

        #endregion

        #region Okul Kısmı

        DbSet<Kisim> Kisim { get; set; }
        DbSet<Okul> Okul { get; set; }
        DbSet<OkulDuzeyi> OkulDuzeyi { get; set; }
        DbSet<SinifCesit> SinifCesit { get; set; }
        DbSet<Sinif> Sinif { get; set; }

        #endregion

        #region Personel Kısmı

        //Perosnel Çeşit
        DbSet<Egitmen> Egitmen { get; set; }
        DbSet<Memur> Memur { get; set; }
        DbSet<Personel> Personel { get; set; }

        // Personel Ünvan
        DbSet<Derece> Derece { get; set; }
        DbSet<Rutbe> Rutbe { get; set; }
        DbSet<Unvan> Unvan { get; set; }

        #endregion

        #region Şahıs Kısmı

        //Şahıs Bilgi
        DbSet<AcikAlinanPersonel> AcikAlinanPersonel { get; set; }
        DbSet<AdresBilgisi> AdresBilgisi { get; set; }
        DbSet<EmailBilgisi> EmailBilgisi { get; set; }
        DbSet<Sicil> Sicil { get; set; }
        DbSet<TelefonBilgisi> TelefonBilgisi { get; set; }
        DbSet<Sahis> Sahis { get; set; }

        #endregion


    }
}
