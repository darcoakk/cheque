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
    /// MersisDetailResultResponse
    /// </summary>
    [DataContract(Name = "MersisDetailResultResponse")]
    public partial class MersisDetailResultResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MersisDetailResultResponse" /> class.
        /// </summary>
        /// <param name="islemSonucu">islemSonucu.</param>
        /// <param name="hataAciklama">hataAciklama.</param>
        /// <param name="durumKodu">durumKodu.</param>
        /// <param name="durumKoduAciklamasi">durumKoduAciklamasi.</param>
        /// <param name="mersisNo">mersisNo.</param>
        /// <param name="sermayeBilgileri">sermayeBilgileri.</param>
        /// <param name="ortakBilgileri">ortakBilgileri.</param>
        /// <param name="temsilciBilgileri">temsilciBilgileri.</param>
        /// <param name="iletisimBilgileri">iletisimBilgileri.</param>
        /// <param name="adresBilgileri">adresBilgileri.</param>
        /// <param name="nACEBilgileri">nACEBilgileri.</param>
        /// <param name="uyeBilgileri">uyeBilgileri.</param>
        public MersisDetailResultResponse(string islemSonucu = default(string), string hataAciklama = default(string), string durumKodu = default(string), string durumKoduAciklamasi = default(string), string mersisNo = default(string), SermayeBilgileri sermayeBilgileri = default(SermayeBilgileri), OrtakBilgileri ortakBilgileri = default(OrtakBilgileri), TemsilciBilgileri temsilciBilgileri = default(TemsilciBilgileri), IletisimBilgileri iletisimBilgileri = default(IletisimBilgileri), AdresBilgileri adresBilgileri = default(AdresBilgileri), NaceBilgileri nACEBilgileri = default(NaceBilgileri), UyeBilgileri uyeBilgileri = default(UyeBilgileri))
        {
            this.IslemSonucu = islemSonucu;
            this.HataAciklama = hataAciklama;
            this.DurumKodu = durumKodu;
            this.DurumKoduAciklamasi = durumKoduAciklamasi;
            this.MersisNo = mersisNo;
            this.SermayeBilgileri = sermayeBilgileri;
            this.OrtakBilgileri = ortakBilgileri;
            this.TemsilciBilgileri = temsilciBilgileri;
            this.IletisimBilgileri = iletisimBilgileri;
            this.AdresBilgileri = adresBilgileri;
            this.NACEBilgileri = nACEBilgileri;
            this.UyeBilgileri = uyeBilgileri;
        }

        /// <summary>
        /// Gets or Sets IslemSonucu
        /// </summary>
        [DataMember(Name = "islemSonucu", EmitDefaultValue = true)]
        public string IslemSonucu { get; set; }

        /// <summary>
        /// Gets or Sets HataAciklama
        /// </summary>
        [DataMember(Name = "hataAciklama", EmitDefaultValue = true)]
        public string HataAciklama { get; set; }

        /// <summary>
        /// Gets or Sets DurumKodu
        /// </summary>
        [DataMember(Name = "durumKodu", EmitDefaultValue = true)]
        public string DurumKodu { get; set; }

        /// <summary>
        /// Gets or Sets DurumKoduAciklamasi
        /// </summary>
        [DataMember(Name = "durumKoduAciklamasi", EmitDefaultValue = true)]
        public string DurumKoduAciklamasi { get; set; }

        /// <summary>
        /// Gets or Sets MersisNo
        /// </summary>
        [DataMember(Name = "mersisNo", EmitDefaultValue = true)]
        public string MersisNo { get; set; }

        /// <summary>
        /// Gets or Sets SermayeBilgileri
        /// </summary>
        [DataMember(Name = "sermayeBilgileri", EmitDefaultValue = false)]
        public SermayeBilgileri SermayeBilgileri { get; set; }

        /// <summary>
        /// Gets or Sets OrtakBilgileri
        /// </summary>
        [DataMember(Name = "ortakBilgileri", EmitDefaultValue = false)]
        public OrtakBilgileri OrtakBilgileri { get; set; }

        /// <summary>
        /// Gets or Sets TemsilciBilgileri
        /// </summary>
        [DataMember(Name = "temsilciBilgileri", EmitDefaultValue = false)]
        public TemsilciBilgileri TemsilciBilgileri { get; set; }

        /// <summary>
        /// Gets or Sets IletisimBilgileri
        /// </summary>
        [DataMember(Name = "iletisimBilgileri", EmitDefaultValue = false)]
        public IletisimBilgileri IletisimBilgileri { get; set; }

        /// <summary>
        /// Gets or Sets AdresBilgileri
        /// </summary>
        [DataMember(Name = "adresBilgileri", EmitDefaultValue = false)]
        public AdresBilgileri AdresBilgileri { get; set; }

        /// <summary>
        /// Gets or Sets NACEBilgileri
        /// </summary>
        [DataMember(Name = "NACEBilgileri", EmitDefaultValue = false)]
        public NaceBilgileri NACEBilgileri { get; set; }

        /// <summary>
        /// Gets or Sets UyeBilgileri
        /// </summary>
        [DataMember(Name = "uyeBilgileri", EmitDefaultValue = false)]
        public UyeBilgileri UyeBilgileri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MersisDetailResultResponse {\n");
            sb.Append("  IslemSonucu: ").Append(IslemSonucu).Append("\n");
            sb.Append("  HataAciklama: ").Append(HataAciklama).Append("\n");
            sb.Append("  DurumKodu: ").Append(DurumKodu).Append("\n");
            sb.Append("  DurumKoduAciklamasi: ").Append(DurumKoduAciklamasi).Append("\n");
            sb.Append("  MersisNo: ").Append(MersisNo).Append("\n");
            sb.Append("  SermayeBilgileri: ").Append(SermayeBilgileri).Append("\n");
            sb.Append("  OrtakBilgileri: ").Append(OrtakBilgileri).Append("\n");
            sb.Append("  TemsilciBilgileri: ").Append(TemsilciBilgileri).Append("\n");
            sb.Append("  IletisimBilgileri: ").Append(IletisimBilgileri).Append("\n");
            sb.Append("  AdresBilgileri: ").Append(AdresBilgileri).Append("\n");
            sb.Append("  NACEBilgileri: ").Append(NACEBilgileri).Append("\n");
            sb.Append("  UyeBilgileri: ").Append(UyeBilgileri).Append("\n");
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
