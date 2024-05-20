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
    /// FaaliyetBilgisi
    /// </summary>
    [DataContract(Name = "faaliyetBilgisi")]
    public partial class FaaliyetBilgisi : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaaliyetBilgisi" /> class.
        /// </summary>
        /// <param name="faaliyetAdi">faaliyetAdi.</param>
        /// <param name="faaliyetKodu">faaliyetKodu.</param>
        public FaaliyetBilgisi(string faaliyetAdi = default(string), string faaliyetKodu = default(string))
        {
            this.FaaliyetAdi = faaliyetAdi;
            this.FaaliyetKodu = faaliyetKodu;
        }

        /// <summary>
        /// Gets or Sets FaaliyetAdi
        /// </summary>
        [DataMember(Name = "faaliyetAdi", EmitDefaultValue = true)]
        public string FaaliyetAdi { get; set; }

        /// <summary>
        /// Gets or Sets FaaliyetKodu
        /// </summary>
        [DataMember(Name = "faaliyetKodu", EmitDefaultValue = true)]
        public string FaaliyetKodu { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FaaliyetBilgisi {\n");
            sb.Append("  FaaliyetAdi: ").Append(FaaliyetAdi).Append("\n");
            sb.Append("  FaaliyetKodu: ").Append(FaaliyetKodu).Append("\n");
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