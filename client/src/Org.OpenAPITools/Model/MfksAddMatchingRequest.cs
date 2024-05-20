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
    /// MfksAddMatchingRequest
    /// </summary>
    [DataContract(Name = "MfksAddMatchingRequest")]
    public partial class MfksAddMatchingRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksAddMatchingRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MfksAddMatchingRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksAddMatchingRequest" /> class.
        /// </summary>
        /// <param name="kullaniciSicili">kullaniciSicili (required).</param>
        /// <param name="islemSonucuAciklama">islemSonucuAciklama.</param>
        /// <param name="bazBelgeReferansNo">bazBelgeReferansNo.</param>
        /// <param name="eslenecekBelgeListe">eslenecekBelgeListe.</param>
        public MfksAddMatchingRequest(string kullaniciSicili = default(string), string islemSonucuAciklama = default(string), string bazBelgeReferansNo = default(string), List<EslemeParametre> eslenecekBelgeListe = default(List<EslemeParametre>))
        {
            // to ensure "kullaniciSicili" is required (not null)
            if (kullaniciSicili == null)
            {
                throw new ArgumentNullException("kullaniciSicili is a required property for MfksAddMatchingRequest and cannot be null");
            }
            this.KullaniciSicili = kullaniciSicili;
            this.IslemSonucuAciklama = islemSonucuAciklama;
            this.BazBelgeReferansNo = bazBelgeReferansNo;
            this.EslenecekBelgeListe = eslenecekBelgeListe;
        }

        /// <summary>
        /// Gets or Sets KullaniciSicili
        /// </summary>
        [DataMember(Name = "kullaniciSicili", IsRequired = true, EmitDefaultValue = true)]
        public string KullaniciSicili { get; set; }

        /// <summary>
        /// Gets or Sets IslemSonucuAciklama
        /// </summary>
        [DataMember(Name = "islemSonucuAciklama", EmitDefaultValue = true)]
        public string IslemSonucuAciklama { get; set; }

        /// <summary>
        /// Gets or Sets BazBelgeReferansNo
        /// </summary>
        [DataMember(Name = "bazBelgeReferansNo", EmitDefaultValue = true)]
        public string BazBelgeReferansNo { get; set; }

        /// <summary>
        /// Gets or Sets EslenecekBelgeListe
        /// </summary>
        [DataMember(Name = "eslenecekBelgeListe", EmitDefaultValue = true)]
        public List<EslemeParametre> EslenecekBelgeListe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfksAddMatchingRequest {\n");
            sb.Append("  KullaniciSicili: ").Append(KullaniciSicili).Append("\n");
            sb.Append("  IslemSonucuAciklama: ").Append(IslemSonucuAciklama).Append("\n");
            sb.Append("  BazBelgeReferansNo: ").Append(BazBelgeReferansNo).Append("\n");
            sb.Append("  EslenecekBelgeListe: ").Append(EslenecekBelgeListe).Append("\n");
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