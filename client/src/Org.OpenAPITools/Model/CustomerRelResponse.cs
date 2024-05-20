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
    /// CustomerRelResponse
    /// </summary>
    [DataContract(Name = "CustomerRelResponse")]
    public partial class CustomerRelResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRelResponse" /> class.
        /// </summary>
        /// <param name="errors">errors.</param>
        /// <param name="data">data.</param>
        /// <param name="cusRelAutomaticallyResult">cusRelAutomaticallyResult.</param>
        /// <param name="automaticallyResult">automaticallyResult.</param>
        public CustomerRelResponse(IslemResponse errors = default(IslemResponse), CustomerRelData data = default(CustomerRelData), List<CusRelAutoResult> cusRelAutomaticallyResult = default(List<CusRelAutoResult>), string automaticallyResult = default(string))
        {
            this.Errors = errors;
            this.Data = data;
            this.CusRelAutomaticallyResult = cusRelAutomaticallyResult;
            this.AutomaticallyResult = automaticallyResult;
        }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public IslemResponse Errors { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public CustomerRelData Data { get; set; }

        /// <summary>
        /// Gets or Sets CusRelAutomaticallyResult
        /// </summary>
        [DataMember(Name = "CusRelAutomaticallyResult", EmitDefaultValue = true)]
        public List<CusRelAutoResult> CusRelAutomaticallyResult { get; set; }

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
            sb.Append("class CustomerRelResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  CusRelAutomaticallyResult: ").Append(CusRelAutomaticallyResult).Append("\n");
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
