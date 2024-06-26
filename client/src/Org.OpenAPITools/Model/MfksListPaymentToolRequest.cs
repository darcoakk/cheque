/*
 * Faktoring API - Test
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// MfksListPaymentToolRequest
    /// </summary>
    [DataContract(Name = "MfksListPaymentToolRequest")]
    public partial class MfksListPaymentToolRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksListPaymentToolRequest" /> class.
        /// </summary>
        /// <param name="kullaniciSicili">kullaniciSicili.</param>
        /// <param name="belgeReferansNo">belgeReferansNo.</param>
        /// <param name="odemeAraciTipi">odemeAraciTipi.</param>
        /// <param name="belgeTahsilDurumu">belgeTahsilDurumu.</param>
        /// <param name="odemeAraciTahsilDurumu">odemeAraciTahsilDurumu.</param>
        /// <param name="belgeIslemTarihiMin">belgeIslemTarihiMin.</param>
        /// <param name="belgeIslemTarihiMax">belgeIslemTarihiMax.</param>
        /// <param name="acikHesapListelensin">acikHesapListelensin.</param>
        /// <param name="aralik">aralik.</param>
        /// <param name="odemeAraciReferansNo">odemeAraciReferansNo.</param>
        /// <param name="belgeVadeTarihiMin">belgeVadeTarihiMin.</param>
        /// <param name="belgeVadeTarihiMax">belgeVadeTarihiMax.</param>
        /// <param name="kesideciKimlikTip">kesideciKimlikTip.</param>
        /// <param name="kesideciKimlikNo">kesideciKimlikNo.</param>
        /// <param name="sonCirantaKimlikTip">sonCirantaKimlikTip.</param>
        /// <param name="sonCirantaKimlikNo">sonCirantaKimlikNo.</param>
        /// <param name="cekHesapNo">cekHesapNo.</param>
        /// <param name="cekSiraNo">cekSiraNo.</param>
        /// <param name="cekBankasi">cekBankasi.</param>
        /// <param name="cekSubesi">cekSubesi.</param>
        /// <param name="cekTutari">cekTutari.</param>
        /// <param name="cekDovizCinsi">cekDovizCinsi.</param>
        /// <param name="minimumVadeTarihi">minimumVadeTarihi.</param>
        /// <param name="maksimumVadeTarihi">maksimumVadeTarihi.</param>
        public MfksListPaymentToolRequest(string kullaniciSicili = default(string), string belgeReferansNo = default(string), string odemeAraciTipi = default(string), string belgeTahsilDurumu = default(string), string odemeAraciTahsilDurumu = default(string), string belgeIslemTarihiMin = default(string), string belgeIslemTarihiMax = default(string), string acikHesapListelensin = default(string), int aralik = default(int), string odemeAraciReferansNo = default(string), string belgeVadeTarihiMin = default(string), string belgeVadeTarihiMax = default(string), string kesideciKimlikTip = default(string), string kesideciKimlikNo = default(string), string sonCirantaKimlikTip = default(string), string sonCirantaKimlikNo = default(string), string cekHesapNo = default(string), string cekSiraNo = default(string), string cekBankasi = default(string), string cekSubesi = default(string), double cekTutari = default(double), string cekDovizCinsi = default(string), string minimumVadeTarihi = default(string), string maksimumVadeTarihi = default(string))
        {
            this.KullaniciSicili = kullaniciSicili;
            this.BelgeReferansNo = belgeReferansNo;
            this.OdemeAraciTipi = odemeAraciTipi;
            this.BelgeTahsilDurumu = belgeTahsilDurumu;
            this.OdemeAraciTahsilDurumu = odemeAraciTahsilDurumu;
            this.BelgeIslemTarihiMin = belgeIslemTarihiMin;
            this.BelgeIslemTarihiMax = belgeIslemTarihiMax;
            this.AcikHesapListelensin = acikHesapListelensin;
            this.Aralik = aralik;
            this.OdemeAraciReferansNo = odemeAraciReferansNo;
            this.BelgeVadeTarihiMin = belgeVadeTarihiMin;
            this.BelgeVadeTarihiMax = belgeVadeTarihiMax;
            this.KesideciKimlikTip = kesideciKimlikTip;
            this.KesideciKimlikNo = kesideciKimlikNo;
            this.SonCirantaKimlikTip = sonCirantaKimlikTip;
            this.SonCirantaKimlikNo = sonCirantaKimlikNo;
            this.CekHesapNo = cekHesapNo;
            this.CekSiraNo = cekSiraNo;
            this.CekBankasi = cekBankasi;
            this.CekSubesi = cekSubesi;
            this.CekTutari = cekTutari;
            this.CekDovizCinsi = cekDovizCinsi;
            this.MinimumVadeTarihi = minimumVadeTarihi;
            this.MaksimumVadeTarihi = maksimumVadeTarihi;
        }

        /// <summary>
        /// Gets or Sets KullaniciSicili
        /// </summary>
        [DataMember(Name = "kullaniciSicili", EmitDefaultValue = true)]
        public string KullaniciSicili { get; set; }

        /// <summary>
        /// Gets or Sets BelgeReferansNo
        /// </summary>
        [DataMember(Name = "belgeReferansNo", EmitDefaultValue = true)]
        public string BelgeReferansNo { get; set; }

        /// <summary>
        /// Gets or Sets OdemeAraciTipi
        /// </summary>
        [DataMember(Name = "odemeAraciTipi", EmitDefaultValue = true)]
        public string OdemeAraciTipi { get; set; }

        /// <summary>
        /// Gets or Sets BelgeTahsilDurumu
        /// </summary>
        [DataMember(Name = "belgeTahsilDurumu", EmitDefaultValue = true)]
        public string BelgeTahsilDurumu { get; set; }

        /// <summary>
        /// Gets or Sets OdemeAraciTahsilDurumu
        /// </summary>
        [DataMember(Name = "odemeAraciTahsilDurumu", EmitDefaultValue = true)]
        public string OdemeAraciTahsilDurumu { get; set; }

        /// <summary>
        /// Gets or Sets BelgeIslemTarihiMin
        /// </summary>
        [DataMember(Name = "belgeIslemTarihiMin", EmitDefaultValue = true)]
        public string BelgeIslemTarihiMin { get; set; }

        /// <summary>
        /// Gets or Sets BelgeIslemTarihiMax
        /// </summary>
        [DataMember(Name = "belgeIslemTarihiMax", EmitDefaultValue = true)]
        public string BelgeIslemTarihiMax { get; set; }

        /// <summary>
        /// Gets or Sets AcikHesapListelensin
        /// </summary>
        [DataMember(Name = "acikHesapListelensin", EmitDefaultValue = true)]
        public string AcikHesapListelensin { get; set; }

        /// <summary>
        /// Gets or Sets Aralik
        /// </summary>
        [DataMember(Name = "aralik", EmitDefaultValue = false)]
        public int Aralik { get; set; }

        /// <summary>
        /// Gets or Sets OdemeAraciReferansNo
        /// </summary>
        [DataMember(Name = "odemeAraciReferansNo", EmitDefaultValue = true)]
        public string OdemeAraciReferansNo { get; set; }

        /// <summary>
        /// Gets or Sets BelgeVadeTarihiMin
        /// </summary>
        [DataMember(Name = "belgeVadeTarihiMin", EmitDefaultValue = true)]
        public string BelgeVadeTarihiMin { get; set; }

        /// <summary>
        /// Gets or Sets BelgeVadeTarihiMax
        /// </summary>
        [DataMember(Name = "belgeVadeTarihiMax", EmitDefaultValue = true)]
        public string BelgeVadeTarihiMax { get; set; }

        /// <summary>
        /// Gets or Sets KesideciKimlikTip
        /// </summary>
        [DataMember(Name = "kesideciKimlikTip", EmitDefaultValue = true)]
        public string KesideciKimlikTip { get; set; }

        /// <summary>
        /// Gets or Sets KesideciKimlikNo
        /// </summary>
        [DataMember(Name = "kesideciKimlikNo", EmitDefaultValue = true)]
        public string KesideciKimlikNo { get; set; }

        /// <summary>
        /// Gets or Sets SonCirantaKimlikTip
        /// </summary>
        [DataMember(Name = "sonCirantaKimlikTip", EmitDefaultValue = true)]
        public string SonCirantaKimlikTip { get; set; }

        /// <summary>
        /// Gets or Sets SonCirantaKimlikNo
        /// </summary>
        [DataMember(Name = "sonCirantaKimlikNo", EmitDefaultValue = true)]
        public string SonCirantaKimlikNo { get; set; }

        /// <summary>
        /// Gets or Sets CekHesapNo
        /// </summary>
        [DataMember(Name = "cekHesapNo", EmitDefaultValue = true)]
        public string CekHesapNo { get; set; }

        /// <summary>
        /// Gets or Sets CekSiraNo
        /// </summary>
        [DataMember(Name = "cekSiraNo", EmitDefaultValue = true)]
        public string CekSiraNo { get; set; }

        /// <summary>
        /// Gets or Sets CekBankasi
        /// </summary>
        [DataMember(Name = "cekBankasi", EmitDefaultValue = true)]
        public string CekBankasi { get; set; }

        /// <summary>
        /// Gets or Sets CekSubesi
        /// </summary>
        [DataMember(Name = "cekSubesi", EmitDefaultValue = true)]
        public string CekSubesi { get; set; }

        /// <summary>
        /// Gets or Sets CekTutari
        /// </summary>
        [DataMember(Name = "cekTutari", EmitDefaultValue = false)]
        public double CekTutari { get; set; }

        /// <summary>
        /// Gets or Sets CekDovizCinsi
        /// </summary>
        [DataMember(Name = "cekDovizCinsi", EmitDefaultValue = true)]
        public string CekDovizCinsi { get; set; }

        /// <summary>
        /// Gets or Sets MinimumVadeTarihi
        /// </summary>
        [DataMember(Name = "minimumVadeTarihi", EmitDefaultValue = true)]
        public string MinimumVadeTarihi { get; set; }

        /// <summary>
        /// Gets or Sets MaksimumVadeTarihi
        /// </summary>
        [DataMember(Name = "maksimumVadeTarihi", EmitDefaultValue = true)]
        public string MaksimumVadeTarihi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfksListPaymentToolRequest {\n");
            sb.Append("  KullaniciSicili: ").Append(KullaniciSicili).Append("\n");
            sb.Append("  BelgeReferansNo: ").Append(BelgeReferansNo).Append("\n");
            sb.Append("  OdemeAraciTipi: ").Append(OdemeAraciTipi).Append("\n");
            sb.Append("  BelgeTahsilDurumu: ").Append(BelgeTahsilDurumu).Append("\n");
            sb.Append("  OdemeAraciTahsilDurumu: ").Append(OdemeAraciTahsilDurumu).Append("\n");
            sb.Append("  BelgeIslemTarihiMin: ").Append(BelgeIslemTarihiMin).Append("\n");
            sb.Append("  BelgeIslemTarihiMax: ").Append(BelgeIslemTarihiMax).Append("\n");
            sb.Append("  AcikHesapListelensin: ").Append(AcikHesapListelensin).Append("\n");
            sb.Append("  Aralik: ").Append(Aralik).Append("\n");
            sb.Append("  OdemeAraciReferansNo: ").Append(OdemeAraciReferansNo).Append("\n");
            sb.Append("  BelgeVadeTarihiMin: ").Append(BelgeVadeTarihiMin).Append("\n");
            sb.Append("  BelgeVadeTarihiMax: ").Append(BelgeVadeTarihiMax).Append("\n");
            sb.Append("  KesideciKimlikTip: ").Append(KesideciKimlikTip).Append("\n");
            sb.Append("  KesideciKimlikNo: ").Append(KesideciKimlikNo).Append("\n");
            sb.Append("  SonCirantaKimlikTip: ").Append(SonCirantaKimlikTip).Append("\n");
            sb.Append("  SonCirantaKimlikNo: ").Append(SonCirantaKimlikNo).Append("\n");
            sb.Append("  CekHesapNo: ").Append(CekHesapNo).Append("\n");
            sb.Append("  CekSiraNo: ").Append(CekSiraNo).Append("\n");
            sb.Append("  CekBankasi: ").Append(CekBankasi).Append("\n");
            sb.Append("  CekSubesi: ").Append(CekSubesi).Append("\n");
            sb.Append("  CekTutari: ").Append(CekTutari).Append("\n");
            sb.Append("  CekDovizCinsi: ").Append(CekDovizCinsi).Append("\n");
            sb.Append("  MinimumVadeTarihi: ").Append(MinimumVadeTarihi).Append("\n");
            sb.Append("  MaksimumVadeTarihi: ").Append(MaksimumVadeTarihi).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
