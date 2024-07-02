using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JSGABackend.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class VeritabaniIlkKayit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AkademikDonem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkademikDonem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AkademikEgitimTuru",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkademikEgitimTuru", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AkademikYil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkademikYil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Daire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kisaltma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daire", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Derece",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kisaltma = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derece", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DersBrans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersBrans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DersIcerik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersIcerik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Derslik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kapasite = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derslik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HarfNotu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AltNot = table.Column<float>(type: "real", nullable: false),
                    UstNot = table.Column<float>(type: "real", nullable: false),
                    KrediKarsiligi = table.Column<float>(type: "real", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarfNotu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JetonSure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SureDakika = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JetonSure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotHesapYuzdesi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VizeYuzde = table.Column<float>(type: "real", nullable: false),
                    FinalYüzde = table.Column<float>(type: "real", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotHesapYuzdesi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OkulDuzeyi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OkulDuzeyi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OzelGunOlay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzelGunOlay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutbe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kisaltma = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutbe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sahis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pbik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sahis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SinifCesit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinifCesit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubeBilgi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kisaltma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubeBilgi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unvan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kisaltma = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unvan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AkademikHafta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AkademikYilId = table.Column<int>(type: "int", nullable: false),
                    AkademikDonemId = table.Column<int>(type: "int", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkademikHafta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkademikHafta_AkademikDonem_AkademikDonemId",
                        column: x => x.AkademikDonemId,
                        principalTable: "AkademikDonem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkademikHafta_AkademikYil_AkademikYilId",
                        column: x => x.AkademikYilId,
                        principalTable: "AkademikYil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Okul",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OkulDuzeyiId = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okul", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Okul_OkulDuzeyi_OkulDuzeyiId",
                        column: x => x.OkulDuzeyiId,
                        principalTable: "OkulDuzeyi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcikAlinanPersonel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcikAlDurum = table.Column<bool>(type: "bit", nullable: false),
                    AcikAlAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcikAlZamani = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    SahisId = table.Column<int>(type: "int", nullable: false),
                    PasiflikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PasifAlZamani = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcikAlinanPersonel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcikAlinanPersonel_Sahis_SahisId",
                        column: x => x.SahisId,
                        principalTable: "Sahis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdresBilgisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    SahisId = table.Column<int>(type: "int", nullable: false),
                    PasiflikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PasifAlZamani = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdresBilgisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdresBilgisi_Sahis_SahisId",
                        column: x => x.SahisId,
                        principalTable: "Sahis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailBilgisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    SahisId = table.Column<int>(type: "int", nullable: false),
                    PasiflikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PasifAlZamani = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailBilgisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailBilgisi_Sahis_SahisId",
                        column: x => x.SahisId,
                        principalTable: "Sahis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jeton",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TokenTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    SahisId = table.Column<int>(type: "int", nullable: false),
                    PasiflikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PasifAlZamani = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jeton", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jeton_Sahis_SahisId",
                        column: x => x.SahisId,
                        principalTable: "Sahis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KitaKaynaklimi = table.Column<bool>(type: "bit", nullable: false),
                    DisiplinPuani = table.Column<float>(type: "real", nullable: false),
                    MezuniyetDurumu = table.Column<bool>(type: "bit", nullable: false),
                    MezuniyetPuani = table.Column<float>(type: "real", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    SahisId = table.Column<int>(type: "int", nullable: false),
                    PasiflikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PasifAlZamani = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrenci_Sahis_SahisId",
                        column: x => x.SahisId,
                        principalTable: "Sahis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SahisKullaniciAdi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    SahisId = table.Column<int>(type: "int", nullable: false),
                    PasiflikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PasifAlZamani = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SahisKullaniciAdi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SahisKullaniciAdi_Sahis_SahisId",
                        column: x => x.SahisId,
                        principalTable: "Sahis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sicil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SicilNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    SahisId = table.Column<int>(type: "int", nullable: false),
                    PasiflikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PasifAlZamani = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sicil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sicil_Sahis_SahisId",
                        column: x => x.SahisId,
                        principalTable: "Sahis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelefonBilgisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CepTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    SahisId = table.Column<int>(type: "int", nullable: false),
                    PasiflikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PasifAlZamani = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonBilgisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelefonBilgisi_Sahis_SahisId",
                        column: x => x.SahisId,
                        principalTable: "Sahis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sube",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaireId = table.Column<int>(type: "int", nullable: false),
                    SubeBilgiId = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sube", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sube_Daire_DaireId",
                        column: x => x.DaireId,
                        principalTable: "Daire",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sube_SubeBilgi_SubeBilgiId",
                        column: x => x.SubeBilgiId,
                        principalTable: "SubeBilgi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkademikHaftaOzelGunleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OzelGunOlayId = table.Column<int>(type: "int", nullable: false),
                    AkademikHaftaId = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkademikHaftaOzelGunleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkademikHaftaOzelGunleri_AkademikHafta_AkademikHaftaId",
                        column: x => x.AkademikHaftaId,
                        principalTable: "AkademikHafta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkademikHaftaOzelGunleri_OzelGunOlay_OzelGunOlayId",
                        column: x => x.OzelGunOlayId,
                        principalTable: "OzelGunOlay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sinif",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OkulId = table.Column<int>(type: "int", nullable: false),
                    SinifCesitId = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinif", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sinif_Okul_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okul",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sinif_SinifCesit_SinifCesitId",
                        column: x => x.SinifCesitId,
                        principalTable: "SinifCesit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SahisSifre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SahisKullaniciAdiId = table.Column<int>(type: "int", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SahisSifre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SahisSifre_SahisKullaniciAdi_SahisKullaniciAdiId",
                        column: x => x.SahisKullaniciAdiId,
                        principalTable: "SahisKullaniciAdi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Egitmen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnvanId = table.Column<int>(type: "int", nullable: false),
                    SubeId = table.Column<int>(type: "int", nullable: true),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    SahisId = table.Column<int>(type: "int", nullable: false),
                    PasiflikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PasifAlZamani = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitmen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Egitmen_Sahis_SahisId",
                        column: x => x.SahisId,
                        principalTable: "Sahis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Egitmen_Sube_SubeId",
                        column: x => x.SubeId,
                        principalTable: "Sube",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Egitmen_Unvan_UnvanId",
                        column: x => x.UnvanId,
                        principalTable: "Unvan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Memur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DereceId = table.Column<int>(type: "int", nullable: false),
                    SubeId = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    SahisId = table.Column<int>(type: "int", nullable: false),
                    PasiflikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PasifAlZamani = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Memur_Derece_DereceId",
                        column: x => x.DereceId,
                        principalTable: "Derece",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memur_Sahis_SahisId",
                        column: x => x.SahisId,
                        principalTable: "Sahis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memur_Sube_SubeId",
                        column: x => x.SubeId,
                        principalTable: "Sube",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RutbeId = table.Column<int>(type: "int", nullable: false),
                    SubeId = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false),
                    SahisId = table.Column<int>(type: "int", nullable: false),
                    PasiflikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    PasifAlZamani = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personel_Rutbe_RutbeId",
                        column: x => x.RutbeId,
                        principalTable: "Rutbe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personel_Sahis_SahisId",
                        column: x => x.SahisId,
                        principalTable: "Sahis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personel_Sube_SubeId",
                        column: x => x.SubeId,
                        principalTable: "Sube",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkademikEgitim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinifId = table.Column<int>(type: "int", nullable: true),
                    AkademikHaftaId = table.Column<int>(type: "int", nullable: false),
                    AkademikEgitimTuruId = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkademikEgitim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkademikEgitim_AkademikEgitimTuru_AkademikEgitimTuruId",
                        column: x => x.AkademikEgitimTuruId,
                        principalTable: "AkademikEgitimTuru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkademikEgitim_AkademikHafta_AkademikHaftaId",
                        column: x => x.AkademikHaftaId,
                        principalTable: "AkademikHafta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkademikEgitim_Sinif_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Sinif",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersIcerikId = table.Column<int>(type: "int", nullable: false),
                    AkademikYilId = table.Column<int>(type: "int", nullable: false),
                    AkademikDonemId = table.Column<int>(type: "int", nullable: false),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    DersBransId = table.Column<int>(type: "int", nullable: false),
                    DersKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AKTS = table.Column<float>(type: "real", nullable: false),
                    Katsayi = table.Column<float>(type: "real", nullable: false),
                    Kredi = table.Column<float>(type: "real", nullable: false),
                    HaftalikTeorikSaat = table.Column<float>(type: "real", nullable: false),
                    HaftalikUygulamaliSaat = table.Column<float>(type: "real", nullable: false),
                    HaftaSayisi = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ders_AkademikDonem_AkademikDonemId",
                        column: x => x.AkademikDonemId,
                        principalTable: "AkademikDonem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ders_AkademikYil_AkademikYilId",
                        column: x => x.AkademikYilId,
                        principalTable: "AkademikYil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ders_DersBrans_DersBransId",
                        column: x => x.DersBransId,
                        principalTable: "DersBrans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ders_DersIcerik_DersIcerikId",
                        column: x => x.DersIcerikId,
                        principalTable: "DersIcerik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ders_Sinif_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Sinif",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunlukIslemSaati",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    SaatAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuresiDakika = table.Column<int>(type: "int", nullable: false),
                    BaslangicSaat = table.Column<int>(type: "int", nullable: false),
                    BaslangicDakika = table.Column<int>(type: "int", nullable: false),
                    HaftadakiGun = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunlukIslemSaati", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GunlukIslemSaati_Sinif_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Sinif",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kisim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kapasite = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kisim_Sinif_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Sinif",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OzelDerslik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    DerslikId = table.Column<int>(type: "int", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzelDerslik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OzelDerslik_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OzelDerslik_Derslik_DerslikId",
                        column: x => x.DerslikId,
                        principalTable: "Derslik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDersHariciSaat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkademikYilId = table.Column<int>(type: "int", nullable: false),
                    AkademikDonemId = table.Column<int>(type: "int", nullable: false),
                    GunlukIslemSaatiId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDersHariciSaat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciDersHariciSaat_AkademikDonem_AkademikDonemId",
                        column: x => x.AkademikDonemId,
                        principalTable: "AkademikDonem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDersHariciSaat_AkademikYil_AkademikYilId",
                        column: x => x.AkademikYilId,
                        principalTable: "AkademikYil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDersHariciSaat_GunlukIslemSaati_GunlukIslemSaatiId",
                        column: x => x.GunlukIslemSaatiId,
                        principalTable: "GunlukIslemSaati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EgitmenDersVerme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EgitmenId = table.Column<int>(type: "int", nullable: false),
                    KisimId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    DerslikId = table.Column<int>(type: "int", nullable: false),
                    AkademikYilId = table.Column<int>(type: "int", nullable: false),
                    AkademikDonemId = table.Column<int>(type: "int", nullable: false),
                    GunlukIslemSaatiId = table.Column<int>(type: "int", nullable: false),
                    GecmeNotu = table.Column<float>(type: "real", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgitmenDersVerme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EgitmenDersVerme_AkademikDonem_AkademikDonemId",
                        column: x => x.AkademikDonemId,
                        principalTable: "AkademikDonem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EgitmenDersVerme_AkademikYil_AkademikYilId",
                        column: x => x.AkademikYilId,
                        principalTable: "AkademikYil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EgitmenDersVerme_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction,
                        onUpdate: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EgitmenDersVerme_Derslik_DerslikId",
                        column: x => x.DerslikId,
                        principalTable: "Derslik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EgitmenDersVerme_Egitmen_EgitmenId",
                        column: x => x.EgitmenId,
                        principalTable: "Egitmen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EgitmenDersVerme_GunlukIslemSaati_GunlukIslemSaatiId",
                        column: x => x.GunlukIslemSaatiId,
                        principalTable: "GunlukIslemSaati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EgitmenDersVerme_Kisim_KisimId",
                        column: x => x.KisimId,
                        principalTable: "Kisim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDersAlma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    KisimId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    AkademikYilId = table.Column<int>(type: "int", nullable: false),
                    AkademikDonemId = table.Column<int>(type: "int", nullable: false),
                    HarfNotuId = table.Column<int>(type: "int", nullable: true),
                    Vize = table.Column<float>(type: "real", nullable: false),
                    Final = table.Column<float>(type: "real", nullable: false),
                    Butunleme = table.Column<float>(type: "real", nullable: false),
                    Muafiyet = table.Column<bool>(type: "bit", nullable: false),
                    Alttan = table.Column<bool>(type: "bit", nullable: false),
                    Notu = table.Column<float>(type: "real", nullable: false),
                    SartliGecmeDurumu = table.Column<bool>(type: "bit", nullable: false),
                    GecmeDurumu = table.Column<bool>(type: "bit", nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDersAlma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciDersAlma_AkademikDonem_AkademikDonemId",
                        column: x => x.AkademikDonemId,
                        principalTable: "AkademikDonem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDersAlma_AkademikYil_AkademikYilId",
                        column: x => x.AkademikYilId,
                        principalTable: "AkademikYil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDersAlma_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OgrenciDersAlma_HarfNotu_HarfNotuId",
                        column: x => x.HarfNotuId,
                        principalTable: "HarfNotu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OgrenciDersAlma_Kisim_KisimId",
                        column: x => x.KisimId,
                        principalTable: "Kisim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OgrenciDersAlma_Ogrenci_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcikAlinanPersonel_SahisId",
                table: "AcikAlinanPersonel",
                column: "SahisId");

            migrationBuilder.CreateIndex(
                name: "IX_AdresBilgisi_SahisId",
                table: "AdresBilgisi",
                column: "SahisId");

            migrationBuilder.CreateIndex(
                name: "IX_AkademikEgitim_AkademikEgitimTuruId",
                table: "AkademikEgitim",
                column: "AkademikEgitimTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_AkademikEgitim_AkademikHaftaId",
                table: "AkademikEgitim",
                column: "AkademikHaftaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkademikEgitim_SinifId",
                table: "AkademikEgitim",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_AkademikHafta_AkademikDonemId",
                table: "AkademikHafta",
                column: "AkademikDonemId");

            migrationBuilder.CreateIndex(
                name: "IX_AkademikHafta_AkademikYilId",
                table: "AkademikHafta",
                column: "AkademikYilId");

            migrationBuilder.CreateIndex(
                name: "IX_AkademikHaftaOzelGunleri_AkademikHaftaId",
                table: "AkademikHaftaOzelGunleri",
                column: "AkademikHaftaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkademikHaftaOzelGunleri_OzelGunOlayId",
                table: "AkademikHaftaOzelGunleri",
                column: "OzelGunOlayId");

            migrationBuilder.CreateIndex(
                name: "IX_Ders_AkademikDonemId",
                table: "Ders",
                column: "AkademikDonemId");

            migrationBuilder.CreateIndex(
                name: "IX_Ders_AkademikYilId",
                table: "Ders",
                column: "AkademikYilId");

            migrationBuilder.CreateIndex(
                name: "IX_Ders_DersBransId",
                table: "Ders",
                column: "DersBransId");

            migrationBuilder.CreateIndex(
                name: "IX_Ders_DersIcerikId",
                table: "Ders",
                column: "DersIcerikId");

            migrationBuilder.CreateIndex(
                name: "IX_Ders_SinifId",
                table: "Ders",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitmen_SahisId",
                table: "Egitmen",
                column: "SahisId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitmen_SubeId",
                table: "Egitmen",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitmen_UnvanId",
                table: "Egitmen",
                column: "UnvanId");

            migrationBuilder.CreateIndex(
                name: "IX_EgitmenDersVerme_AkademikDonemId",
                table: "EgitmenDersVerme",
                column: "AkademikDonemId");

            migrationBuilder.CreateIndex(
                name: "IX_EgitmenDersVerme_AkademikYilId",
                table: "EgitmenDersVerme",
                column: "AkademikYilId");

            migrationBuilder.CreateIndex(
                name: "IX_EgitmenDersVerme_DersId",
                table: "EgitmenDersVerme",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_EgitmenDersVerme_DerslikId",
                table: "EgitmenDersVerme",
                column: "DerslikId");

            migrationBuilder.CreateIndex(
                name: "IX_EgitmenDersVerme_EgitmenId",
                table: "EgitmenDersVerme",
                column: "EgitmenId");

            migrationBuilder.CreateIndex(
                name: "IX_EgitmenDersVerme_GunlukIslemSaatiId",
                table: "EgitmenDersVerme",
                column: "GunlukIslemSaatiId");

            migrationBuilder.CreateIndex(
                name: "IX_EgitmenDersVerme_KisimId",
                table: "EgitmenDersVerme",
                column: "KisimId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailBilgisi_SahisId",
                table: "EmailBilgisi",
                column: "SahisId");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukIslemSaati_SinifId",
                table: "GunlukIslemSaati",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_Jeton_SahisId",
                table: "Jeton",
                column: "SahisId");

            migrationBuilder.CreateIndex(
                name: "IX_Kisim_SinifId",
                table: "Kisim",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_Memur_DereceId",
                table: "Memur",
                column: "DereceId");

            migrationBuilder.CreateIndex(
                name: "IX_Memur_SahisId",
                table: "Memur",
                column: "SahisId");

            migrationBuilder.CreateIndex(
                name: "IX_Memur_SubeId",
                table: "Memur",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_SahisId",
                table: "Ogrenci",
                column: "SahisId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersAlma_AkademikDonemId",
                table: "OgrenciDersAlma",
                column: "AkademikDonemId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersAlma_AkademikYilId",
                table: "OgrenciDersAlma",
                column: "AkademikYilId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersAlma_DersId",
                table: "OgrenciDersAlma",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersAlma_HarfNotuId",
                table: "OgrenciDersAlma",
                column: "HarfNotuId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersAlma_KisimId",
                table: "OgrenciDersAlma",
                column: "KisimId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersAlma_OgrenciId",
                table: "OgrenciDersAlma",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersHariciSaat_AkademikDonemId",
                table: "OgrenciDersHariciSaat",
                column: "AkademikDonemId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersHariciSaat_AkademikYilId",
                table: "OgrenciDersHariciSaat",
                column: "AkademikYilId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersHariciSaat_GunlukIslemSaatiId",
                table: "OgrenciDersHariciSaat",
                column: "GunlukIslemSaatiId");

            migrationBuilder.CreateIndex(
                name: "IX_Okul_OkulDuzeyiId",
                table: "Okul",
                column: "OkulDuzeyiId");

            migrationBuilder.CreateIndex(
                name: "IX_OzelDerslik_DersId",
                table: "OzelDerslik",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_OzelDerslik_DerslikId",
                table: "OzelDerslik",
                column: "DerslikId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_RutbeId",
                table: "Personel",
                column: "RutbeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_SahisId",
                table: "Personel",
                column: "SahisId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_SubeId",
                table: "Personel",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_SahisKullaniciAdi_SahisId",
                table: "SahisKullaniciAdi",
                column: "SahisId");

            migrationBuilder.CreateIndex(
                name: "IX_SahisSifre_SahisKullaniciAdiId",
                table: "SahisSifre",
                column: "SahisKullaniciAdiId");

            migrationBuilder.CreateIndex(
                name: "IX_Sicil_SahisId",
                table: "Sicil",
                column: "SahisId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinif_OkulId",
                table: "Sinif",
                column: "OkulId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinif_SinifCesitId",
                table: "Sinif",
                column: "SinifCesitId");

            migrationBuilder.CreateIndex(
                name: "IX_Sube_DaireId",
                table: "Sube",
                column: "DaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Sube_SubeBilgiId",
                table: "Sube",
                column: "SubeBilgiId");

            migrationBuilder.CreateIndex(
                name: "IX_TelefonBilgisi_SahisId",
                table: "TelefonBilgisi",
                column: "SahisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcikAlinanPersonel");

            migrationBuilder.DropTable(
                name: "AdresBilgisi");

            migrationBuilder.DropTable(
                name: "AkademikEgitim");

            migrationBuilder.DropTable(
                name: "AkademikHaftaOzelGunleri");

            migrationBuilder.DropTable(
                name: "EgitmenDersVerme");

            migrationBuilder.DropTable(
                name: "EmailBilgisi");

            migrationBuilder.DropTable(
                name: "Jeton");

            migrationBuilder.DropTable(
                name: "JetonSure");

            migrationBuilder.DropTable(
                name: "Memur");

            migrationBuilder.DropTable(
                name: "NotHesapYuzdesi");

            migrationBuilder.DropTable(
                name: "OgrenciDersAlma");

            migrationBuilder.DropTable(
                name: "OgrenciDersHariciSaat");

            migrationBuilder.DropTable(
                name: "OzelDerslik");

            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "SahisSifre");

            migrationBuilder.DropTable(
                name: "Sicil");

            migrationBuilder.DropTable(
                name: "TelefonBilgisi");

            migrationBuilder.DropTable(
                name: "AkademikEgitimTuru");

            migrationBuilder.DropTable(
                name: "AkademikHafta");

            migrationBuilder.DropTable(
                name: "OzelGunOlay");

            migrationBuilder.DropTable(
                name: "Egitmen");

            migrationBuilder.DropTable(
                name: "Derece");

            migrationBuilder.DropTable(
                name: "HarfNotu");

            migrationBuilder.DropTable(
                name: "Kisim");

            migrationBuilder.DropTable(
                name: "Ogrenci");

            migrationBuilder.DropTable(
                name: "GunlukIslemSaati");

            migrationBuilder.DropTable(
                name: "Ders");

            migrationBuilder.DropTable(
                name: "Derslik");

            migrationBuilder.DropTable(
                name: "Rutbe");

            migrationBuilder.DropTable(
                name: "SahisKullaniciAdi");

            migrationBuilder.DropTable(
                name: "Sube");

            migrationBuilder.DropTable(
                name: "Unvan");

            migrationBuilder.DropTable(
                name: "AkademikDonem");

            migrationBuilder.DropTable(
                name: "AkademikYil");

            migrationBuilder.DropTable(
                name: "DersBrans");

            migrationBuilder.DropTable(
                name: "DersIcerik");

            migrationBuilder.DropTable(
                name: "Sinif");

            migrationBuilder.DropTable(
                name: "Sahis");

            migrationBuilder.DropTable(
                name: "Daire");

            migrationBuilder.DropTable(
                name: "SubeBilgi");

            migrationBuilder.DropTable(
                name: "Okul");

            migrationBuilder.DropTable(
                name: "SinifCesit");

            migrationBuilder.DropTable(
                name: "OkulDuzeyi");
        }
    }
}
