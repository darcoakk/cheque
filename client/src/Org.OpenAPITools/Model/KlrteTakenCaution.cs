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
    /// KlrteTakenCaution
    /// </summary>
    [DataContract(Name = "KlrteTakenCaution")]
    public partial class KlrteTakenCaution : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KlrteTakenCaution" /> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="kindName">kindName.</param>
        /// <param name="priority">priority.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="amount">amount.</param>
        /// <param name="afterUsageAmount">afterUsageAmount.</param>
        /// <param name="marginRatio">marginRatio.</param>
        /// <param name="tranBranchCode">tranBranchCode.</param>
        /// <param name="risk">risk.</param>
        /// <param name="afterUsageRisk">afterUsageRisk.</param>
        /// <param name="cautionIndex">cautionIndex.</param>
        /// <param name="documentAuthority">documentAuthority.</param>
        /// <param name="marginType">marginType.</param>
        /// <param name="takenCautionRef">takenCautionRef.</param>
        /// <param name="isCommonCaution">isCommonCaution.</param>
        /// <param name="expertiseAmount">expertiseAmount.</param>
        /// <param name="expertiseCurrencyCode">expertiseCurrencyCode.</param>
        /// <param name="expertiseMarginRatio">expertiseMarginRatio.</param>
        /// <param name="expertiseMarginType">expertiseMarginType.</param>
        /// <param name="amountWithMargin">amountWithMargin.</param>
        /// <param name="availableAmountWithMargin">availableAmountWithMargin.</param>
        /// <param name="cautionRef">cautionRef.</param>
        /// <param name="productsAndAccounts">productsAndAccounts.</param>
        /// <param name="klrteSuffix">klrteSuffix.</param>
        /// <param name="lineNumber">lineNumber.</param>
        /// <param name="takenCautionIndex">takenCautionIndex.</param>
        /// <param name="insuranceMaturity">insuranceMaturity.</param>
        /// <param name="cautionMaturityDate">cautionMaturityDate.</param>
        /// <param name="expertiseInsuranceAmount">expertiseInsuranceAmount.</param>
        /// <param name="arrangedInsuranceFlag">arrangedInsuranceFlag.</param>
        /// <param name="cautinAmountWithMargin">cautinAmountWithMargin.</param>
        /// <param name="usedCautionTreasuryFlag">usedCautionTreasuryFlag.</param>
        /// <param name="usedCauTreMarginFlag">usedCauTreMarginFlag.</param>
        /// <param name="differenceExplanation">differenceExplanation.</param>
        /// <param name="differenceFlag">differenceFlag.</param>
        /// <param name="cautionTranBranchCode">cautionTranBranchCode.</param>
        public KlrteTakenCaution(string kind = default(string), string kindName = default(string), int priority = default(int), string currencyCode = default(string), double amount = default(double), double afterUsageAmount = default(double), double marginRatio = default(double), int tranBranchCode = default(int), double risk = default(double), double afterUsageRisk = default(double), int cautionIndex = default(int), string documentAuthority = default(string), string marginType = default(string), int takenCautionRef = default(int), string isCommonCaution = default(string), double expertiseAmount = default(double), string expertiseCurrencyCode = default(string), double expertiseMarginRatio = default(double), string expertiseMarginType = default(string), double amountWithMargin = default(double), double availableAmountWithMargin = default(double), int cautionRef = default(int), List<CautionsSuffixProductEntity> productsAndAccounts = default(List<CautionsSuffixProductEntity>), KlrteSuffix klrteSuffix = default(KlrteSuffix), int lineNumber = default(int), int takenCautionIndex = default(int), string insuranceMaturity = default(string), string cautionMaturityDate = default(string), double expertiseInsuranceAmount = default(double), string arrangedInsuranceFlag = default(string), double cautinAmountWithMargin = default(double), string usedCautionTreasuryFlag = default(string), string usedCauTreMarginFlag = default(string), string differenceExplanation = default(string), string differenceFlag = default(string), int cautionTranBranchCode = default(int))
        {
            this.Kind = kind;
            this.KindName = kindName;
            this.Priority = priority;
            this.CurrencyCode = currencyCode;
            this.Amount = amount;
            this.AfterUsageAmount = afterUsageAmount;
            this.MarginRatio = marginRatio;
            this.TranBranchCode = tranBranchCode;
            this.Risk = risk;
            this.AfterUsageRisk = afterUsageRisk;
            this.CautionIndex = cautionIndex;
            this.DocumentAuthority = documentAuthority;
            this.MarginType = marginType;
            this.TakenCautionRef = takenCautionRef;
            this.IsCommonCaution = isCommonCaution;
            this.ExpertiseAmount = expertiseAmount;
            this.ExpertiseCurrencyCode = expertiseCurrencyCode;
            this.ExpertiseMarginRatio = expertiseMarginRatio;
            this.ExpertiseMarginType = expertiseMarginType;
            this.AmountWithMargin = amountWithMargin;
            this.AvailableAmountWithMargin = availableAmountWithMargin;
            this.CautionRef = cautionRef;
            this.ProductsAndAccounts = productsAndAccounts;
            this.KlrteSuffix = klrteSuffix;
            this.LineNumber = lineNumber;
            this.TakenCautionIndex = takenCautionIndex;
            this.InsuranceMaturity = insuranceMaturity;
            this.CautionMaturityDate = cautionMaturityDate;
            this.ExpertiseInsuranceAmount = expertiseInsuranceAmount;
            this.ArrangedInsuranceFlag = arrangedInsuranceFlag;
            this.CautinAmountWithMargin = cautinAmountWithMargin;
            this.UsedCautionTreasuryFlag = usedCautionTreasuryFlag;
            this.UsedCauTreMarginFlag = usedCauTreMarginFlag;
            this.DifferenceExplanation = differenceExplanation;
            this.DifferenceFlag = differenceFlag;
            this.CautionTranBranchCode = cautionTranBranchCode;
        }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "Kind", EmitDefaultValue = true)]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or Sets KindName
        /// </summary>
        [DataMember(Name = "KindName", EmitDefaultValue = true)]
        public string KindName { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "Priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

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
        /// Gets or Sets AfterUsageAmount
        /// </summary>
        [DataMember(Name = "AfterUsageAmount", EmitDefaultValue = false)]
        public double AfterUsageAmount { get; set; }

        /// <summary>
        /// Gets or Sets MarginRatio
        /// </summary>
        [DataMember(Name = "MarginRatio", EmitDefaultValue = false)]
        public double MarginRatio { get; set; }

        /// <summary>
        /// Gets or Sets TranBranchCode
        /// </summary>
        [DataMember(Name = "TranBranchCode", EmitDefaultValue = false)]
        public int TranBranchCode { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        [DataMember(Name = "Risk", EmitDefaultValue = false)]
        public double Risk { get; set; }

        /// <summary>
        /// Gets or Sets AfterUsageRisk
        /// </summary>
        [DataMember(Name = "AfterUsageRisk", EmitDefaultValue = false)]
        public double AfterUsageRisk { get; set; }

        /// <summary>
        /// Gets or Sets AvailableAmount
        /// </summary>
        [DataMember(Name = "AvailableAmount", EmitDefaultValue = false)]
        public double AvailableAmount { get; private set; }

        /// <summary>
        /// Returns false as AvailableAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAvailableAmount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets AfterUsageAvailableAmount
        /// </summary>
        [DataMember(Name = "AfterUsageAvailableAmount", EmitDefaultValue = false)]
        public double AfterUsageAvailableAmount { get; private set; }

        /// <summary>
        /// Returns false as AfterUsageAvailableAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAfterUsageAvailableAmount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CautionIndex
        /// </summary>
        [DataMember(Name = "CautionIndex", EmitDefaultValue = false)]
        public int CautionIndex { get; set; }

        /// <summary>
        /// Gets or Sets DocumentAuthority
        /// </summary>
        [DataMember(Name = "DocumentAuthority", EmitDefaultValue = true)]
        public string DocumentAuthority { get; set; }

        /// <summary>
        /// Gets or Sets MarginType
        /// </summary>
        [DataMember(Name = "MarginType", EmitDefaultValue = true)]
        public string MarginType { get; set; }

        /// <summary>
        /// Gets or Sets TakenCautionRef
        /// </summary>
        [DataMember(Name = "TakenCautionRef", EmitDefaultValue = false)]
        public int TakenCautionRef { get; set; }

        /// <summary>
        /// Gets or Sets IsCommonCaution
        /// </summary>
        [DataMember(Name = "IsCommonCaution", EmitDefaultValue = true)]
        public string IsCommonCaution { get; set; }

        /// <summary>
        /// Gets or Sets ExpertiseAmount
        /// </summary>
        [DataMember(Name = "ExpertiseAmount", EmitDefaultValue = false)]
        public double ExpertiseAmount { get; set; }

        /// <summary>
        /// Gets or Sets ExpertiseCurrencyCode
        /// </summary>
        [DataMember(Name = "ExpertiseCurrencyCode", EmitDefaultValue = true)]
        public string ExpertiseCurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets ExpertiseMarginRatio
        /// </summary>
        [DataMember(Name = "ExpertiseMarginRatio", EmitDefaultValue = false)]
        public double ExpertiseMarginRatio { get; set; }

        /// <summary>
        /// Gets or Sets ExpertiseMarginType
        /// </summary>
        [DataMember(Name = "ExpertiseMarginType", EmitDefaultValue = true)]
        public string ExpertiseMarginType { get; set; }

        /// <summary>
        /// Gets or Sets AmountWithMargin
        /// </summary>
        [DataMember(Name = "AmountWithMargin", EmitDefaultValue = false)]
        public double AmountWithMargin { get; set; }

        /// <summary>
        /// Gets or Sets AvailableAmountWithMargin
        /// </summary>
        [DataMember(Name = "AvailableAmountWithMargin", EmitDefaultValue = false)]
        public double AvailableAmountWithMargin { get; set; }

        /// <summary>
        /// Gets or Sets CautionRef
        /// </summary>
        [DataMember(Name = "CautionRef", EmitDefaultValue = false)]
        public int CautionRef { get; set; }

        /// <summary>
        /// Gets or Sets ProductsAndAccounts
        /// </summary>
        [DataMember(Name = "ProductsAndAccounts", EmitDefaultValue = true)]
        public List<CautionsSuffixProductEntity> ProductsAndAccounts { get; set; }

        /// <summary>
        /// Gets or Sets KlrteSuffix
        /// </summary>
        [DataMember(Name = "KlrteSuffix", EmitDefaultValue = false)]
        public KlrteSuffix KlrteSuffix { get; set; }

        /// <summary>
        /// Gets or Sets LineNumber
        /// </summary>
        [DataMember(Name = "LineNumber", EmitDefaultValue = false)]
        public int LineNumber { get; set; }

        /// <summary>
        /// Gets or Sets TakenCautionIndex
        /// </summary>
        [DataMember(Name = "TakenCautionIndex", EmitDefaultValue = false)]
        public int TakenCautionIndex { get; set; }

        /// <summary>
        /// Gets or Sets InsuranceMaturity
        /// </summary>
        [DataMember(Name = "InsuranceMaturity", EmitDefaultValue = true)]
        public string InsuranceMaturity { get; set; }

        /// <summary>
        /// Gets or Sets CautionMaturityDate
        /// </summary>
        [DataMember(Name = "CautionMaturityDate", EmitDefaultValue = true)]
        public string CautionMaturityDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpertiseInsuranceAmount
        /// </summary>
        [DataMember(Name = "ExpertiseInsuranceAmount", EmitDefaultValue = false)]
        public double ExpertiseInsuranceAmount { get; set; }

        /// <summary>
        /// Gets or Sets ArrangedInsuranceFlag
        /// </summary>
        [DataMember(Name = "ArrangedInsuranceFlag", EmitDefaultValue = true)]
        public string ArrangedInsuranceFlag { get; set; }

        /// <summary>
        /// Gets or Sets CautinAmountWithMargin
        /// </summary>
        [DataMember(Name = "CautinAmountWithMargin", EmitDefaultValue = false)]
        public double CautinAmountWithMargin { get; set; }

        /// <summary>
        /// Gets or Sets UsedCautionTreasuryFlag
        /// </summary>
        [DataMember(Name = "UsedCautionTreasuryFlag", EmitDefaultValue = true)]
        public string UsedCautionTreasuryFlag { get; set; }

        /// <summary>
        /// Gets or Sets UsedCauTreMarginFlag
        /// </summary>
        [DataMember(Name = "UsedCauTreMarginFlag", EmitDefaultValue = true)]
        public string UsedCauTreMarginFlag { get; set; }

        /// <summary>
        /// Gets or Sets DifferenceExplanation
        /// </summary>
        [DataMember(Name = "DifferenceExplanation", EmitDefaultValue = true)]
        public string DifferenceExplanation { get; set; }

        /// <summary>
        /// Gets or Sets DifferenceFlag
        /// </summary>
        [DataMember(Name = "DifferenceFlag", EmitDefaultValue = true)]
        public string DifferenceFlag { get; set; }

        /// <summary>
        /// Gets or Sets CautionTranBranchCode
        /// </summary>
        [DataMember(Name = "CautionTranBranchCode", EmitDefaultValue = false)]
        public int CautionTranBranchCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KlrteTakenCaution {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  KindName: ").Append(KindName).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AfterUsageAmount: ").Append(AfterUsageAmount).Append("\n");
            sb.Append("  MarginRatio: ").Append(MarginRatio).Append("\n");
            sb.Append("  TranBranchCode: ").Append(TranBranchCode).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
            sb.Append("  AfterUsageRisk: ").Append(AfterUsageRisk).Append("\n");
            sb.Append("  AvailableAmount: ").Append(AvailableAmount).Append("\n");
            sb.Append("  AfterUsageAvailableAmount: ").Append(AfterUsageAvailableAmount).Append("\n");
            sb.Append("  CautionIndex: ").Append(CautionIndex).Append("\n");
            sb.Append("  DocumentAuthority: ").Append(DocumentAuthority).Append("\n");
            sb.Append("  MarginType: ").Append(MarginType).Append("\n");
            sb.Append("  TakenCautionRef: ").Append(TakenCautionRef).Append("\n");
            sb.Append("  IsCommonCaution: ").Append(IsCommonCaution).Append("\n");
            sb.Append("  ExpertiseAmount: ").Append(ExpertiseAmount).Append("\n");
            sb.Append("  ExpertiseCurrencyCode: ").Append(ExpertiseCurrencyCode).Append("\n");
            sb.Append("  ExpertiseMarginRatio: ").Append(ExpertiseMarginRatio).Append("\n");
            sb.Append("  ExpertiseMarginType: ").Append(ExpertiseMarginType).Append("\n");
            sb.Append("  AmountWithMargin: ").Append(AmountWithMargin).Append("\n");
            sb.Append("  AvailableAmountWithMargin: ").Append(AvailableAmountWithMargin).Append("\n");
            sb.Append("  CautionRef: ").Append(CautionRef).Append("\n");
            sb.Append("  ProductsAndAccounts: ").Append(ProductsAndAccounts).Append("\n");
            sb.Append("  KlrteSuffix: ").Append(KlrteSuffix).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  TakenCautionIndex: ").Append(TakenCautionIndex).Append("\n");
            sb.Append("  InsuranceMaturity: ").Append(InsuranceMaturity).Append("\n");
            sb.Append("  CautionMaturityDate: ").Append(CautionMaturityDate).Append("\n");
            sb.Append("  ExpertiseInsuranceAmount: ").Append(ExpertiseInsuranceAmount).Append("\n");
            sb.Append("  ArrangedInsuranceFlag: ").Append(ArrangedInsuranceFlag).Append("\n");
            sb.Append("  CautinAmountWithMargin: ").Append(CautinAmountWithMargin).Append("\n");
            sb.Append("  UsedCautionTreasuryFlag: ").Append(UsedCautionTreasuryFlag).Append("\n");
            sb.Append("  UsedCauTreMarginFlag: ").Append(UsedCauTreMarginFlag).Append("\n");
            sb.Append("  DifferenceExplanation: ").Append(DifferenceExplanation).Append("\n");
            sb.Append("  DifferenceFlag: ").Append(DifferenceFlag).Append("\n");
            sb.Append("  CautionTranBranchCode: ").Append(CautionTranBranchCode).Append("\n");
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
