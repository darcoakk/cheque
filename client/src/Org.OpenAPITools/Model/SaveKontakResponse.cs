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
    /// SaveKontakResponse
    /// </summary>
    [DataContract(Name = "SaveKontakResponse")]
    public partial class SaveKontakResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveKontakResponse" /> class.
        /// </summary>
        /// <param name="errors">errors.</param>
        /// <param name="isKontak">isKontak.</param>
        /// <param name="customerNumber">customerNumber.</param>
        public SaveKontakResponse(IslemResponse errors = default(IslemResponse), string isKontak = default(string), string customerNumber = default(string))
        {
            this.Errors = errors;
            this.IsKontak = isKontak;
            this.CustomerNumber = customerNumber;
        }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public IslemResponse Errors { get; set; }

        /// <summary>
        /// Gets or Sets IsKontak
        /// </summary>
        [DataMember(Name = "IsKontak", EmitDefaultValue = true)]
        public string IsKontak { get; set; }

        /// <summary>
        /// Gets or Sets CustomerNumber
        /// </summary>
        [DataMember(Name = "CustomerNumber", EmitDefaultValue = true)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SaveKontakResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  IsKontak: ").Append(IsKontak).Append("\n");
            sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
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
