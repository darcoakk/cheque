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
    /// MfksUpdateToTransferRequest
    /// </summary>
    [DataContract(Name = "MfksUpdateToTransferRequest")]
    public partial class MfksUpdateToTransferRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksUpdateToTransferRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MfksUpdateToTransferRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksUpdateToTransferRequest" /> class.
        /// </summary>
        /// <param name="uyeEftKodu">uyeEftKodu.</param>
        /// <param name="kullaniciSicili">kullaniciSicili (required).</param>
        /// <param name="belgeReferansNo">belgeReferansNo.</param>
        /// <param name="saticiUnvan">saticiUnvan.</param>
        /// <param name="aliciUnvan">aliciUnvan.</param>
        /// <param name="kullandirimTipiKodu">kullandirimTipiKodu.</param>
        /// <param name="sektorKodu">sektorKodu.</param>
        /// <param name="malHizmetCinsi">malHizmetCinsi.</param>
        /// <param name="bankaIslemTipi">bankaIslemTipi.</param>
        /// <param name="muhasebeTarihi">muhasebeTarihi.</param>
        /// <param name="aliciNeviKimlikTip">aliciNeviKimlikTip.</param>
        /// <param name="aliciNeviKimlikNo">aliciNeviKimlikNo.</param>
        /// <param name="saticiNeviKimlikTip">saticiNeviKimlikTip.</param>
        /// <param name="saticiNeviKimlikNo">saticiNeviKimlikNo.</param>
        /// <param name="belgeVadeTarihi">belgeVadeTarihi.</param>
        /// <param name="bildirimDurumKodu">bildirimDurumKodu.</param>
        /// <param name="teyitDurumKodu">teyitDurumKodu.</param>
        /// <param name="garantiDurumuKodu">garantiDurumuKodu.</param>
        /// <param name="tahsilatTipi">tahsilatTipi.</param>
        /// <param name="proformaFaturaInputBean">proformaFaturaInputBean.</param>
        /// <param name="siparisFormuInputBean">siparisFormuInputBean.</param>
        /// <param name="satisSozlesmesiInputBean">satisSozlesmesiInputBean.</param>
        /// <param name="akreditifInputBean">akreditifInputBean.</param>
        /// <param name="faturaInputBean">faturaInputBean.</param>
        public MfksUpdateToTransferRequest(string uyeEftKodu = default(string), string kullaniciSicili = default(string), string belgeReferansNo = default(string), string saticiUnvan = default(string), string aliciUnvan = default(string), string kullandirimTipiKodu = default(string), string sektorKodu = default(string), string malHizmetCinsi = default(string), string bankaIslemTipi = default(string), string muhasebeTarihi = default(string), string aliciNeviKimlikTip = default(string), string aliciNeviKimlikNo = default(string), string saticiNeviKimlikTip = default(string), string saticiNeviKimlikNo = default(string), string belgeVadeTarihi = default(string), string bildirimDurumKodu = default(string), string teyitDurumKodu = default(string), string garantiDurumuKodu = default(string), string tahsilatTipi = default(string), ProformaFaturaBean proformaFaturaInputBean = default(ProformaFaturaBean), SiparisFormuBean siparisFormuInputBean = default(SiparisFormuBean), SatisSozlesmesiBean satisSozlesmesiInputBean = default(SatisSozlesmesiBean), AkreditifBean akreditifInputBean = default(AkreditifBean), DevirGuncelleFaturaEkGirdiParametre faturaInputBean = default(DevirGuncelleFaturaEkGirdiParametre))
        {
            // to ensure "kullaniciSicili" is required (not null)
            if (kullaniciSicili == null)
            {
                throw new ArgumentNullException("kullaniciSicili is a required property for MfksUpdateToTransferRequest and cannot be null");
            }
            this.KullaniciSicili = kullaniciSicili;
            this.UyeEftKodu = uyeEftKodu;
            this.BelgeReferansNo = belgeReferansNo;
            this.SaticiUnvan = saticiUnvan;
            this.AliciUnvan = aliciUnvan;
            this.KullandirimTipiKodu = kullandirimTipiKodu;
            this.SektorKodu = sektorKodu;
            this.MalHizmetCinsi = malHizmetCinsi;
            this.BankaIslemTipi = bankaIslemTipi;
            this.MuhasebeTarihi = muhasebeTarihi;
            this.AliciNeviKimlikTip = aliciNeviKimlikTip;
            this.AliciNeviKimlikNo = aliciNeviKimlikNo;
            this.SaticiNeviKimlikTip = saticiNeviKimlikTip;
            this.SaticiNeviKimlikNo = saticiNeviKimlikNo;
            this.BelgeVadeTarihi = belgeVadeTarihi;
            this.BildirimDurumKodu = bildirimDurumKodu;
            this.TeyitDurumKodu = teyitDurumKodu;
            this.GarantiDurumuKodu = garantiDurumuKodu;
            this.TahsilatTipi = tahsilatTipi;
            this.ProformaFaturaInputBean = proformaFaturaInputBean;
            this.SiparisFormuInputBean = siparisFormuInputBean;
            this.SatisSozlesmesiInputBean = satisSozlesmesiInputBean;
            this.AkreditifInputBean = akreditifInputBean;
            this.FaturaInputBean = faturaInputBean;
        }

        /// <summary>
        /// Gets or Sets UyeEftKodu
        /// </summary>
        [DataMember(Name = "uyeEftKodu", EmitDefaultValue = true)]
        public string UyeEftKodu { get; set; }

        /// <summary>
        /// Gets or Sets KullaniciSicili
        /// </summary>
        [DataMember(Name = "kullaniciSicili", IsRequired = true, EmitDefaultValue = true)]
        public string KullaniciSicili { get; set; }

        /// <summary>
        /// Gets or Sets BelgeReferansNo
        /// </summary>
        [DataMember(Name = "belgeReferansNo", EmitDefaultValue = true)]
        public string BelgeReferansNo { get; set; }

        /// <summary>
        /// Gets or Sets SaticiUnvan
        /// </summary>
        [DataMember(Name = "saticiUnvan", EmitDefaultValue = true)]
        public string SaticiUnvan { get; set; }

        /// <summary>
        /// Gets or Sets AliciUnvan
        /// </summary>
        [DataMember(Name = "aliciUnvan", EmitDefaultValue = true)]
        public string AliciUnvan { get; set; }

        /// <summary>
        /// Gets or Sets KullandirimTipiKodu
        /// </summary>
        [DataMember(Name = "kullandirimTipiKodu", EmitDefaultValue = true)]
        public string KullandirimTipiKodu { get; set; }

        /// <summary>
        /// Gets or Sets SektorKodu
        /// </summary>
        [DataMember(Name = "sektorKodu", EmitDefaultValue = true)]
        public string SektorKodu { get; set; }

        /// <summary>
        /// Gets or Sets MalHizmetCinsi
        /// </summary>
        [DataMember(Name = "malHizmetCinsi", EmitDefaultValue = true)]
        public string MalHizmetCinsi { get; set; }

        /// <summary>
        /// Gets or Sets BankaIslemTipi
        /// </summary>
        [DataMember(Name = "bankaIslemTipi", EmitDefaultValue = true)]
        public string BankaIslemTipi { get; set; }

        /// <summary>
        /// Gets or Sets MuhasebeTarihi
        /// </summary>
        [DataMember(Name = "muhasebeTarihi", EmitDefaultValue = true)]
        public string MuhasebeTarihi { get; set; }

        /// <summary>
        /// Gets or Sets AliciNeviKimlikTip
        /// </summary>
        [DataMember(Name = "aliciNeviKimlikTip", EmitDefaultValue = true)]
        public string AliciNeviKimlikTip { get; set; }

        /// <summary>
        /// Gets or Sets AliciNeviKimlikNo
        /// </summary>
        [DataMember(Name = "aliciNeviKimlikNo", EmitDefaultValue = true)]
        public string AliciNeviKimlikNo { get; set; }

        /// <summary>
        /// Gets or Sets SaticiNeviKimlikTip
        /// </summary>
        [DataMember(Name = "saticiNeviKimlikTip", EmitDefaultValue = true)]
        public string SaticiNeviKimlikTip { get; set; }

        /// <summary>
        /// Gets or Sets SaticiNeviKimlikNo
        /// </summary>
        [DataMember(Name = "saticiNeviKimlikNo", EmitDefaultValue = true)]
        public string SaticiNeviKimlikNo { get; set; }

        /// <summary>
        /// Gets or Sets BelgeVadeTarihi
        /// </summary>
        [DataMember(Name = "belgeVadeTarihi", EmitDefaultValue = true)]
        public string BelgeVadeTarihi { get; set; }

        /// <summary>
        /// Gets or Sets BildirimDurumKodu
        /// </summary>
        [DataMember(Name = "bildirimDurumKodu", EmitDefaultValue = true)]
        public string BildirimDurumKodu { get; set; }

        /// <summary>
        /// Gets or Sets TeyitDurumKodu
        /// </summary>
        [DataMember(Name = "teyitDurumKodu", EmitDefaultValue = true)]
        public string TeyitDurumKodu { get; set; }

        /// <summary>
        /// Gets or Sets GarantiDurumuKodu
        /// </summary>
        [DataMember(Name = "garantiDurumuKodu", EmitDefaultValue = true)]
        public string GarantiDurumuKodu { get; set; }

        /// <summary>
        /// Gets or Sets TahsilatTipi
        /// </summary>
        [DataMember(Name = "tahsilatTipi", EmitDefaultValue = true)]
        public string TahsilatTipi { get; set; }

        /// <summary>
        /// Gets or Sets ProformaFaturaInputBean
        /// </summary>
        [DataMember(Name = "proformaFaturaInputBean", EmitDefaultValue = false)]
        public ProformaFaturaBean ProformaFaturaInputBean { get; set; }

        /// <summary>
        /// Gets or Sets SiparisFormuInputBean
        /// </summary>
        [DataMember(Name = "siparisFormuInputBean", EmitDefaultValue = false)]
        public SiparisFormuBean SiparisFormuInputBean { get; set; }

        /// <summary>
        /// Gets or Sets SatisSozlesmesiInputBean
        /// </summary>
        [DataMember(Name = "satisSozlesmesiInputBean", EmitDefaultValue = false)]
        public SatisSozlesmesiBean SatisSozlesmesiInputBean { get; set; }

        /// <summary>
        /// Gets or Sets AkreditifInputBean
        /// </summary>
        [DataMember(Name = "akreditifInputBean", EmitDefaultValue = false)]
        public AkreditifBean AkreditifInputBean { get; set; }

        /// <summary>
        /// Gets or Sets FaturaInputBean
        /// </summary>
        [DataMember(Name = "faturaInputBean", EmitDefaultValue = false)]
        public DevirGuncelleFaturaEkGirdiParametre FaturaInputBean { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfksUpdateToTransferRequest {\n");
            sb.Append("  UyeEftKodu: ").Append(UyeEftKodu).Append("\n");
            sb.Append("  KullaniciSicili: ").Append(KullaniciSicili).Append("\n");
            sb.Append("  BelgeReferansNo: ").Append(BelgeReferansNo).Append("\n");
            sb.Append("  SaticiUnvan: ").Append(SaticiUnvan).Append("\n");
            sb.Append("  AliciUnvan: ").Append(AliciUnvan).Append("\n");
            sb.Append("  KullandirimTipiKodu: ").Append(KullandirimTipiKodu).Append("\n");
            sb.Append("  SektorKodu: ").Append(SektorKodu).Append("\n");
            sb.Append("  MalHizmetCinsi: ").Append(MalHizmetCinsi).Append("\n");
            sb.Append("  BankaIslemTipi: ").Append(BankaIslemTipi).Append("\n");
            sb.Append("  MuhasebeTarihi: ").Append(MuhasebeTarihi).Append("\n");
            sb.Append("  AliciNeviKimlikTip: ").Append(AliciNeviKimlikTip).Append("\n");
            sb.Append("  AliciNeviKimlikNo: ").Append(AliciNeviKimlikNo).Append("\n");
            sb.Append("  SaticiNeviKimlikTip: ").Append(SaticiNeviKimlikTip).Append("\n");
            sb.Append("  SaticiNeviKimlikNo: ").Append(SaticiNeviKimlikNo).Append("\n");
            sb.Append("  BelgeVadeTarihi: ").Append(BelgeVadeTarihi).Append("\n");
            sb.Append("  BildirimDurumKodu: ").Append(BildirimDurumKodu).Append("\n");
            sb.Append("  TeyitDurumKodu: ").Append(TeyitDurumKodu).Append("\n");
            sb.Append("  GarantiDurumuKodu: ").Append(GarantiDurumuKodu).Append("\n");
            sb.Append("  TahsilatTipi: ").Append(TahsilatTipi).Append("\n");
            sb.Append("  ProformaFaturaInputBean: ").Append(ProformaFaturaInputBean).Append("\n");
            sb.Append("  SiparisFormuInputBean: ").Append(SiparisFormuInputBean).Append("\n");
            sb.Append("  SatisSozlesmesiInputBean: ").Append(SatisSozlesmesiInputBean).Append("\n");
            sb.Append("  AkreditifInputBean: ").Append(AkreditifInputBean).Append("\n");
            sb.Append("  FaturaInputBean: ").Append(FaturaInputBean).Append("\n");
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
            // KullaniciSicili (string) minLength
            if (this.KullaniciSicili != null && this.KullaniciSicili.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for KullaniciSicili, length must be greater than 1.", new [] { "KullaniciSicili" });
            }

            yield break;
        }
    }

}
