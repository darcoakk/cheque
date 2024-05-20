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
    /// DiscountInfo
    /// </summary>
    [DataContract(Name = "DiscountInfo")]
    public partial class DiscountInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountInfo" /> class.
        /// </summary>
        /// <param name="discountReference">discountReference.</param>
        /// <param name="discountReferenceBranchCode">discountReferenceBranchCode.</param>
        /// <param name="productCode">productCode.</param>
        /// <param name="discountType">discountType.</param>
        /// <param name="discountSubType">discountSubType.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="cECurrencyCode">cECurrencyCode.</param>
        /// <param name="entranceDate">entranceDate.</param>
        /// <param name="averageMaturityDayCount">averageMaturityDayCount.</param>
        /// <param name="hasBankGuarantee">hasBankGuarantee.</param>
        /// <param name="interestCalculationMethod">interestCalculationMethod.</param>
        /// <param name="beneficiaryAccountBranchCode">beneficiaryAccountBranchCode.</param>
        /// <param name="beneficiaryAccountNumber">beneficiaryAccountNumber.</param>
        /// <param name="beneficiaryAccountSuffix">beneficiaryAccountSuffix.</param>
        /// <param name="beneficiaryCurrencyCode">beneficiaryCurrencyCode.</param>
        /// <param name="creditAccountBranchCode">creditAccountBranchCode.</param>
        /// <param name="creditAccountNumber">creditAccountNumber.</param>
        /// <param name="creditAccountSuffix">creditAccountSuffix.</param>
        /// <param name="otherCosts">otherCosts.</param>
        /// <param name="projectCode">projectCode.</param>
        /// <param name="dSBranchCode">dSBranchCode.</param>
        /// <param name="campaignCode">campaignCode.</param>
        /// <param name="cashCommissionRate">cashCommissionRate.</param>
        /// <param name="averageInterestRate">averageInterestRate.</param>
        /// <param name="bsmv">bsmv.</param>
        /// <param name="costInterestRate">costInterestRate.</param>
        /// <param name="creditMaturityDate">creditMaturityDate.</param>
        /// <param name="totalAmount">totalAmount.</param>
        /// <param name="discountInterestRate">discountInterestRate.</param>
        /// <param name="totalBsmv">totalBsmv.</param>
        /// <param name="totalCashPaymentAmount">totalCashPaymentAmount.</param>
        /// <param name="totalDiscountAmount">totalDiscountAmount.</param>
        /// <param name="totalInterestAmount">totalInterestAmount.</param>
        /// <param name="totalKkdf">totalKkdf.</param>
        /// <param name="totalPaymentAmount">totalPaymentAmount.</param>
        /// <param name="details">details.</param>
        /// <param name="confirmBankAccountSwiftBankCode">confirmBankAccountSwiftBankCode.</param>
        /// <param name="confirmBankAccountSwiftCountryCode">confirmBankAccountSwiftCountryCode.</param>
        /// <param name="confirmBankAccountSwiftBranchCode">confirmBankAccountSwiftBranchCode.</param>
        /// <param name="exchangeRateReservationNumber">exchangeRateReservationNumber.</param>
        /// <param name="fiProvisionNumber">fiProvisionNumber.</param>
        /// <param name="isDomestic">isDomestic.</param>
        /// <param name="lastUpdatingChannelCode">lastUpdatingChannelCode.</param>
        /// <param name="lastUpdatingTranCode">lastUpdatingTranCode.</param>
        /// <param name="lastUpdatingUserCode">lastUpdatingUserCode.</param>
        /// <param name="lastUpdateDate">lastUpdateDate.</param>
        /// <param name="recordStatus">recordStatus.</param>
        /// <param name="extraMaturityDayCount">extraMaturityDayCount.</param>
        public DiscountInfo(int discountReference = default(int), int discountReferenceBranchCode = default(int), string productCode = default(string), string discountType = default(string), string discountSubType = default(string), string currencyCode = default(string), string cECurrencyCode = default(string), DateTime entranceDate = default(DateTime), double averageMaturityDayCount = default(double), string hasBankGuarantee = default(string), string interestCalculationMethod = default(string), int beneficiaryAccountBranchCode = default(int), int beneficiaryAccountNumber = default(int), int beneficiaryAccountSuffix = default(int), string beneficiaryCurrencyCode = default(string), int creditAccountBranchCode = default(int), int creditAccountNumber = default(int), int creditAccountSuffix = default(int), double otherCosts = default(double), string projectCode = default(string), int dSBranchCode = default(int), string campaignCode = default(string), double cashCommissionRate = default(double), double averageInterestRate = default(double), double bsmv = default(double), double costInterestRate = default(double), DateTime creditMaturityDate = default(DateTime), double totalAmount = default(double), double discountInterestRate = default(double), double totalBsmv = default(double), double totalCashPaymentAmount = default(double), double totalDiscountAmount = default(double), double totalInterestAmount = default(double), double totalKkdf = default(double), double totalPaymentAmount = default(double), List<DiscountDetail> details = default(List<DiscountDetail>), string confirmBankAccountSwiftBankCode = default(string), string confirmBankAccountSwiftCountryCode = default(string), string confirmBankAccountSwiftBranchCode = default(string), int? exchangeRateReservationNumber = default(int?), int? fiProvisionNumber = default(int?), string isDomestic = default(string), string lastUpdatingChannelCode = default(string), string lastUpdatingTranCode = default(string), string lastUpdatingUserCode = default(string), DateTime lastUpdateDate = default(DateTime), string recordStatus = default(string), int? extraMaturityDayCount = default(int?))
        {
            this.DiscountReference = discountReference;
            this.DiscountReferenceBranchCode = discountReferenceBranchCode;
            this.ProductCode = productCode;
            this.DiscountType = discountType;
            this.DiscountSubType = discountSubType;
            this.CurrencyCode = currencyCode;
            this.CECurrencyCode = cECurrencyCode;
            this.EntranceDate = entranceDate;
            this.AverageMaturityDayCount = averageMaturityDayCount;
            this.HasBankGuarantee = hasBankGuarantee;
            this.InterestCalculationMethod = interestCalculationMethod;
            this.BeneficiaryAccountBranchCode = beneficiaryAccountBranchCode;
            this.BeneficiaryAccountNumber = beneficiaryAccountNumber;
            this.BeneficiaryAccountSuffix = beneficiaryAccountSuffix;
            this.BeneficiaryCurrencyCode = beneficiaryCurrencyCode;
            this.CreditAccountBranchCode = creditAccountBranchCode;
            this.CreditAccountNumber = creditAccountNumber;
            this.CreditAccountSuffix = creditAccountSuffix;
            this.OtherCosts = otherCosts;
            this.ProjectCode = projectCode;
            this.DSBranchCode = dSBranchCode;
            this.CampaignCode = campaignCode;
            this.CashCommissionRate = cashCommissionRate;
            this.AverageInterestRate = averageInterestRate;
            this.Bsmv = bsmv;
            this.CostInterestRate = costInterestRate;
            this.CreditMaturityDate = creditMaturityDate;
            this.TotalAmount = totalAmount;
            this.DiscountInterestRate = discountInterestRate;
            this.TotalBsmv = totalBsmv;
            this.TotalCashPaymentAmount = totalCashPaymentAmount;
            this.TotalDiscountAmount = totalDiscountAmount;
            this.TotalInterestAmount = totalInterestAmount;
            this.TotalKkdf = totalKkdf;
            this.TotalPaymentAmount = totalPaymentAmount;
            this.Details = details;
            this.ConfirmBankAccountSwiftBankCode = confirmBankAccountSwiftBankCode;
            this.ConfirmBankAccountSwiftCountryCode = confirmBankAccountSwiftCountryCode;
            this.ConfirmBankAccountSwiftBranchCode = confirmBankAccountSwiftBranchCode;
            this.ExchangeRateReservationNumber = exchangeRateReservationNumber;
            this.FiProvisionNumber = fiProvisionNumber;
            this.IsDomestic = isDomestic;
            this.LastUpdatingChannelCode = lastUpdatingChannelCode;
            this.LastUpdatingTranCode = lastUpdatingTranCode;
            this.LastUpdatingUserCode = lastUpdatingUserCode;
            this.LastUpdateDate = lastUpdateDate;
            this.RecordStatus = recordStatus;
            this.ExtraMaturityDayCount = extraMaturityDayCount;
        }

        /// <summary>
        /// Gets or Sets DiscountReference
        /// </summary>
        [DataMember(Name = "DiscountReference", EmitDefaultValue = false)]
        public int DiscountReference { get; set; }

        /// <summary>
        /// Gets or Sets DiscountReferenceBranchCode
        /// </summary>
        [DataMember(Name = "DiscountReferenceBranchCode", EmitDefaultValue = false)]
        public int DiscountReferenceBranchCode { get; set; }

        /// <summary>
        /// Gets or Sets ProductCode
        /// </summary>
        [DataMember(Name = "ProductCode", EmitDefaultValue = true)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or Sets DiscountType
        /// </summary>
        [DataMember(Name = "DiscountType", EmitDefaultValue = true)]
        public string DiscountType { get; set; }

        /// <summary>
        /// Gets or Sets DiscountSubType
        /// </summary>
        [DataMember(Name = "DiscountSubType", EmitDefaultValue = true)]
        public string DiscountSubType { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name = "CurrencyCode", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CECurrencyCode
        /// </summary>
        [DataMember(Name = "CECurrencyCode", EmitDefaultValue = true)]
        public string CECurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets EntranceDate
        /// </summary>
        [DataMember(Name = "EntranceDate", EmitDefaultValue = false)]
        public DateTime EntranceDate { get; set; }

        /// <summary>
        /// Gets or Sets AverageMaturityDayCount
        /// </summary>
        [DataMember(Name = "AverageMaturityDayCount", EmitDefaultValue = false)]
        public double AverageMaturityDayCount { get; set; }

        /// <summary>
        /// Gets or Sets HasBankGuarantee
        /// </summary>
        [DataMember(Name = "HasBankGuarantee", EmitDefaultValue = true)]
        public string HasBankGuarantee { get; set; }

        /// <summary>
        /// Gets or Sets InterestCalculationMethod
        /// </summary>
        [DataMember(Name = "InterestCalculationMethod", EmitDefaultValue = true)]
        public string InterestCalculationMethod { get; set; }

        /// <summary>
        /// Gets or Sets BeneficiaryAccountBranchCode
        /// </summary>
        [DataMember(Name = "BeneficiaryAccountBranchCode", EmitDefaultValue = false)]
        public int BeneficiaryAccountBranchCode { get; set; }

        /// <summary>
        /// Gets or Sets BeneficiaryAccountNumber
        /// </summary>
        [DataMember(Name = "BeneficiaryAccountNumber", EmitDefaultValue = false)]
        public int BeneficiaryAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets BeneficiaryAccountSuffix
        /// </summary>
        [DataMember(Name = "BeneficiaryAccountSuffix", EmitDefaultValue = false)]
        public int BeneficiaryAccountSuffix { get; set; }

        /// <summary>
        /// Gets or Sets BeneficiaryCurrencyCode
        /// </summary>
        [DataMember(Name = "BeneficiaryCurrencyCode", EmitDefaultValue = true)]
        public string BeneficiaryCurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CreditAccountBranchCode
        /// </summary>
        [DataMember(Name = "CreditAccountBranchCode", EmitDefaultValue = false)]
        public int CreditAccountBranchCode { get; set; }

        /// <summary>
        /// Gets or Sets CreditAccountNumber
        /// </summary>
        [DataMember(Name = "CreditAccountNumber", EmitDefaultValue = false)]
        public int CreditAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets CreditAccountSuffix
        /// </summary>
        [DataMember(Name = "CreditAccountSuffix", EmitDefaultValue = false)]
        public int CreditAccountSuffix { get; set; }

        /// <summary>
        /// Gets or Sets OtherCosts
        /// </summary>
        [DataMember(Name = "OtherCosts", EmitDefaultValue = false)]
        public double OtherCosts { get; set; }

        /// <summary>
        /// Gets or Sets ProjectCode
        /// </summary>
        [DataMember(Name = "ProjectCode", EmitDefaultValue = true)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// Gets or Sets DSBranchCode
        /// </summary>
        [DataMember(Name = "DSBranchCode", EmitDefaultValue = false)]
        public int DSBranchCode { get; set; }

        /// <summary>
        /// Gets or Sets CampaignCode
        /// </summary>
        [DataMember(Name = "CampaignCode", EmitDefaultValue = true)]
        public string CampaignCode { get; set; }

        /// <summary>
        /// Gets or Sets CashCommissionRate
        /// </summary>
        [DataMember(Name = "CashCommissionRate", EmitDefaultValue = false)]
        public double CashCommissionRate { get; set; }

        /// <summary>
        /// Gets or Sets AverageInterestRate
        /// </summary>
        [DataMember(Name = "AverageInterestRate", EmitDefaultValue = false)]
        public double AverageInterestRate { get; set; }

        /// <summary>
        /// Gets or Sets Bsmv
        /// </summary>
        [DataMember(Name = "Bsmv", EmitDefaultValue = false)]
        public double Bsmv { get; set; }

        /// <summary>
        /// Gets or Sets CostInterestRate
        /// </summary>
        [DataMember(Name = "CostInterestRate", EmitDefaultValue = false)]
        public double CostInterestRate { get; set; }

        /// <summary>
        /// Gets or Sets CreditMaturityDate
        /// </summary>
        [DataMember(Name = "CreditMaturityDate", EmitDefaultValue = false)]
        public DateTime CreditMaturityDate { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name = "TotalAmount", EmitDefaultValue = false)]
        public double TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets DiscountInterestRate
        /// </summary>
        [DataMember(Name = "DiscountInterestRate", EmitDefaultValue = false)]
        public double DiscountInterestRate { get; set; }

        /// <summary>
        /// Gets or Sets TotalBsmv
        /// </summary>
        [DataMember(Name = "TotalBsmv", EmitDefaultValue = false)]
        public double TotalBsmv { get; set; }

        /// <summary>
        /// Gets or Sets TotalCashPaymentAmount
        /// </summary>
        [DataMember(Name = "TotalCashPaymentAmount", EmitDefaultValue = false)]
        public double TotalCashPaymentAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalDiscountAmount
        /// </summary>
        [DataMember(Name = "TotalDiscountAmount", EmitDefaultValue = false)]
        public double TotalDiscountAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalInterestAmount
        /// </summary>
        [DataMember(Name = "TotalInterestAmount", EmitDefaultValue = false)]
        public double TotalInterestAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalKkdf
        /// </summary>
        [DataMember(Name = "TotalKkdf", EmitDefaultValue = false)]
        public double TotalKkdf { get; set; }

        /// <summary>
        /// Gets or Sets TotalPaymentAmount
        /// </summary>
        [DataMember(Name = "TotalPaymentAmount", EmitDefaultValue = false)]
        public double TotalPaymentAmount { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "Details", EmitDefaultValue = true)]
        public List<DiscountDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmBankAccountSwiftBankCode
        /// </summary>
        [DataMember(Name = "ConfirmBankAccountSwiftBankCode", EmitDefaultValue = true)]
        public string ConfirmBankAccountSwiftBankCode { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmBankAccountSwiftCountryCode
        /// </summary>
        [DataMember(Name = "ConfirmBankAccountSwiftCountryCode", EmitDefaultValue = true)]
        public string ConfirmBankAccountSwiftCountryCode { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmBankAccountSwiftBranchCode
        /// </summary>
        [DataMember(Name = "ConfirmBankAccountSwiftBranchCode", EmitDefaultValue = true)]
        public string ConfirmBankAccountSwiftBranchCode { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRateReservationNumber
        /// </summary>
        [DataMember(Name = "ExchangeRateReservationNumber", EmitDefaultValue = true)]
        public int? ExchangeRateReservationNumber { get; set; }

        /// <summary>
        /// Gets or Sets FiProvisionNumber
        /// </summary>
        [DataMember(Name = "FiProvisionNumber", EmitDefaultValue = true)]
        public int? FiProvisionNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsDomestic
        /// </summary>
        [DataMember(Name = "IsDomestic", EmitDefaultValue = true)]
        public string IsDomestic { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatingChannelCode
        /// </summary>
        [DataMember(Name = "LastUpdatingChannelCode", EmitDefaultValue = true)]
        public string LastUpdatingChannelCode { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatingTranCode
        /// </summary>
        [DataMember(Name = "LastUpdatingTranCode", EmitDefaultValue = true)]
        public string LastUpdatingTranCode { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatingUserCode
        /// </summary>
        [DataMember(Name = "LastUpdatingUserCode", EmitDefaultValue = true)]
        public string LastUpdatingUserCode { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdateDate
        /// </summary>
        [DataMember(Name = "LastUpdateDate", EmitDefaultValue = false)]
        public DateTime LastUpdateDate { get; set; }

        /// <summary>
        /// Gets or Sets RecordStatus
        /// </summary>
        [DataMember(Name = "RecordStatus", EmitDefaultValue = true)]
        public string RecordStatus { get; set; }

        /// <summary>
        /// Gets or Sets ExtraMaturityDayCount
        /// </summary>
        [DataMember(Name = "ExtraMaturityDayCount", EmitDefaultValue = true)]
        public int? ExtraMaturityDayCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiscountInfo {\n");
            sb.Append("  DiscountReference: ").Append(DiscountReference).Append("\n");
            sb.Append("  DiscountReferenceBranchCode: ").Append(DiscountReferenceBranchCode).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  DiscountSubType: ").Append(DiscountSubType).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CECurrencyCode: ").Append(CECurrencyCode).Append("\n");
            sb.Append("  EntranceDate: ").Append(EntranceDate).Append("\n");
            sb.Append("  AverageMaturityDayCount: ").Append(AverageMaturityDayCount).Append("\n");
            sb.Append("  HasBankGuarantee: ").Append(HasBankGuarantee).Append("\n");
            sb.Append("  InterestCalculationMethod: ").Append(InterestCalculationMethod).Append("\n");
            sb.Append("  BeneficiaryAccountBranchCode: ").Append(BeneficiaryAccountBranchCode).Append("\n");
            sb.Append("  BeneficiaryAccountNumber: ").Append(BeneficiaryAccountNumber).Append("\n");
            sb.Append("  BeneficiaryAccountSuffix: ").Append(BeneficiaryAccountSuffix).Append("\n");
            sb.Append("  BeneficiaryCurrencyCode: ").Append(BeneficiaryCurrencyCode).Append("\n");
            sb.Append("  CreditAccountBranchCode: ").Append(CreditAccountBranchCode).Append("\n");
            sb.Append("  CreditAccountNumber: ").Append(CreditAccountNumber).Append("\n");
            sb.Append("  CreditAccountSuffix: ").Append(CreditAccountSuffix).Append("\n");
            sb.Append("  OtherCosts: ").Append(OtherCosts).Append("\n");
            sb.Append("  ProjectCode: ").Append(ProjectCode).Append("\n");
            sb.Append("  DSBranchCode: ").Append(DSBranchCode).Append("\n");
            sb.Append("  CampaignCode: ").Append(CampaignCode).Append("\n");
            sb.Append("  CashCommissionRate: ").Append(CashCommissionRate).Append("\n");
            sb.Append("  AverageInterestRate: ").Append(AverageInterestRate).Append("\n");
            sb.Append("  Bsmv: ").Append(Bsmv).Append("\n");
            sb.Append("  CostInterestRate: ").Append(CostInterestRate).Append("\n");
            sb.Append("  CreditMaturityDate: ").Append(CreditMaturityDate).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  DiscountInterestRate: ").Append(DiscountInterestRate).Append("\n");
            sb.Append("  TotalBsmv: ").Append(TotalBsmv).Append("\n");
            sb.Append("  TotalCashPaymentAmount: ").Append(TotalCashPaymentAmount).Append("\n");
            sb.Append("  TotalDiscountAmount: ").Append(TotalDiscountAmount).Append("\n");
            sb.Append("  TotalInterestAmount: ").Append(TotalInterestAmount).Append("\n");
            sb.Append("  TotalKkdf: ").Append(TotalKkdf).Append("\n");
            sb.Append("  TotalPaymentAmount: ").Append(TotalPaymentAmount).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  ConfirmBankAccountSwiftBankCode: ").Append(ConfirmBankAccountSwiftBankCode).Append("\n");
            sb.Append("  ConfirmBankAccountSwiftCountryCode: ").Append(ConfirmBankAccountSwiftCountryCode).Append("\n");
            sb.Append("  ConfirmBankAccountSwiftBranchCode: ").Append(ConfirmBankAccountSwiftBranchCode).Append("\n");
            sb.Append("  ExchangeRateReservationNumber: ").Append(ExchangeRateReservationNumber).Append("\n");
            sb.Append("  FiProvisionNumber: ").Append(FiProvisionNumber).Append("\n");
            sb.Append("  IsDomestic: ").Append(IsDomestic).Append("\n");
            sb.Append("  LastUpdatingChannelCode: ").Append(LastUpdatingChannelCode).Append("\n");
            sb.Append("  LastUpdatingTranCode: ").Append(LastUpdatingTranCode).Append("\n");
            sb.Append("  LastUpdatingUserCode: ").Append(LastUpdatingUserCode).Append("\n");
            sb.Append("  LastUpdateDate: ").Append(LastUpdateDate).Append("\n");
            sb.Append("  RecordStatus: ").Append(RecordStatus).Append("\n");
            sb.Append("  ExtraMaturityDayCount: ").Append(ExtraMaturityDayCount).Append("\n");
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
