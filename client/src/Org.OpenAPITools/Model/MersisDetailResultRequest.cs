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
    /// MersisDetailResultRequest
    /// </summary>
    [DataContract(Name = "MersisDetailResultRequest")]
    public partial class MersisDetailResultRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MersisDetailResultRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MersisDetailResultRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MersisDetailResultRequest" /> class.
        /// </summary>
        /// <param name="kullaniciKodu">kullaniciKodu (required).</param>
        /// <param name="kullaniciAdiSoyadi">kullaniciAdiSoyadi (required).</param>
        /// <param name="detayReferansNo">detayReferansNo (required).</param>
        public MersisDetailResultRequest(string kullaniciKodu = default(string), string kullaniciAdiSoyadi = default(string), string detayReferansNo = default(string))
        {
            // to ensure "kullaniciKodu" is required (not null)
            if (kullaniciKodu == null)
            {
                throw new ArgumentNullException("kullaniciKodu is a required property for MersisDetailResultRequest and cannot be null");
            }
            this.KullaniciKodu = kullaniciKodu;
            // to ensure "kullaniciAdiSoyadi" is required (not null)
            if (kullaniciAdiSoyadi == null)
            {
                throw new ArgumentNullException("kullaniciAdiSoyadi is a required property for MersisDetailResultRequest and cannot be null");
            }
            this.KullaniciAdiSoyadi = kullaniciAdiSoyadi;
            // to ensure "detayReferansNo" is required (not null)
            if (detayReferansNo == null)
            {
                throw new ArgumentNullException("detayReferansNo is a required property for MersisDetailResultRequest and cannot be null");
            }
            this.DetayReferansNo = detayReferansNo;
        }

        /// <summary>
        /// Gets or Sets KullaniciKodu
        /// </summary>
        [DataMember(Name = "kullaniciKodu", IsRequired = true, EmitDefaultValue = true)]
        public string KullaniciKodu { get; set; }

        /// <summary>
        /// Gets or Sets KullaniciAdiSoyadi
        /// </summary>
        [DataMember(Name = "kullaniciAdiSoyadi", IsRequired = true, EmitDefaultValue = true)]
        public string KullaniciAdiSoyadi { get; set; }

        /// <summary>
        /// Gets or Sets DetayReferansNo
        /// </summary>
        [DataMember(Name = "detayReferansNo", IsRequired = true, EmitDefaultValue = true)]
        public string DetayReferansNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MersisDetailResultRequest {\n");
            sb.Append("  KullaniciKodu: ").Append(KullaniciKodu).Append("\n");
            sb.Append("  KullaniciAdiSoyadi: ").Append(KullaniciAdiSoyadi).Append("\n");
            sb.Append("  DetayReferansNo: ").Append(DetayReferansNo).Append("\n");
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
            // KullaniciKodu (string) minLength
            if (this.KullaniciKodu != null && this.KullaniciKodu.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for KullaniciKodu, length must be greater than 1.", new [] { "KullaniciKodu" });
            }

            // KullaniciAdiSoyadi (string) minLength
            if (this.KullaniciAdiSoyadi != null && this.KullaniciAdiSoyadi.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for KullaniciAdiSoyadi, length must be greater than 1.", new [] { "KullaniciAdiSoyadi" });
            }

            // DetayReferansNo (string) minLength
            if (this.DetayReferansNo != null && this.DetayReferansNo.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DetayReferansNo, length must be greater than 1.", new [] { "DetayReferansNo" });
            }

            yield break;
        }
    }

}
