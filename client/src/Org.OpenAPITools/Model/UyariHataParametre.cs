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
    /// UyariHataParametre
    /// </summary>
    [DataContract(Name = "UyariHataParametre")]
    public partial class UyariHataParametre : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UyariHataParametre" /> class.
        /// </summary>
        /// <param name="hataKoduField">hataKoduField.</param>
        /// <param name="hataKoduciklamaField">hataKoduciklamaField.</param>
        public UyariHataParametre(string hataKoduField = default(string), string hataKoduciklamaField = default(string))
        {
            this.HataKoduField = hataKoduField;
            this.HataKoduciklamaField = hataKoduciklamaField;
        }

        /// <summary>
        /// Gets or Sets HataKoduField
        /// </summary>
        [DataMember(Name = "HataKoduField", EmitDefaultValue = true)]
        public string HataKoduField { get; set; }

        /// <summary>
        /// Gets or Sets HataKoduciklamaField
        /// </summary>
        [DataMember(Name = "HataKoduciklamaField", EmitDefaultValue = true)]
        public string HataKoduciklamaField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UyariHataParametre {\n");
            sb.Append("  HataKoduField: ").Append(HataKoduField).Append("\n");
            sb.Append("  HataKoduciklamaField: ").Append(HataKoduciklamaField).Append("\n");
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