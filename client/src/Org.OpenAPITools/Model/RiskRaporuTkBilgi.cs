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
    /// RiskRaporuTkBilgi
    /// </summary>
    [DataContract(Name = "RiskRaporuTkBilgi")]
    public partial class RiskRaporuTkBilgi : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskRaporuTkBilgi" /> class.
        /// </summary>
        /// <param name="tkBildirimdeBulunanFinansKurulusuSayisi">tkBildirimdeBulunanFinansKurulusuSayisi.</param>
        /// <param name="tkIlkKrediKullandirimTarihi">tkIlkKrediKullandirimTarihi.</param>
        /// <param name="tkSonKrediKullandirimTarihi">tkSonKrediKullandirimTarihi.</param>
        /// <param name="tkGecikmedekiHesapSayisi">tkGecikmedekiHesapSayisi.</param>
        /// <param name="tkGecikmisBakiyeToplami">tkGecikmisBakiyeToplami.</param>
        /// <param name="tkToplamLimit">tkToplamLimit.</param>
        /// <param name="tkToplamRisk">tkToplamRisk.</param>
        /// <param name="tkToplamNakdiLimit">tkToplamNakdiLimit.</param>
        /// <param name="tkToplamNakdiRisk">tkToplamNakdiRisk.</param>
        /// <param name="tkToplamGayriNakdiLimit">tkToplamGayriNakdiLimit.</param>
        /// <param name="tkToplamGayriNakdiRisk">tkToplamGayriNakdiRisk.</param>
        /// <param name="tkTakipHesabiBildirimdeBulunanFinansKurulusuSayisi">tkTakipHesabiBildirimdeBulunanFinansKurulusuSayisi.</param>
        /// <param name="tkTakibeAlindigiTarihtekiRiskTutarlariToplami">tkTakibeAlindigiTarihtekiRiskTutarlariToplami.</param>
        /// <param name="tkGuncelKrediBakiyesiToplami">tkGuncelKrediBakiyesiToplami.</param>
        /// <param name="tkEnYakinTakipTarihi">tkEnYakinTakipTarihi.</param>
        /// <param name="tkEnEskiTakipTarihi">tkEnEskiTakipTarihi.</param>
        /// <param name="tkEnGuncelLimitTahsisTarihi">tkEnGuncelLimitTahsisTarihi.</param>
        public RiskRaporuTkBilgi(int tkBildirimdeBulunanFinansKurulusuSayisi = default(int), string tkIlkKrediKullandirimTarihi = default(string), string tkSonKrediKullandirimTarihi = default(string), int tkGecikmedekiHesapSayisi = default(int), string tkGecikmisBakiyeToplami = default(string), string tkToplamLimit = default(string), string tkToplamRisk = default(string), string tkToplamNakdiLimit = default(string), string tkToplamNakdiRisk = default(string), string tkToplamGayriNakdiLimit = default(string), string tkToplamGayriNakdiRisk = default(string), int tkTakipHesabiBildirimdeBulunanFinansKurulusuSayisi = default(int), string tkTakibeAlindigiTarihtekiRiskTutarlariToplami = default(string), string tkGuncelKrediBakiyesiToplami = default(string), string tkEnYakinTakipTarihi = default(string), string tkEnEskiTakipTarihi = default(string), string tkEnGuncelLimitTahsisTarihi = default(string))
        {
            this.TkBildirimdeBulunanFinansKurulusuSayisi = tkBildirimdeBulunanFinansKurulusuSayisi;
            this.TkIlkKrediKullandirimTarihi = tkIlkKrediKullandirimTarihi;
            this.TkSonKrediKullandirimTarihi = tkSonKrediKullandirimTarihi;
            this.TkGecikmedekiHesapSayisi = tkGecikmedekiHesapSayisi;
            this.TkGecikmisBakiyeToplami = tkGecikmisBakiyeToplami;
            this.TkToplamLimit = tkToplamLimit;
            this.TkToplamRisk = tkToplamRisk;
            this.TkToplamNakdiLimit = tkToplamNakdiLimit;
            this.TkToplamNakdiRisk = tkToplamNakdiRisk;
            this.TkToplamGayriNakdiLimit = tkToplamGayriNakdiLimit;
            this.TkToplamGayriNakdiRisk = tkToplamGayriNakdiRisk;
            this.TkTakipHesabiBildirimdeBulunanFinansKurulusuSayisi = tkTakipHesabiBildirimdeBulunanFinansKurulusuSayisi;
            this.TkTakibeAlindigiTarihtekiRiskTutarlariToplami = tkTakibeAlindigiTarihtekiRiskTutarlariToplami;
            this.TkGuncelKrediBakiyesiToplami = tkGuncelKrediBakiyesiToplami;
            this.TkEnYakinTakipTarihi = tkEnYakinTakipTarihi;
            this.TkEnEskiTakipTarihi = tkEnEskiTakipTarihi;
            this.TkEnGuncelLimitTahsisTarihi = tkEnGuncelLimitTahsisTarihi;
        }

        /// <summary>
        /// Gets or Sets TkBildirimdeBulunanFinansKurulusuSayisi
        /// </summary>
        [DataMember(Name = "tkBildirimdeBulunanFinansKurulusuSayisi", EmitDefaultValue = false)]
        public int TkBildirimdeBulunanFinansKurulusuSayisi { get; set; }

        /// <summary>
        /// Gets or Sets TkIlkKrediKullandirimTarihi
        /// </summary>
        [DataMember(Name = "tkIlkKrediKullandirimTarihi", EmitDefaultValue = true)]
        public string TkIlkKrediKullandirimTarihi { get; set; }

        /// <summary>
        /// Gets or Sets TkSonKrediKullandirimTarihi
        /// </summary>
        [DataMember(Name = "tkSonKrediKullandirimTarihi", EmitDefaultValue = true)]
        public string TkSonKrediKullandirimTarihi { get; set; }

        /// <summary>
        /// Gets or Sets TkGecikmedekiHesapSayisi
        /// </summary>
        [DataMember(Name = "tkGecikmedekiHesapSayisi", EmitDefaultValue = false)]
        public int TkGecikmedekiHesapSayisi { get; set; }

        /// <summary>
        /// Gets or Sets TkGecikmisBakiyeToplami
        /// </summary>
        [DataMember(Name = "tkGecikmisBakiyeToplami", EmitDefaultValue = true)]
        public string TkGecikmisBakiyeToplami { get; set; }

        /// <summary>
        /// Gets or Sets TkToplamLimit
        /// </summary>
        [DataMember(Name = "tkToplamLimit", EmitDefaultValue = true)]
        public string TkToplamLimit { get; set; }

        /// <summary>
        /// Gets or Sets TkToplamRisk
        /// </summary>
        [DataMember(Name = "tkToplamRisk", EmitDefaultValue = true)]
        public string TkToplamRisk { get; set; }

        /// <summary>
        /// Gets or Sets TkToplamNakdiLimit
        /// </summary>
        [DataMember(Name = "tkToplamNakdiLimit", EmitDefaultValue = true)]
        public string TkToplamNakdiLimit { get; set; }

        /// <summary>
        /// Gets or Sets TkToplamNakdiRisk
        /// </summary>
        [DataMember(Name = "tkToplamNakdiRisk", EmitDefaultValue = true)]
        public string TkToplamNakdiRisk { get; set; }

        /// <summary>
        /// Gets or Sets TkToplamGayriNakdiLimit
        /// </summary>
        [DataMember(Name = "tkToplamGayriNakdiLimit", EmitDefaultValue = true)]
        public string TkToplamGayriNakdiLimit { get; set; }

        /// <summary>
        /// Gets or Sets TkToplamGayriNakdiRisk
        /// </summary>
        [DataMember(Name = "tkToplamGayriNakdiRisk", EmitDefaultValue = true)]
        public string TkToplamGayriNakdiRisk { get; set; }

        /// <summary>
        /// Gets or Sets TkTakipHesabiBildirimdeBulunanFinansKurulusuSayisi
        /// </summary>
        [DataMember(Name = "tkTakipHesabiBildirimdeBulunanFinansKurulusuSayisi", EmitDefaultValue = false)]
        public int TkTakipHesabiBildirimdeBulunanFinansKurulusuSayisi { get; set; }

        /// <summary>
        /// Gets or Sets TkTakibeAlindigiTarihtekiRiskTutarlariToplami
        /// </summary>
        [DataMember(Name = "tkTakibeAlindigiTarihtekiRiskTutarlariToplami", EmitDefaultValue = true)]
        public string TkTakibeAlindigiTarihtekiRiskTutarlariToplami { get; set; }

        /// <summary>
        /// Gets or Sets TkGuncelKrediBakiyesiToplami
        /// </summary>
        [DataMember(Name = "tkGuncelKrediBakiyesiToplami", EmitDefaultValue = true)]
        public string TkGuncelKrediBakiyesiToplami { get; set; }

        /// <summary>
        /// Gets or Sets TkEnYakinTakipTarihi
        /// </summary>
        [DataMember(Name = "tkEnYakinTakipTarihi", EmitDefaultValue = true)]
        public string TkEnYakinTakipTarihi { get; set; }

        /// <summary>
        /// Gets or Sets TkEnEskiTakipTarihi
        /// </summary>
        [DataMember(Name = "tkEnEskiTakipTarihi", EmitDefaultValue = true)]
        public string TkEnEskiTakipTarihi { get; set; }

        /// <summary>
        /// Gets or Sets TkEnGuncelLimitTahsisTarihi
        /// </summary>
        [DataMember(Name = "tkEnGuncelLimitTahsisTarihi", EmitDefaultValue = true)]
        public string TkEnGuncelLimitTahsisTarihi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RiskRaporuTkBilgi {\n");
            sb.Append("  TkBildirimdeBulunanFinansKurulusuSayisi: ").Append(TkBildirimdeBulunanFinansKurulusuSayisi).Append("\n");
            sb.Append("  TkIlkKrediKullandirimTarihi: ").Append(TkIlkKrediKullandirimTarihi).Append("\n");
            sb.Append("  TkSonKrediKullandirimTarihi: ").Append(TkSonKrediKullandirimTarihi).Append("\n");
            sb.Append("  TkGecikmedekiHesapSayisi: ").Append(TkGecikmedekiHesapSayisi).Append("\n");
            sb.Append("  TkGecikmisBakiyeToplami: ").Append(TkGecikmisBakiyeToplami).Append("\n");
            sb.Append("  TkToplamLimit: ").Append(TkToplamLimit).Append("\n");
            sb.Append("  TkToplamRisk: ").Append(TkToplamRisk).Append("\n");
            sb.Append("  TkToplamNakdiLimit: ").Append(TkToplamNakdiLimit).Append("\n");
            sb.Append("  TkToplamNakdiRisk: ").Append(TkToplamNakdiRisk).Append("\n");
            sb.Append("  TkToplamGayriNakdiLimit: ").Append(TkToplamGayriNakdiLimit).Append("\n");
            sb.Append("  TkToplamGayriNakdiRisk: ").Append(TkToplamGayriNakdiRisk).Append("\n");
            sb.Append("  TkTakipHesabiBildirimdeBulunanFinansKurulusuSayisi: ").Append(TkTakipHesabiBildirimdeBulunanFinansKurulusuSayisi).Append("\n");
            sb.Append("  TkTakibeAlindigiTarihtekiRiskTutarlariToplami: ").Append(TkTakibeAlindigiTarihtekiRiskTutarlariToplami).Append("\n");
            sb.Append("  TkGuncelKrediBakiyesiToplami: ").Append(TkGuncelKrediBakiyesiToplami).Append("\n");
            sb.Append("  TkEnYakinTakipTarihi: ").Append(TkEnYakinTakipTarihi).Append("\n");
            sb.Append("  TkEnEskiTakipTarihi: ").Append(TkEnEskiTakipTarihi).Append("\n");
            sb.Append("  TkEnGuncelLimitTahsisTarihi: ").Append(TkEnGuncelLimitTahsisTarihi).Append("\n");
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