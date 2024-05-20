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
    /// KKBCommercialRegistryDetailQueryResponse
    /// </summary>
    [DataContract(Name = "KKBCommercialRegistryDetailQueryResponse")]
    public partial class KKBCommercialRegistryDetailQueryResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KKBCommercialRegistryDetailQueryResponse" /> class.
        /// </summary>
        /// <param name="hataKodu">hataKodu.</param>
        /// <param name="hataAciklama">hataAciklama.</param>
        /// <param name="ilanBean">ilanBean.</param>
        public KKBCommercialRegistryDetailQueryResponse(string hataKodu = default(string), string hataAciklama = default(string), List<KKBIlanBeanResponse> ilanBean = default(List<KKBIlanBeanResponse>))
        {
            this.HataKodu = hataKodu;
            this.HataAciklama = hataAciklama;
            this.IlanBean = ilanBean;
        }

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
        /// Gets or Sets IlanBean
        /// </summary>
        [DataMember(Name = "ilanBean", EmitDefaultValue = true)]
        public List<KKBIlanBeanResponse> IlanBean { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KKBCommercialRegistryDetailQueryResponse {\n");
            sb.Append("  HataKodu: ").Append(HataKodu).Append("\n");
            sb.Append("  HataAciklama: ").Append(HataAciklama).Append("\n");
            sb.Append("  IlanBean: ").Append(IlanBean).Append("\n");
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