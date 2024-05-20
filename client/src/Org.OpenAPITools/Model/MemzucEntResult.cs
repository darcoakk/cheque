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
    /// MemzucEntResult
    /// </summary>
    [DataContract(Name = "MemzucEntResult")]
    public partial class MemzucEntResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemzucEntResult" /> class.
        /// </summary>
        /// <param name="period">period.</param>
        /// <param name="riskkod">riskkod.</param>
        /// <param name="limit">limit.</param>
        /// <param name="toplamrisk">toplamrisk.</param>
        /// <param name="kisavade">kisavade.</param>
        /// <param name="ortavade">ortavade.</param>
        /// <param name="uzunvade">uzunvade.</param>
        /// <param name="faizrees">faizrees.</param>
        /// <param name="faiztah">faiztah.</param>
        public MemzucEntResult(string period = default(string), string riskkod = default(string), string limit = default(string), string toplamrisk = default(string), string kisavade = default(string), string ortavade = default(string), string uzunvade = default(string), string faizrees = default(string), string faiztah = default(string))
        {
            this.Period = period;
            this.Riskkod = riskkod;
            this.Limit = limit;
            this.Toplamrisk = toplamrisk;
            this.Kisavade = kisavade;
            this.Ortavade = ortavade;
            this.Uzunvade = uzunvade;
            this.Faizrees = faizrees;
            this.Faiztah = faiztah;
        }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = true)]
        public string Period { get; set; }

        /// <summary>
        /// Gets or Sets Riskkod
        /// </summary>
        [DataMember(Name = "riskkod", EmitDefaultValue = true)]
        public string Riskkod { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name = "limit", EmitDefaultValue = true)]
        public string Limit { get; set; }

        /// <summary>
        /// Gets or Sets Toplamrisk
        /// </summary>
        [DataMember(Name = "toplamrisk", EmitDefaultValue = true)]
        public string Toplamrisk { get; set; }

        /// <summary>
        /// Gets or Sets Kisavade
        /// </summary>
        [DataMember(Name = "kisavade", EmitDefaultValue = true)]
        public string Kisavade { get; set; }

        /// <summary>
        /// Gets or Sets Ortavade
        /// </summary>
        [DataMember(Name = "ortavade", EmitDefaultValue = true)]
        public string Ortavade { get; set; }

        /// <summary>
        /// Gets or Sets Uzunvade
        /// </summary>
        [DataMember(Name = "uzunvade", EmitDefaultValue = true)]
        public string Uzunvade { get; set; }

        /// <summary>
        /// Gets or Sets Faizrees
        /// </summary>
        [DataMember(Name = "faizrees", EmitDefaultValue = true)]
        public string Faizrees { get; set; }

        /// <summary>
        /// Gets or Sets Faiztah
        /// </summary>
        [DataMember(Name = "faiztah", EmitDefaultValue = true)]
        public string Faiztah { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MemzucEntResult {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Riskkod: ").Append(Riskkod).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Toplamrisk: ").Append(Toplamrisk).Append("\n");
            sb.Append("  Kisavade: ").Append(Kisavade).Append("\n");
            sb.Append("  Ortavade: ").Append(Ortavade).Append("\n");
            sb.Append("  Uzunvade: ").Append(Uzunvade).Append("\n");
            sb.Append("  Faizrees: ").Append(Faizrees).Append("\n");
            sb.Append("  Faiztah: ").Append(Faiztah).Append("\n");
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
