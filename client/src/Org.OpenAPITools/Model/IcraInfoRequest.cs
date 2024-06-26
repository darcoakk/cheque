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
    /// IcraInfoRequest
    /// </summary>
    [DataContract(Name = "IcraInfoRequest")]
    public partial class IcraInfoRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IcraInfoRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IcraInfoRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IcraInfoRequest" /> class.
        /// </summary>
        /// <param name="uygulama">uygulama (required).</param>
        /// <param name="olayNo">olayNo (required).</param>
        /// <param name="userName">userName (required).</param>
        /// <param name="tCKNVKN">tCKNVKN (required).</param>
        /// <param name="ad">ad.</param>
        public IcraInfoRequest(string uygulama = default(string), string olayNo = default(string), string userName = default(string), string tCKNVKN = default(string), string ad = default(string))
        {
            // to ensure "uygulama" is required (not null)
            if (uygulama == null)
            {
                throw new ArgumentNullException("uygulama is a required property for IcraInfoRequest and cannot be null");
            }
            this.Uygulama = uygulama;
            // to ensure "olayNo" is required (not null)
            if (olayNo == null)
            {
                throw new ArgumentNullException("olayNo is a required property for IcraInfoRequest and cannot be null");
            }
            this.OlayNo = olayNo;
            // to ensure "userName" is required (not null)
            if (userName == null)
            {
                throw new ArgumentNullException("userName is a required property for IcraInfoRequest and cannot be null");
            }
            this.UserName = userName;
            // to ensure "tCKNVKN" is required (not null)
            if (tCKNVKN == null)
            {
                throw new ArgumentNullException("tCKNVKN is a required property for IcraInfoRequest and cannot be null");
            }
            this.TCKNVKN = tCKNVKN;
            this.Ad = ad;
        }

        /// <summary>
        /// Gets or Sets Uygulama
        /// </summary>
        [DataMember(Name = "Uygulama", IsRequired = true, EmitDefaultValue = true)]
        public string Uygulama { get; set; }

        /// <summary>
        /// Gets or Sets OlayNo
        /// </summary>
        [DataMember(Name = "OlayNo", IsRequired = true, EmitDefaultValue = true)]
        public string OlayNo { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "UserName", IsRequired = true, EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets TCKNVKN
        /// </summary>
        [DataMember(Name = "TCKNVKN", IsRequired = true, EmitDefaultValue = true)]
        public string TCKNVKN { get; set; }

        /// <summary>
        /// Gets or Sets Ad
        /// </summary>
        [DataMember(Name = "Ad", EmitDefaultValue = true)]
        public string Ad { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IcraInfoRequest {\n");
            sb.Append("  Uygulama: ").Append(Uygulama).Append("\n");
            sb.Append("  OlayNo: ").Append(OlayNo).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  TCKNVKN: ").Append(TCKNVKN).Append("\n");
            sb.Append("  Ad: ").Append(Ad).Append("\n");
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
            // Uygulama (string) minLength
            if (this.Uygulama != null && this.Uygulama.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Uygulama, length must be greater than 1.", new [] { "Uygulama" });
            }

            // OlayNo (string) minLength
            if (this.OlayNo != null && this.OlayNo.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OlayNo, length must be greater than 1.", new [] { "OlayNo" });
            }

            // UserName (string) minLength
            if (this.UserName != null && this.UserName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserName, length must be greater than 1.", new [] { "UserName" });
            }

            // TCKNVKN (string) minLength
            if (this.TCKNVKN != null && this.TCKNVKN.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TCKNVKN, length must be greater than 1.", new [] { "TCKNVKN" });
            }

            yield break;
        }
    }

}
