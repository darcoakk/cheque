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
    /// KKBCommercialRegistrySummaryQueryResponse
    /// </summary>
    [DataContract(Name = "KKBCommercialRegistrySummaryQueryResponse")]
    public partial class KKBCommercialRegistrySummaryQueryResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KKBCommercialRegistrySummaryQueryResponse" /> class.
        /// </summary>
        /// <param name="sorguRefNo">sorguRefNo.</param>
        /// <param name="hataKodu">hataKodu.</param>
        /// <param name="hataAciklama">hataAciklama.</param>
        /// <param name="ilanlar">ilanlar.</param>
        /// <param name="tescilKonuList">tescilKonuList.</param>
        public KKBCommercialRegistrySummaryQueryResponse(string sorguRefNo = default(string), string hataKodu = default(string), string hataAciklama = default(string), List<KKBIlanOzetBeanResponse> ilanlar = default(List<KKBIlanOzetBeanResponse>), List<KKBTescilKonuBeanResponse> tescilKonuList = default(List<KKBTescilKonuBeanResponse>))
        {
            this.SorguRefNo = sorguRefNo;
            this.HataKodu = hataKodu;
            this.HataAciklama = hataAciklama;
            this.Ilanlar = ilanlar;
            this.TescilKonuList = tescilKonuList;
        }

        /// <summary>
        /// Gets or Sets SorguRefNo
        /// </summary>
        [DataMember(Name = "sorguRefNo", EmitDefaultValue = true)]
        public string SorguRefNo { get; set; }

        /// <summary>
        /// Gets or Sets HataKodu
        /// </summary>
        [DataMember(Name = "hataKodu", EmitDefaultValue = true)]
        public string HataKodu { get; set; }

        /// <summary>
        /// Gets or Sets HataAciklama
        /// </summary>
        [DataMember(Name = "hataAciklama", EmitDefaultValue = true)]
        public string HataAciklama { get; set; }

        /// <summary>
        /// Gets or Sets Ilanlar
        /// </summary>
        [DataMember(Name = "ilanlar", EmitDefaultValue = true)]
        public List<KKBIlanOzetBeanResponse> Ilanlar { get; set; }

        /// <summary>
        /// Gets or Sets TescilKonuList
        /// </summary>
        [DataMember(Name = "tescilKonuList", EmitDefaultValue = true)]
        public List<KKBTescilKonuBeanResponse> TescilKonuList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KKBCommercialRegistrySummaryQueryResponse {\n");
            sb.Append("  SorguRefNo: ").Append(SorguRefNo).Append("\n");
            sb.Append("  HataKodu: ").Append(HataKodu).Append("\n");
            sb.Append("  HataAciklama: ").Append(HataAciklama).Append("\n");
            sb.Append("  Ilanlar: ").Append(Ilanlar).Append("\n");
            sb.Append("  TescilKonuList: ").Append(TescilKonuList).Append("\n");
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
