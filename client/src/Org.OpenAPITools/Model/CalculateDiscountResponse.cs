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
    /// CalculateDiscountResponse
    /// </summary>
    [DataContract(Name = "CalculateDiscountResponse")]
    public partial class CalculateDiscountResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateDiscountResponse" /> class.
        /// </summary>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="discountInfo">discountInfo.</param>
        /// <param name="errorList">errorList.</param>
        public CalculateDiscountResponse(string statusCode = default(string), DiscountInfo discountInfo = default(DiscountInfo), List<SupplierError> errorList = default(List<SupplierError>))
        {
            this.StatusCode = statusCode;
            this.DiscountInfo = discountInfo;
            this.ErrorList = errorList;
        }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "statusCode", EmitDefaultValue = true)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets DiscountInfo
        /// </summary>
        [DataMember(Name = "discountInfo", EmitDefaultValue = false)]
        public DiscountInfo DiscountInfo { get; set; }

        /// <summary>
        /// Gets or Sets ErrorList
        /// </summary>
        [DataMember(Name = "errorList", EmitDefaultValue = true)]
        public List<SupplierError> ErrorList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CalculateDiscountResponse {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  DiscountInfo: ").Append(DiscountInfo).Append("\n");
            sb.Append("  ErrorList: ").Append(ErrorList).Append("\n");
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
