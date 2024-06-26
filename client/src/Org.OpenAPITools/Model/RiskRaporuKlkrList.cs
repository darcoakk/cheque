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
    /// RiskRaporuKlkrList
    /// </summary>
    [DataContract(Name = "RiskRaporuKlkrList")]
    public partial class RiskRaporuKlkrList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskRaporuKlkrList" /> class.
        /// </summary>
        /// <param name="riskKodu">riskKodu.</param>
        /// <param name="riskKoduAciklama">riskKoduAciklama.</param>
        /// <param name="birOnIkiAyVadeliRiskToplami">birOnIkiAyVadeliRiskToplami.</param>
        /// <param name="onIkiYirmiDortAyVadeliRiskToplami">onIkiYirmiDortAyVadeliRiskToplami.</param>
        /// <param name="yirmiDortAyUzeriVadeliRiskToplami">yirmiDortAyUzeriVadeliRiskToplami.</param>
        /// <param name="bildirimDonemi">bildirimDonemi.</param>
        /// <param name="krediLimiti">krediLimiti.</param>
        /// <param name="faizReeskontKomToplami">faizReeskontKomToplami.</param>
        /// <param name="faizTahakkukKomToplami">faizTahakkukKomToplami.</param>
        public RiskRaporuKlkrList(string riskKodu = default(string), string riskKoduAciklama = default(string), string birOnIkiAyVadeliRiskToplami = default(string), string onIkiYirmiDortAyVadeliRiskToplami = default(string), string yirmiDortAyUzeriVadeliRiskToplami = default(string), string bildirimDonemi = default(string), string krediLimiti = default(string), string faizReeskontKomToplami = default(string), string faizTahakkukKomToplami = default(string))
        {
            this.RiskKodu = riskKodu;
            this.RiskKoduAciklama = riskKoduAciklama;
            this.BirOnIkiAyVadeliRiskToplami = birOnIkiAyVadeliRiskToplami;
            this.OnIkiYirmiDortAyVadeliRiskToplami = onIkiYirmiDortAyVadeliRiskToplami;
            this.YirmiDortAyUzeriVadeliRiskToplami = yirmiDortAyUzeriVadeliRiskToplami;
            this.BildirimDonemi = bildirimDonemi;
            this.KrediLimiti = krediLimiti;
            this.FaizReeskontKomToplami = faizReeskontKomToplami;
            this.FaizTahakkukKomToplami = faizTahakkukKomToplami;
        }

        /// <summary>
        /// Gets or Sets RiskKodu
        /// </summary>
        [DataMember(Name = "riskKodu", EmitDefaultValue = true)]
        public string RiskKodu { get; set; }

        /// <summary>
        /// Gets or Sets RiskKoduAciklama
        /// </summary>
        [DataMember(Name = "riskKoduAciklama", EmitDefaultValue = true)]
        public string RiskKoduAciklama { get; set; }

        /// <summary>
        /// Gets or Sets BirOnIkiAyVadeliRiskToplami
        /// </summary>
        [DataMember(Name = "birOnIkiAyVadeliRiskToplami", EmitDefaultValue = true)]
        public string BirOnIkiAyVadeliRiskToplami { get; set; }

        /// <summary>
        /// Gets or Sets OnIkiYirmiDortAyVadeliRiskToplami
        /// </summary>
        [DataMember(Name = "onIkiYirmiDortAyVadeliRiskToplami", EmitDefaultValue = true)]
        public string OnIkiYirmiDortAyVadeliRiskToplami { get; set; }

        /// <summary>
        /// Gets or Sets YirmiDortAyUzeriVadeliRiskToplami
        /// </summary>
        [DataMember(Name = "yirmiDortAyUzeriVadeliRiskToplami", EmitDefaultValue = true)]
        public string YirmiDortAyUzeriVadeliRiskToplami { get; set; }

        /// <summary>
        /// Gets or Sets BildirimDonemi
        /// </summary>
        [DataMember(Name = "bildirimDonemi", EmitDefaultValue = true)]
        public string BildirimDonemi { get; set; }

        /// <summary>
        /// Gets or Sets KrediLimiti
        /// </summary>
        [DataMember(Name = "krediLimiti", EmitDefaultValue = true)]
        public string KrediLimiti { get; set; }

        /// <summary>
        /// Gets or Sets FaizReeskontKomToplami
        /// </summary>
        [DataMember(Name = "faizReeskontKomToplami", EmitDefaultValue = true)]
        public string FaizReeskontKomToplami { get; set; }

        /// <summary>
        /// Gets or Sets FaizTahakkukKomToplami
        /// </summary>
        [DataMember(Name = "faizTahakkukKomToplami", EmitDefaultValue = true)]
        public string FaizTahakkukKomToplami { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RiskRaporuKlkrList {\n");
            sb.Append("  RiskKodu: ").Append(RiskKodu).Append("\n");
            sb.Append("  RiskKoduAciklama: ").Append(RiskKoduAciklama).Append("\n");
            sb.Append("  BirOnIkiAyVadeliRiskToplami: ").Append(BirOnIkiAyVadeliRiskToplami).Append("\n");
            sb.Append("  OnIkiYirmiDortAyVadeliRiskToplami: ").Append(OnIkiYirmiDortAyVadeliRiskToplami).Append("\n");
            sb.Append("  YirmiDortAyUzeriVadeliRiskToplami: ").Append(YirmiDortAyUzeriVadeliRiskToplami).Append("\n");
            sb.Append("  BildirimDonemi: ").Append(BildirimDonemi).Append("\n");
            sb.Append("  KrediLimiti: ").Append(KrediLimiti).Append("\n");
            sb.Append("  FaizReeskontKomToplami: ").Append(FaizReeskontKomToplami).Append("\n");
            sb.Append("  FaizTahakkukKomToplami: ").Append(FaizTahakkukKomToplami).Append("\n");
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
