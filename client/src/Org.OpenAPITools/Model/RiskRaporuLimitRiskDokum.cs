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
    /// RiskRaporuLimitRiskDokum
    /// </summary>
    [DataContract(Name = "RiskRaporuLimitRiskDokum")]
    public partial class RiskRaporuLimitRiskDokum : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskRaporuLimitRiskDokum" /> class.
        /// </summary>
        /// <param name="lrKaynakKodu">lrKaynakKodu.</param>
        /// <param name="lrKaynakTuru">lrKaynakTuru.</param>
        /// <param name="lrKaynakAdi">lrKaynakAdi.</param>
        /// <param name="lrNakdiLimit">lrNakdiLimit.</param>
        /// <param name="lrGayriNakdiLimit">lrGayriNakdiLimit.</param>
        /// <param name="lrToplamLimit">lrToplamLimit.</param>
        /// <param name="lrGenelRevizeVadesi">lrGenelRevizeVadesi.</param>
        /// <param name="lrGrupLimit">lrGrupLimit.</param>
        /// <param name="lrNakdiRisk">lrNakdiRisk.</param>
        /// <param name="lrGayriNakdiRisk">lrGayriNakdiRisk.</param>
        /// <param name="lrToplamRisk">lrToplamRisk.</param>
        /// <param name="lrGrupRisk">lrGrupRisk.</param>
        /// <param name="lrGecikenHesapSayisi">lrGecikenHesapSayisi.</param>
        /// <param name="lrToplamGecikmisTutar">lrToplamGecikmisTutar.</param>
        /// <param name="lrMaxGecGunSayisi">lrMaxGecGunSayisi.</param>
        /// <param name="lrSonBildirimDonemi">lrSonBildirimDonemi.</param>
        public RiskRaporuLimitRiskDokum(string lrKaynakKodu = default(string), string lrKaynakTuru = default(string), string lrKaynakAdi = default(string), string lrNakdiLimit = default(string), string lrGayriNakdiLimit = default(string), string lrToplamLimit = default(string), string lrGenelRevizeVadesi = default(string), string lrGrupLimit = default(string), string lrNakdiRisk = default(string), string lrGayriNakdiRisk = default(string), string lrToplamRisk = default(string), string lrGrupRisk = default(string), string lrGecikenHesapSayisi = default(string), string lrToplamGecikmisTutar = default(string), int lrMaxGecGunSayisi = default(int), string lrSonBildirimDonemi = default(string))
        {
            this.LrKaynakKodu = lrKaynakKodu;
            this.LrKaynakTuru = lrKaynakTuru;
            this.LrKaynakAdi = lrKaynakAdi;
            this.LrNakdiLimit = lrNakdiLimit;
            this.LrGayriNakdiLimit = lrGayriNakdiLimit;
            this.LrToplamLimit = lrToplamLimit;
            this.LrGenelRevizeVadesi = lrGenelRevizeVadesi;
            this.LrGrupLimit = lrGrupLimit;
            this.LrNakdiRisk = lrNakdiRisk;
            this.LrGayriNakdiRisk = lrGayriNakdiRisk;
            this.LrToplamRisk = lrToplamRisk;
            this.LrGrupRisk = lrGrupRisk;
            this.LrGecikenHesapSayisi = lrGecikenHesapSayisi;
            this.LrToplamGecikmisTutar = lrToplamGecikmisTutar;
            this.LrMaxGecGunSayisi = lrMaxGecGunSayisi;
            this.LrSonBildirimDonemi = lrSonBildirimDonemi;
        }

        /// <summary>
        /// Gets or Sets LrKaynakKodu
        /// </summary>
        [DataMember(Name = "lrKaynakKodu", EmitDefaultValue = true)]
        public string LrKaynakKodu { get; set; }

        /// <summary>
        /// Gets or Sets LrKaynakTuru
        /// </summary>
        [DataMember(Name = "lrKaynakTuru", EmitDefaultValue = true)]
        public string LrKaynakTuru { get; set; }

        /// <summary>
        /// Gets or Sets LrKaynakAdi
        /// </summary>
        [DataMember(Name = "lrKaynakAdi", EmitDefaultValue = true)]
        public string LrKaynakAdi { get; set; }

        /// <summary>
        /// Gets or Sets LrNakdiLimit
        /// </summary>
        [DataMember(Name = "lrNakdiLimit", EmitDefaultValue = true)]
        public string LrNakdiLimit { get; set; }

        /// <summary>
        /// Gets or Sets LrGayriNakdiLimit
        /// </summary>
        [DataMember(Name = "lrGayriNakdiLimit", EmitDefaultValue = true)]
        public string LrGayriNakdiLimit { get; set; }

        /// <summary>
        /// Gets or Sets LrToplamLimit
        /// </summary>
        [DataMember(Name = "lrToplamLimit", EmitDefaultValue = true)]
        public string LrToplamLimit { get; set; }

        /// <summary>
        /// Gets or Sets LrGenelRevizeVadesi
        /// </summary>
        [DataMember(Name = "lrGenelRevizeVadesi", EmitDefaultValue = true)]
        public string LrGenelRevizeVadesi { get; set; }

        /// <summary>
        /// Gets or Sets LrGrupLimit
        /// </summary>
        [DataMember(Name = "lrGrupLimit", EmitDefaultValue = true)]
        public string LrGrupLimit { get; set; }

        /// <summary>
        /// Gets or Sets LrNakdiRisk
        /// </summary>
        [DataMember(Name = "lrNakdiRisk", EmitDefaultValue = true)]
        public string LrNakdiRisk { get; set; }

        /// <summary>
        /// Gets or Sets LrGayriNakdiRisk
        /// </summary>
        [DataMember(Name = "lrGayriNakdiRisk", EmitDefaultValue = true)]
        public string LrGayriNakdiRisk { get; set; }

        /// <summary>
        /// Gets or Sets LrToplamRisk
        /// </summary>
        [DataMember(Name = "lrToplamRisk", EmitDefaultValue = true)]
        public string LrToplamRisk { get; set; }

        /// <summary>
        /// Gets or Sets LrGrupRisk
        /// </summary>
        [DataMember(Name = "lrGrupRisk", EmitDefaultValue = true)]
        public string LrGrupRisk { get; set; }

        /// <summary>
        /// Gets or Sets LrGecikenHesapSayisi
        /// </summary>
        [DataMember(Name = "lrGecikenHesapSayisi", EmitDefaultValue = true)]
        public string LrGecikenHesapSayisi { get; set; }

        /// <summary>
        /// Gets or Sets LrToplamGecikmisTutar
        /// </summary>
        [DataMember(Name = "lrToplamGecikmisTutar", EmitDefaultValue = true)]
        public string LrToplamGecikmisTutar { get; set; }

        /// <summary>
        /// Gets or Sets LrMaxGecGunSayisi
        /// </summary>
        [DataMember(Name = "lrMaxGecGunSayisi", EmitDefaultValue = false)]
        public int LrMaxGecGunSayisi { get; set; }

        /// <summary>
        /// Gets or Sets LrSonBildirimDonemi
        /// </summary>
        [DataMember(Name = "lrSonBildirimDonemi", EmitDefaultValue = true)]
        public string LrSonBildirimDonemi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RiskRaporuLimitRiskDokum {\n");
            sb.Append("  LrKaynakKodu: ").Append(LrKaynakKodu).Append("\n");
            sb.Append("  LrKaynakTuru: ").Append(LrKaynakTuru).Append("\n");
            sb.Append("  LrKaynakAdi: ").Append(LrKaynakAdi).Append("\n");
            sb.Append("  LrNakdiLimit: ").Append(LrNakdiLimit).Append("\n");
            sb.Append("  LrGayriNakdiLimit: ").Append(LrGayriNakdiLimit).Append("\n");
            sb.Append("  LrToplamLimit: ").Append(LrToplamLimit).Append("\n");
            sb.Append("  LrGenelRevizeVadesi: ").Append(LrGenelRevizeVadesi).Append("\n");
            sb.Append("  LrGrupLimit: ").Append(LrGrupLimit).Append("\n");
            sb.Append("  LrNakdiRisk: ").Append(LrNakdiRisk).Append("\n");
            sb.Append("  LrGayriNakdiRisk: ").Append(LrGayriNakdiRisk).Append("\n");
            sb.Append("  LrToplamRisk: ").Append(LrToplamRisk).Append("\n");
            sb.Append("  LrGrupRisk: ").Append(LrGrupRisk).Append("\n");
            sb.Append("  LrGecikenHesapSayisi: ").Append(LrGecikenHesapSayisi).Append("\n");
            sb.Append("  LrToplamGecikmisTutar: ").Append(LrToplamGecikmisTutar).Append("\n");
            sb.Append("  LrMaxGecGunSayisi: ").Append(LrMaxGecGunSayisi).Append("\n");
            sb.Append("  LrSonBildirimDonemi: ").Append(LrSonBildirimDonemi).Append("\n");
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
