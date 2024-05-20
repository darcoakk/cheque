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
    /// BuyerLimitResult
    /// </summary>
    [DataContract(Name = "BuyerLimitResult")]
    public partial class BuyerLimitResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuyerLimitResult" /> class.
        /// </summary>
        /// <param name="citizenShipOrTaxNumber">citizenShipOrTaxNumber.</param>
        /// <param name="firmNumber">firmNumber.</param>
        /// <param name="buyerName">buyerName.</param>
        /// <param name="customerName">customerName.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="buyerLimit">buyerLimit.</param>
        /// <param name="customerRisk">customerRisk.</param>
        /// <param name="buyerRisk">buyerRisk.</param>
        /// <param name="factoringRisk">factoringRisk.</param>
        /// <param name="factoringLimit">factoringLimit.</param>
        /// <param name="buyerLimitMaturity">buyerLimitMaturity.</param>
        /// <param name="factoringMaturityDate">factoringMaturityDate.</param>
        /// <param name="buyerLimitAllocationMaturity">buyerLimitAllocationMaturity.</param>
        /// <param name="insertUser">insertUser.</param>
        /// <param name="insertDate">insertDate.</param>
        /// <param name="totalRecordCount">totalRecordCount.</param>
        /// <param name="customerStatus">customerStatus.</param>
        /// <param name="firmName">firmName.</param>
        /// <param name="invoiceDebtorTitle">invoiceDebtorTitle.</param>
        /// <param name="bearerTitle">bearerTitle.</param>
        /// <param name="bearerCitizenShipNumber">bearerCitizenShipNumber.</param>
        /// <param name="drawerTitle">drawerTitle.</param>
        /// <param name="bpmNo">bpmNo.</param>
        /// <param name="chequeNumber">chequeNumber.</param>
        /// <param name="chequeValueDate">chequeValueDate.</param>
        /// <param name="chequeAmount">chequeAmount.</param>
        /// <param name="collectedAmount">collectedAmount.</param>
        /// <param name="remainingAmount">remainingAmount.</param>
        /// <param name="drawerBankCode">drawerBankCode.</param>
        /// <param name="drawerBranchCode">drawerBranchCode.</param>
        /// <param name="chequeStatus">chequeStatus.</param>
        /// <param name="delayDate">delayDate.</param>
        public BuyerLimitResult(string citizenShipOrTaxNumber = default(string), string firmNumber = default(string), string buyerName = default(string), string customerName = default(string), string currencyCode = default(string), string buyerLimit = default(string), string customerRisk = default(string), string buyerRisk = default(string), string factoringRisk = default(string), string factoringLimit = default(string), string buyerLimitMaturity = default(string), string factoringMaturityDate = default(string), string buyerLimitAllocationMaturity = default(string), string insertUser = default(string), string insertDate = default(string), string totalRecordCount = default(string), string customerStatus = default(string), string firmName = default(string), string invoiceDebtorTitle = default(string), string bearerTitle = default(string), string bearerCitizenShipNumber = default(string), string drawerTitle = default(string), string bpmNo = default(string), string chequeNumber = default(string), string chequeValueDate = default(string), double chequeAmount = default(double), string collectedAmount = default(string), string remainingAmount = default(string), string drawerBankCode = default(string), string drawerBranchCode = default(string), string chequeStatus = default(string), string delayDate = default(string))
        {
            this.CitizenShipOrTaxNumber = citizenShipOrTaxNumber;
            this.FirmNumber = firmNumber;
            this.BuyerName = buyerName;
            this.CustomerName = customerName;
            this.CurrencyCode = currencyCode;
            this.BuyerLimit = buyerLimit;
            this.CustomerRisk = customerRisk;
            this.BuyerRisk = buyerRisk;
            this.FactoringRisk = factoringRisk;
            this.FactoringLimit = factoringLimit;
            this.BuyerLimitMaturity = buyerLimitMaturity;
            this.FactoringMaturityDate = factoringMaturityDate;
            this.BuyerLimitAllocationMaturity = buyerLimitAllocationMaturity;
            this.InsertUser = insertUser;
            this.InsertDate = insertDate;
            this.TotalRecordCount = totalRecordCount;
            this.CustomerStatus = customerStatus;
            this.FirmName = firmName;
            this.InvoiceDebtorTitle = invoiceDebtorTitle;
            this.BearerTitle = bearerTitle;
            this.BearerCitizenShipNumber = bearerCitizenShipNumber;
            this.DrawerTitle = drawerTitle;
            this.BpmNo = bpmNo;
            this.ChequeNumber = chequeNumber;
            this.ChequeValueDate = chequeValueDate;
            this.ChequeAmount = chequeAmount;
            this.CollectedAmount = collectedAmount;
            this.RemainingAmount = remainingAmount;
            this.DrawerBankCode = drawerBankCode;
            this.DrawerBranchCode = drawerBranchCode;
            this.ChequeStatus = chequeStatus;
            this.DelayDate = delayDate;
        }

        /// <summary>
        /// Gets or Sets CitizenShipOrTaxNumber
        /// </summary>
        [DataMember(Name = "CitizenShipOrTaxNumber", EmitDefaultValue = true)]
        public string CitizenShipOrTaxNumber { get; set; }

        /// <summary>
        /// Gets or Sets FirmNumber
        /// </summary>
        [DataMember(Name = "FirmNumber", EmitDefaultValue = true)]
        public string FirmNumber { get; set; }

        /// <summary>
        /// Gets or Sets BuyerName
        /// </summary>
        [DataMember(Name = "BuyerName", EmitDefaultValue = true)]
        public string BuyerName { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name = "CustomerName", EmitDefaultValue = true)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name = "CurrencyCode", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets BuyerLimit
        /// </summary>
        [DataMember(Name = "BuyerLimit", EmitDefaultValue = true)]
        public string BuyerLimit { get; set; }

        /// <summary>
        /// Gets or Sets CustomerRisk
        /// </summary>
        [DataMember(Name = "CustomerRisk", EmitDefaultValue = true)]
        public string CustomerRisk { get; set; }

        /// <summary>
        /// Gets or Sets BuyerRisk
        /// </summary>
        [DataMember(Name = "BuyerRisk", EmitDefaultValue = true)]
        public string BuyerRisk { get; set; }

        /// <summary>
        /// Gets or Sets FactoringRisk
        /// </summary>
        [DataMember(Name = "FactoringRisk", EmitDefaultValue = true)]
        public string FactoringRisk { get; set; }

        /// <summary>
        /// Gets or Sets FactoringLimit
        /// </summary>
        [DataMember(Name = "FactoringLimit", EmitDefaultValue = true)]
        public string FactoringLimit { get; set; }

        /// <summary>
        /// Gets or Sets BuyerLimitMaturity
        /// </summary>
        [DataMember(Name = "BuyerLimitMaturity", EmitDefaultValue = true)]
        public string BuyerLimitMaturity { get; set; }

        /// <summary>
        /// Gets or Sets FactoringMaturityDate
        /// </summary>
        [DataMember(Name = "FactoringMaturityDate", EmitDefaultValue = true)]
        public string FactoringMaturityDate { get; set; }

        /// <summary>
        /// Gets or Sets BuyerLimitAllocationMaturity
        /// </summary>
        [DataMember(Name = "BuyerLimitAllocationMaturity", EmitDefaultValue = true)]
        public string BuyerLimitAllocationMaturity { get; set; }

        /// <summary>
        /// Gets or Sets InsertUser
        /// </summary>
        [DataMember(Name = "InsertUser", EmitDefaultValue = true)]
        public string InsertUser { get; set; }

        /// <summary>
        /// Gets or Sets InsertDate
        /// </summary>
        [DataMember(Name = "InsertDate", EmitDefaultValue = true)]
        public string InsertDate { get; set; }

        /// <summary>
        /// Gets or Sets TotalRecordCount
        /// </summary>
        [DataMember(Name = "TotalRecordCount", EmitDefaultValue = true)]
        public string TotalRecordCount { get; set; }

        /// <summary>
        /// Gets or Sets CustomerStatus
        /// </summary>
        [DataMember(Name = "CustomerStatus", EmitDefaultValue = true)]
        public string CustomerStatus { get; set; }

        /// <summary>
        /// Gets or Sets FirmName
        /// </summary>
        [DataMember(Name = "FirmName", EmitDefaultValue = true)]
        public string FirmName { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDebtorTitle
        /// </summary>
        [DataMember(Name = "InvoiceDebtorTitle", EmitDefaultValue = true)]
        public string InvoiceDebtorTitle { get; set; }

        /// <summary>
        /// Gets or Sets BearerTitle
        /// </summary>
        [DataMember(Name = "BearerTitle", EmitDefaultValue = true)]
        public string BearerTitle { get; set; }

        /// <summary>
        /// Gets or Sets BearerCitizenShipNumber
        /// </summary>
        [DataMember(Name = "BearerCitizenShipNumber", EmitDefaultValue = true)]
        public string BearerCitizenShipNumber { get; set; }

        /// <summary>
        /// Gets or Sets DrawerTitle
        /// </summary>
        [DataMember(Name = "DrawerTitle", EmitDefaultValue = true)]
        public string DrawerTitle { get; set; }

        /// <summary>
        /// Gets or Sets BpmNo
        /// </summary>
        [DataMember(Name = "BpmNo", EmitDefaultValue = true)]
        public string BpmNo { get; set; }

        /// <summary>
        /// Gets or Sets ChequeNumber
        /// </summary>
        [DataMember(Name = "ChequeNumber", EmitDefaultValue = true)]
        public string ChequeNumber { get; set; }

        /// <summary>
        /// Gets or Sets ChequeValueDate
        /// </summary>
        [DataMember(Name = "ChequeValueDate", EmitDefaultValue = true)]
        public string ChequeValueDate { get; set; }

        /// <summary>
        /// Gets or Sets ChequeAmount
        /// </summary>
        [DataMember(Name = "ChequeAmount", EmitDefaultValue = false)]
        public double ChequeAmount { get; set; }

        /// <summary>
        /// Gets or Sets CollectedAmount
        /// </summary>
        [DataMember(Name = "CollectedAmount", EmitDefaultValue = true)]
        public string CollectedAmount { get; set; }

        /// <summary>
        /// Gets or Sets RemainingAmount
        /// </summary>
        [DataMember(Name = "RemainingAmount", EmitDefaultValue = true)]
        public string RemainingAmount { get; set; }

        /// <summary>
        /// Gets or Sets DrawerBankCode
        /// </summary>
        [DataMember(Name = "DrawerBankCode", EmitDefaultValue = true)]
        public string DrawerBankCode { get; set; }

        /// <summary>
        /// Gets or Sets DrawerBranchCode
        /// </summary>
        [DataMember(Name = "DrawerBranchCode", EmitDefaultValue = true)]
        public string DrawerBranchCode { get; set; }

        /// <summary>
        /// Gets or Sets ChequeStatus
        /// </summary>
        [DataMember(Name = "ChequeStatus", EmitDefaultValue = true)]
        public string ChequeStatus { get; set; }

        /// <summary>
        /// Gets or Sets DelayDate
        /// </summary>
        [DataMember(Name = "DelayDate", EmitDefaultValue = true)]
        public string DelayDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BuyerLimitResult {\n");
            sb.Append("  CitizenShipOrTaxNumber: ").Append(CitizenShipOrTaxNumber).Append("\n");
            sb.Append("  FirmNumber: ").Append(FirmNumber).Append("\n");
            sb.Append("  BuyerName: ").Append(BuyerName).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  BuyerLimit: ").Append(BuyerLimit).Append("\n");
            sb.Append("  CustomerRisk: ").Append(CustomerRisk).Append("\n");
            sb.Append("  BuyerRisk: ").Append(BuyerRisk).Append("\n");
            sb.Append("  FactoringRisk: ").Append(FactoringRisk).Append("\n");
            sb.Append("  FactoringLimit: ").Append(FactoringLimit).Append("\n");
            sb.Append("  BuyerLimitMaturity: ").Append(BuyerLimitMaturity).Append("\n");
            sb.Append("  FactoringMaturityDate: ").Append(FactoringMaturityDate).Append("\n");
            sb.Append("  BuyerLimitAllocationMaturity: ").Append(BuyerLimitAllocationMaturity).Append("\n");
            sb.Append("  InsertUser: ").Append(InsertUser).Append("\n");
            sb.Append("  InsertDate: ").Append(InsertDate).Append("\n");
            sb.Append("  TotalRecordCount: ").Append(TotalRecordCount).Append("\n");
            sb.Append("  CustomerStatus: ").Append(CustomerStatus).Append("\n");
            sb.Append("  FirmName: ").Append(FirmName).Append("\n");
            sb.Append("  InvoiceDebtorTitle: ").Append(InvoiceDebtorTitle).Append("\n");
            sb.Append("  BearerTitle: ").Append(BearerTitle).Append("\n");
            sb.Append("  BearerCitizenShipNumber: ").Append(BearerCitizenShipNumber).Append("\n");
            sb.Append("  DrawerTitle: ").Append(DrawerTitle).Append("\n");
            sb.Append("  BpmNo: ").Append(BpmNo).Append("\n");
            sb.Append("  ChequeNumber: ").Append(ChequeNumber).Append("\n");
            sb.Append("  ChequeValueDate: ").Append(ChequeValueDate).Append("\n");
            sb.Append("  ChequeAmount: ").Append(ChequeAmount).Append("\n");
            sb.Append("  CollectedAmount: ").Append(CollectedAmount).Append("\n");
            sb.Append("  RemainingAmount: ").Append(RemainingAmount).Append("\n");
            sb.Append("  DrawerBankCode: ").Append(DrawerBankCode).Append("\n");
            sb.Append("  DrawerBranchCode: ").Append(DrawerBranchCode).Append("\n");
            sb.Append("  ChequeStatus: ").Append(ChequeStatus).Append("\n");
            sb.Append("  DelayDate: ").Append(DelayDate).Append("\n");
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
