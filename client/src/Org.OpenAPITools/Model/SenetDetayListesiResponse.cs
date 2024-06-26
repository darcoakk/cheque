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
    /// SenetDetayListesiResponse
    /// </summary>
    [DataContract(Name = "SenetDetayListesiResponse")]
    public partial class SenetDetayListesiResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SenetDetayListesiResponse" /> class.
        /// </summary>
        /// <param name="islemRefNo">islemRefNo.</param>
        /// <param name="islemSonucu">islemSonucu.</param>
        /// <param name="maksimumSayfaSayisi">maksimumSayfaSayisi.</param>
        /// <param name="toplamKayitSayisi">toplamKayitSayisi.</param>
        /// <param name="birSayfadakiMaksimumKayitSayisi">birSayfadakiMaksimumKayitSayisi.</param>
        /// <param name="kimlik">kimlik.</param>
        /// <param name="data">data.</param>
        /// <param name="hataKodu">hataKodu.</param>
        /// <param name="hataMesaji">hataMesaji.</param>
        /// <param name="errors">errors.</param>
        /// <param name="automaticallyResult">automaticallyResult.</param>
        public SenetDetayListesiResponse(string islemRefNo = default(string), string islemSonucu = default(string), string maksimumSayfaSayisi = default(string), string toplamKayitSayisi = default(string), string birSayfadakiMaksimumKayitSayisi = default(string), SenetGeriBildirimDetayKimlik kimlik = default(SenetGeriBildirimDetayKimlik), List<SenetGeriBildirimDetayList> data = default(List<SenetGeriBildirimDetayList>), string hataKodu = default(string), string hataMesaji = default(string), IslemResponse errors = default(IslemResponse), string automaticallyResult = default(string))
        {
            this.IslemRefNo = islemRefNo;
            this.IslemSonucu = islemSonucu;
            this.MaksimumSayfaSayisi = maksimumSayfaSayisi;
            this.ToplamKayitSayisi = toplamKayitSayisi;
            this.BirSayfadakiMaksimumKayitSayisi = birSayfadakiMaksimumKayitSayisi;
            this.Kimlik = kimlik;
            this.Data = data;
            this.HataKodu = hataKodu;
            this.HataMesaji = hataMesaji;
            this.Errors = errors;
            this.AutomaticallyResult = automaticallyResult;
        }

        /// <summary>
        /// Gets or Sets IslemRefNo
        /// </summary>
        [DataMember(Name = "IslemRefNo", EmitDefaultValue = true)]
        public string IslemRefNo { get; set; }

        /// <summary>
        /// Gets or Sets IslemSonucu
        /// </summary>
        [DataMember(Name = "IslemSonucu", EmitDefaultValue = true)]
        public string IslemSonucu { get; set; }

        /// <summary>
        /// Gets or Sets MaksimumSayfaSayisi
        /// </summary>
        [DataMember(Name = "MaksimumSayfaSayisi", EmitDefaultValue = true)]
        public string MaksimumSayfaSayisi { get; set; }

        /// <summary>
        /// Gets or Sets ToplamKayitSayisi
        /// </summary>
        [DataMember(Name = "ToplamKayitSayisi", EmitDefaultValue = true)]
        public string ToplamKayitSayisi { get; set; }

        /// <summary>
        /// Gets or Sets BirSayfadakiMaksimumKayitSayisi
        /// </summary>
        [DataMember(Name = "BirSayfadakiMaksimumKayitSayisi", EmitDefaultValue = true)]
        public string BirSayfadakiMaksimumKayitSayisi { get; set; }

        /// <summary>
        /// Gets or Sets Kimlik
        /// </summary>
        [DataMember(Name = "Kimlik", EmitDefaultValue = false)]
        public SenetGeriBildirimDetayKimlik Kimlik { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "Data", EmitDefaultValue = true)]
        public List<SenetGeriBildirimDetayList> Data { get; set; }

        /// <summary>
        /// Gets or Sets HataKodu
        /// </summary>
        [DataMember(Name = "HataKodu", EmitDefaultValue = true)]
        public string HataKodu { get; set; }

        /// <summary>
        /// Gets or Sets HataMesaji
        /// </summary>
        [DataMember(Name = "HataMesaji", EmitDefaultValue = true)]
        public string HataMesaji { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "Errors", EmitDefaultValue = false)]
        public IslemResponse Errors { get; set; }

        /// <summary>
        /// Gets or Sets AutomaticallyResult
        /// </summary>
        [DataMember(Name = "AutomaticallyResult", EmitDefaultValue = true)]
        public string AutomaticallyResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SenetDetayListesiResponse {\n");
            sb.Append("  IslemRefNo: ").Append(IslemRefNo).Append("\n");
            sb.Append("  IslemSonucu: ").Append(IslemSonucu).Append("\n");
            sb.Append("  MaksimumSayfaSayisi: ").Append(MaksimumSayfaSayisi).Append("\n");
            sb.Append("  ToplamKayitSayisi: ").Append(ToplamKayitSayisi).Append("\n");
            sb.Append("  BirSayfadakiMaksimumKayitSayisi: ").Append(BirSayfadakiMaksimumKayitSayisi).Append("\n");
            sb.Append("  Kimlik: ").Append(Kimlik).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  HataKodu: ").Append(HataKodu).Append("\n");
            sb.Append("  HataMesaji: ").Append(HataMesaji).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  AutomaticallyResult: ").Append(AutomaticallyResult).Append("\n");
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
