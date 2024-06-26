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
    /// EWTotalQueryResponse
    /// </summary>
    [DataContract(Name = "EWTotalQueryResponse")]
    public partial class EWTotalQueryResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EWTotalQueryResponse" /> class.
        /// </summary>
        /// <param name="branchCode">branchCode.</param>
        /// <param name="customerNumber">customerNumber.</param>
        /// <param name="customerName">customerName.</param>
        /// <param name="businessLine">businessLine.</param>
        /// <param name="creditAllocationDepartmentCode">creditAllocationDepartmentCode.</param>
        /// <param name="customerRating">customerRating.</param>
        /// <param name="queryDate">queryDate.</param>
        /// <param name="warningCode">warningCode.</param>
        /// <param name="warningColor">warningColor.</param>
        /// <param name="warningStatus">warningStatus.</param>
        /// <param name="signalType">signalType.</param>
        public EWTotalQueryResponse(int branchCode = default(int), string customerNumber = default(string), string customerName = default(string), string businessLine = default(string), string creditAllocationDepartmentCode = default(string), string customerRating = default(string), DateTime queryDate = default(DateTime), string warningCode = default(string), string warningColor = default(string), string warningStatus = default(string), string signalType = default(string))
        {
            this.BranchCode = branchCode;
            this.CustomerNumber = customerNumber;
            this.CustomerName = customerName;
            this.BusinessLine = businessLine;
            this.CreditAllocationDepartmentCode = creditAllocationDepartmentCode;
            this.CustomerRating = customerRating;
            this.QueryDate = queryDate;
            this.WarningCode = warningCode;
            this.WarningColor = warningColor;
            this.WarningStatus = warningStatus;
            this.SignalType = signalType;
        }

        /// <summary>
        /// Gets or Sets BranchCode
        /// </summary>
        [DataMember(Name = "BranchCode", EmitDefaultValue = false)]
        public int BranchCode { get; set; }

        /// <summary>
        /// Gets or Sets CustomerNumber
        /// </summary>
        [DataMember(Name = "CustomerNumber", EmitDefaultValue = true)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name = "CustomerName", EmitDefaultValue = true)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets BusinessLine
        /// </summary>
        [DataMember(Name = "BusinessLine", EmitDefaultValue = true)]
        public string BusinessLine { get; set; }

        /// <summary>
        /// Gets or Sets CreditAllocationDepartmentCode
        /// </summary>
        [DataMember(Name = "CreditAllocationDepartmentCode", EmitDefaultValue = true)]
        public string CreditAllocationDepartmentCode { get; set; }

        /// <summary>
        /// Gets or Sets CustomerRating
        /// </summary>
        [DataMember(Name = "CustomerRating", EmitDefaultValue = true)]
        public string CustomerRating { get; set; }

        /// <summary>
        /// Gets or Sets QueryDate
        /// </summary>
        [DataMember(Name = "QueryDate", EmitDefaultValue = false)]
        public DateTime QueryDate { get; set; }

        /// <summary>
        /// Gets or Sets WarningCode
        /// </summary>
        [DataMember(Name = "WarningCode", EmitDefaultValue = true)]
        public string WarningCode { get; set; }

        /// <summary>
        /// Gets or Sets WarningColor
        /// </summary>
        [DataMember(Name = "WarningColor", EmitDefaultValue = true)]
        public string WarningColor { get; set; }

        /// <summary>
        /// Gets or Sets WarningStatus
        /// </summary>
        [DataMember(Name = "WarningStatus", EmitDefaultValue = true)]
        public string WarningStatus { get; set; }

        /// <summary>
        /// Gets or Sets SignalType
        /// </summary>
        [DataMember(Name = "SignalType", EmitDefaultValue = true)]
        public string SignalType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EWTotalQueryResponse {\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  BusinessLine: ").Append(BusinessLine).Append("\n");
            sb.Append("  CreditAllocationDepartmentCode: ").Append(CreditAllocationDepartmentCode).Append("\n");
            sb.Append("  CustomerRating: ").Append(CustomerRating).Append("\n");
            sb.Append("  QueryDate: ").Append(QueryDate).Append("\n");
            sb.Append("  WarningCode: ").Append(WarningCode).Append("\n");
            sb.Append("  WarningColor: ").Append(WarningColor).Append("\n");
            sb.Append("  WarningStatus: ").Append(WarningStatus).Append("\n");
            sb.Append("  SignalType: ").Append(SignalType).Append("\n");
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
