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
    /// CekPerformansDetay
    /// </summary>
    [DataContract(Name = "CekPerformansDetay")]
    public partial class CekPerformansDetay : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CekPerformansDetay" /> class.
        /// </summary>
        /// <param name="durum">durum.</param>
        /// <param name="tutar">tutar.</param>
        /// <param name="oran">oran.</param>
        public CekPerformansDetay(string durum = default(string), string tutar = default(string), string oran = default(string))
        {
            this.Durum = durum;
            this.Tutar = tutar;
            this.Oran = oran;
        }

        /// <summary>
        /// Gets or Sets Durum
        /// </summary>
        [DataMember(Name = "Durum", EmitDefaultValue = true)]
        public string Durum { get; set; }

        /// <summary>
        /// Gets or Sets Tutar
        /// </summary>
        [DataMember(Name = "Tutar", EmitDefaultValue = true)]
        public string Tutar { get; set; }

        /// <summary>
        /// Gets or Sets Oran
        /// </summary>
        [DataMember(Name = "Oran", EmitDefaultValue = true)]
        public string Oran { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CekPerformansDetay {\n");
            sb.Append("  Durum: ").Append(Durum).Append("\n");
            sb.Append("  Tutar: ").Append(Tutar).Append("\n");
            sb.Append("  Oran: ").Append(Oran).Append("\n");
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