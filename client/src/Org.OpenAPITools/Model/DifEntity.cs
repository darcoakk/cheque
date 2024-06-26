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
    /// DifEntity
    /// </summary>
    [DataContract(Name = "DifEntity")]
    public partial class DifEntity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DifEntity" /> class.
        /// </summary>
        /// <param name="recordInfo">recordInfo.</param>
        /// <param name="temAltTipi">temAltTipi.</param>
        /// <param name="flow">flow.</param>
        /// <param name="diffKind">diffKind.</param>
        /// <param name="varRef">varRef.</param>
        /// <param name="accountBranchCode">accountBranchCode.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="accountSuffix">accountSuffix.</param>
        /// <param name="productCode">productCode.</param>
        /// <param name="projectCode">projectCode.</param>
        /// <param name="campaignCode">campaignCode.</param>
        /// <param name="rating">rating.</param>
        /// <param name="module">module.</param>
        /// <param name="diffType">diffType.</param>
        /// <param name="status">status.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="amount">amount.</param>
        /// <param name="dayNumber">dayNumber.</param>
        /// <param name="beginningDate">beginningDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="endDate2">endDate2.</param>
        /// <param name="removeDate">removeDate.</param>
        /// <param name="branchEndDate">branchEndDate.</param>
        /// <param name="otherBranchCode">otherBranchCode.</param>
        /// <param name="sBExplanation">sBExplanation.</param>
        /// <param name="gMExplanation">gMExplanation.</param>
        /// <param name="modulRef">modulRef.</param>
        /// <param name="customerName">customerName.</param>
        /// <param name="diffTypeExp">diffTypeExp.</param>
        /// <param name="diffKindExp">diffKindExp.</param>
        /// <param name="statusExp">statusExp.</param>
        /// <param name="dayCount">dayCount.</param>
        /// <param name="authorityTitleExp">authorityTitleExp.</param>
        /// <param name="operationType">operationType.</param>
        /// <param name="operationKind">operationKind.</param>
        /// <param name="difDetails">difDetails.</param>
        /// <param name="recordStatus">recordStatus.</param>
        /// <param name="workflowActionNumber">workflowActionNumber.</param>
        /// <param name="externalChannelCode">externalChannelCode.</param>
        public DifEntity(ForaRecordInfo recordInfo = default(ForaRecordInfo), string temAltTipi = default(string), string flow = default(string), string diffKind = default(string), int varRef = default(int), int accountBranchCode = default(int), int accountNumber = default(int), int accountSuffix = default(int), string productCode = default(string), string projectCode = default(string), string campaignCode = default(string), string rating = default(string), string module = default(string), string diffType = default(string), string status = default(string), string currencyCode = default(string), double amount = default(double), int dayNumber = default(int), string beginningDate = default(string), string endDate = default(string), string endDate2 = default(string), string removeDate = default(string), string branchEndDate = default(string), int otherBranchCode = default(int), string sBExplanation = default(string), string gMExplanation = default(string), string modulRef = default(string), string customerName = default(string), string diffTypeExp = default(string), string diffKindExp = default(string), string statusExp = default(string), int dayCount = default(int), string authorityTitleExp = default(string), string operationType = default(string), string operationKind = default(string), List<DifDetailEntity> difDetails = default(List<DifDetailEntity>), string recordStatus = default(string), string workflowActionNumber = default(string), string externalChannelCode = default(string))
        {
            this.RecordInfo = recordInfo;
            this.TemAltTipi = temAltTipi;
            this.Flow = flow;
            this.DiffKind = diffKind;
            this.Ref = varRef;
            this.AccountBranchCode = accountBranchCode;
            this.AccountNumber = accountNumber;
            this.AccountSuffix = accountSuffix;
            this.ProductCode = productCode;
            this.ProjectCode = projectCode;
            this.CampaignCode = campaignCode;
            this.Rating = rating;
            this.Module = module;
            this.DiffType = diffType;
            this.Status = status;
            this.CurrencyCode = currencyCode;
            this.Amount = amount;
            this.DayNumber = dayNumber;
            this.BeginningDate = beginningDate;
            this.EndDate = endDate;
            this.EndDate2 = endDate2;
            this.RemoveDate = removeDate;
            this.BranchEndDate = branchEndDate;
            this.OtherBranchCode = otherBranchCode;
            this.SBExplanation = sBExplanation;
            this.GMExplanation = gMExplanation;
            this.ModulRef = modulRef;
            this.CustomerName = customerName;
            this.DiffTypeExp = diffTypeExp;
            this.DiffKindExp = diffKindExp;
            this.StatusExp = statusExp;
            this.DayCount = dayCount;
            this.AuthorityTitleExp = authorityTitleExp;
            this.OperationType = operationType;
            this.OperationKind = operationKind;
            this.DifDetails = difDetails;
            this.RecordStatus = recordStatus;
            this.WorkflowActionNumber = workflowActionNumber;
            this.ExternalChannelCode = externalChannelCode;
        }

        /// <summary>
        /// Gets or Sets RecordInfo
        /// </summary>
        [DataMember(Name = "RecordInfo", EmitDefaultValue = false)]
        public ForaRecordInfo RecordInfo { get; set; }

        /// <summary>
        /// Gets or Sets TemAltTipi
        /// </summary>
        [DataMember(Name = "TemAltTipi", EmitDefaultValue = true)]
        public string TemAltTipi { get; set; }

        /// <summary>
        /// Gets or Sets Flow
        /// </summary>
        [DataMember(Name = "Flow", EmitDefaultValue = true)]
        public string Flow { get; set; }

        /// <summary>
        /// Gets or Sets DiffKind
        /// </summary>
        [DataMember(Name = "DiffKind", EmitDefaultValue = true)]
        public string DiffKind { get; set; }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name = "Ref", EmitDefaultValue = false)]
        public int Ref { get; set; }

        /// <summary>
        /// Gets or Sets AccountBranchCode
        /// </summary>
        [DataMember(Name = "AccountBranchCode", EmitDefaultValue = false)]
        public int AccountBranchCode { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name = "AccountNumber", EmitDefaultValue = false)]
        public int AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets AccountSuffix
        /// </summary>
        [DataMember(Name = "AccountSuffix", EmitDefaultValue = false)]
        public int AccountSuffix { get; set; }

        /// <summary>
        /// Gets or Sets ProductCode
        /// </summary>
        [DataMember(Name = "ProductCode", EmitDefaultValue = true)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or Sets ProjectCode
        /// </summary>
        [DataMember(Name = "ProjectCode", EmitDefaultValue = true)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// Gets or Sets CampaignCode
        /// </summary>
        [DataMember(Name = "CampaignCode", EmitDefaultValue = true)]
        public string CampaignCode { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name = "Rating", EmitDefaultValue = true)]
        public string Rating { get; set; }

        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        [DataMember(Name = "Module", EmitDefaultValue = true)]
        public string Module { get; set; }

        /// <summary>
        /// Gets or Sets DiffType
        /// </summary>
        [DataMember(Name = "DiffType", EmitDefaultValue = true)]
        public string DiffType { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name = "CurrencyCode", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or Sets DayNumber
        /// </summary>
        [DataMember(Name = "DayNumber", EmitDefaultValue = false)]
        public int DayNumber { get; set; }

        /// <summary>
        /// Gets or Sets BeginningDate
        /// </summary>
        [DataMember(Name = "BeginningDate", EmitDefaultValue = true)]
        public string BeginningDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "EndDate", EmitDefaultValue = true)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate2
        /// </summary>
        [DataMember(Name = "EndDate2", EmitDefaultValue = true)]
        public string EndDate2 { get; set; }

        /// <summary>
        /// Gets or Sets RemoveDate
        /// </summary>
        [DataMember(Name = "RemoveDate", EmitDefaultValue = true)]
        public string RemoveDate { get; set; }

        /// <summary>
        /// Gets or Sets BranchEndDate
        /// </summary>
        [DataMember(Name = "BranchEndDate", EmitDefaultValue = true)]
        public string BranchEndDate { get; set; }

        /// <summary>
        /// Gets or Sets OtherBranchCode
        /// </summary>
        [DataMember(Name = "OtherBranchCode", EmitDefaultValue = false)]
        public int OtherBranchCode { get; set; }

        /// <summary>
        /// Gets or Sets SBExplanation
        /// </summary>
        [DataMember(Name = "SBExplanation", EmitDefaultValue = true)]
        public string SBExplanation { get; set; }

        /// <summary>
        /// Gets or Sets GMExplanation
        /// </summary>
        [DataMember(Name = "GMExplanation", EmitDefaultValue = true)]
        public string GMExplanation { get; set; }

        /// <summary>
        /// Gets or Sets ModulRef
        /// </summary>
        [DataMember(Name = "ModulRef", EmitDefaultValue = true)]
        public string ModulRef { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name = "CustomerName", EmitDefaultValue = true)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets DiffTypeExp
        /// </summary>
        [DataMember(Name = "DiffTypeExp", EmitDefaultValue = true)]
        public string DiffTypeExp { get; set; }

        /// <summary>
        /// Gets or Sets DiffKindExp
        /// </summary>
        [DataMember(Name = "DiffKindExp", EmitDefaultValue = true)]
        public string DiffKindExp { get; set; }

        /// <summary>
        /// Gets or Sets StatusExp
        /// </summary>
        [DataMember(Name = "StatusExp", EmitDefaultValue = true)]
        public string StatusExp { get; set; }

        /// <summary>
        /// Gets or Sets DayCount
        /// </summary>
        [DataMember(Name = "DayCount", EmitDefaultValue = false)]
        public int DayCount { get; set; }

        /// <summary>
        /// Gets or Sets AuthorityTitleExp
        /// </summary>
        [DataMember(Name = "AuthorityTitleExp", EmitDefaultValue = true)]
        public string AuthorityTitleExp { get; set; }

        /// <summary>
        /// Gets or Sets OperationType
        /// </summary>
        [DataMember(Name = "OperationType", EmitDefaultValue = true)]
        public string OperationType { get; set; }

        /// <summary>
        /// Gets or Sets OperationKind
        /// </summary>
        [DataMember(Name = "OperationKind", EmitDefaultValue = true)]
        public string OperationKind { get; set; }

        /// <summary>
        /// Gets or Sets DifDetails
        /// </summary>
        [DataMember(Name = "DifDetails", EmitDefaultValue = true)]
        public List<DifDetailEntity> DifDetails { get; set; }

        /// <summary>
        /// Gets or Sets RecordStatus
        /// </summary>
        [DataMember(Name = "RecordStatus", EmitDefaultValue = true)]
        public string RecordStatus { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowActionNumber
        /// </summary>
        [DataMember(Name = "WorkflowActionNumber", EmitDefaultValue = true)]
        public string WorkflowActionNumber { get; set; }

        /// <summary>
        /// Gets or Sets ExternalChannelCode
        /// </summary>
        [DataMember(Name = "ExternalChannelCode", EmitDefaultValue = true)]
        public string ExternalChannelCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DifEntity {\n");
            sb.Append("  RecordInfo: ").Append(RecordInfo).Append("\n");
            sb.Append("  TemAltTipi: ").Append(TemAltTipi).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  DiffKind: ").Append(DiffKind).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  AccountBranchCode: ").Append(AccountBranchCode).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountSuffix: ").Append(AccountSuffix).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  ProjectCode: ").Append(ProjectCode).Append("\n");
            sb.Append("  CampaignCode: ").Append(CampaignCode).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  DiffType: ").Append(DiffType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DayNumber: ").Append(DayNumber).Append("\n");
            sb.Append("  BeginningDate: ").Append(BeginningDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EndDate2: ").Append(EndDate2).Append("\n");
            sb.Append("  RemoveDate: ").Append(RemoveDate).Append("\n");
            sb.Append("  BranchEndDate: ").Append(BranchEndDate).Append("\n");
            sb.Append("  OtherBranchCode: ").Append(OtherBranchCode).Append("\n");
            sb.Append("  SBExplanation: ").Append(SBExplanation).Append("\n");
            sb.Append("  GMExplanation: ").Append(GMExplanation).Append("\n");
            sb.Append("  ModulRef: ").Append(ModulRef).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  DiffTypeExp: ").Append(DiffTypeExp).Append("\n");
            sb.Append("  DiffKindExp: ").Append(DiffKindExp).Append("\n");
            sb.Append("  StatusExp: ").Append(StatusExp).Append("\n");
            sb.Append("  DayCount: ").Append(DayCount).Append("\n");
            sb.Append("  AuthorityTitleExp: ").Append(AuthorityTitleExp).Append("\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  OperationKind: ").Append(OperationKind).Append("\n");
            sb.Append("  DifDetails: ").Append(DifDetails).Append("\n");
            sb.Append("  RecordStatus: ").Append(RecordStatus).Append("\n");
            sb.Append("  WorkflowActionNumber: ").Append(WorkflowActionNumber).Append("\n");
            sb.Append("  ExternalChannelCode: ").Append(ExternalChannelCode).Append("\n");
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
