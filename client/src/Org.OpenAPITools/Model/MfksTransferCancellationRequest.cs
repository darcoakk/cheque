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
    /// MfksTransferCancellationRequest
    /// </summary>
    [DataContract(Name = "MfksTransferCancellationRequest")]
    public partial class MfksTransferCancellationRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksTransferCancellationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MfksTransferCancellationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksTransferCancellationRequest" /> class.
        /// </summary>
        /// <param name="kullaniciSicili">kullaniciSicili (required).</param>
        /// <param name="belgeReferansNo">belgeReferansNo.</param>
        /// <param name="documentNumber">documentNumber.</param>
        /// <param name="userCode">userCode.</param>
        public MfksTransferCancellationRequest(string kullaniciSicili = default(string), string belgeReferansNo = default(string), string documentNumber = default(string), string userCode = default(string))
        {
            // to ensure "kullaniciSicili" is required (not null)
            if (kullaniciSicili == null)
            {
                throw new ArgumentNullException("kullaniciSicili is a required property for MfksTransferCancellationRequest and cannot be null");
            }
            this.KullaniciSicili = kullaniciSicili;
            this.BelgeReferansNo = belgeReferansNo;
            this.DocumentNumber = documentNumber;
            this.UserCode = userCode;
        }

        /// <summary>
        /// Gets or Sets KullaniciSicili
        /// </summary>
        [DataMember(Name = "kullaniciSicili", IsRequired = true, EmitDefaultValue = true)]
        public string KullaniciSicili { get; set; }

        /// <summary>
        /// Gets or Sets BelgeReferansNo
        /// </summary>
        [DataMember(Name = "belgeReferansNo", EmitDefaultValue = true)]
        public string BelgeReferansNo { get; set; }

        /// <summary>
        /// Gets or Sets DocumentNumber
        /// </summary>
        [DataMember(Name = "documentNumber", EmitDefaultValue = true)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or Sets UserCode
        /// </summary>
        [DataMember(Name = "userCode", EmitDefaultValue = true)]
        public string UserCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfksTransferCancellationRequest {\n");
            sb.Append("  KullaniciSicili: ").Append(KullaniciSicili).Append("\n");
            sb.Append("  BelgeReferansNo: ").Append(BelgeReferansNo).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  UserCode: ").Append(UserCode).Append("\n");
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
            // KullaniciSicili (string) minLength
            if (this.KullaniciSicili != null && this.KullaniciSicili.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for KullaniciSicili, length must be greater than 1.", new [] { "KullaniciSicili" });
            }

            yield break;
        }
    }

}
