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
    /// ForaRecordInfo
    /// </summary>
    [DataContract(Name = "ForaRecordInfo")]
    public partial class ForaRecordInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForaRecordInfo" /> class.
        /// </summary>
        /// <param name="channelCode">channelCode.</param>
        /// <param name="userCode">userCode.</param>
        /// <param name="tranCode">tranCode.</param>
        /// <param name="updateDate">updateDate.</param>
        /// <param name="isActive">isActive.</param>
        public ForaRecordInfo(string channelCode = default(string), string userCode = default(string), string tranCode = default(string), string updateDate = default(string), bool isActive = default(bool))
        {
            this.ChannelCode = channelCode;
            this.UserCode = userCode;
            this.TranCode = tranCode;
            this.UpdateDate = updateDate;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Gets or Sets ChannelCode
        /// </summary>
        [DataMember(Name = "ChannelCode", EmitDefaultValue = true)]
        public string ChannelCode { get; set; }

        /// <summary>
        /// Gets or Sets UserCode
        /// </summary>
        [DataMember(Name = "UserCode", EmitDefaultValue = true)]
        public string UserCode { get; set; }

        /// <summary>
        /// Gets or Sets TranCode
        /// </summary>
        [DataMember(Name = "TranCode", EmitDefaultValue = true)]
        public string TranCode { get; set; }

        /// <summary>
        /// Gets or Sets UpdateDate
        /// </summary>
        [DataMember(Name = "UpdateDate", EmitDefaultValue = true)]
        public string UpdateDate { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "IsActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForaRecordInfo {\n");
            sb.Append("  ChannelCode: ").Append(ChannelCode).Append("\n");
            sb.Append("  UserCode: ").Append(UserCode).Append("\n");
            sb.Append("  TranCode: ").Append(TranCode).Append("\n");
            sb.Append("  UpdateDate: ").Append(UpdateDate).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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