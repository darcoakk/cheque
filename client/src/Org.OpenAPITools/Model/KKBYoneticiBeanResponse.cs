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
    /// KKBYoneticiBeanResponse
    /// </summary>
    [DataContract(Name = "KKBYoneticiBeanResponse")]
    public partial class KKBYoneticiBeanResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KKBYoneticiBeanResponse" /> class.
        /// </summary>
        /// <param name="tcKimlikNo">tcKimlikNo.</param>
        /// <param name="adi">adi.</param>
        /// <param name="soyadi">soyadi.</param>
        /// <param name="gorevi">gorevi.</param>
        /// <param name="digerGorevi">digerGorevi.</param>
        /// <param name="imzaYetkisi">imzaYetkisi.</param>
        public KKBYoneticiBeanResponse(string tcKimlikNo = default(string), string adi = default(string), string soyadi = default(string), int gorevi = default(int), string digerGorevi = default(string), string imzaYetkisi = default(string))
        {
            this.TcKimlikNo = tcKimlikNo;
            this.Adi = adi;
            this.Soyadi = soyadi;
            this.Gorevi = gorevi;
            this.DigerGorevi = digerGorevi;
            this.ImzaYetkisi = imzaYetkisi;
        }

        /// <summary>
        /// Gets or Sets TcKimlikNo
        /// </summary>
        [DataMember(Name = "tcKimlikNo", EmitDefaultValue = true)]
        public string TcKimlikNo { get; set; }

        /// <summary>
        /// Gets or Sets Adi
        /// </summary>
        [DataMember(Name = "adi", EmitDefaultValue = true)]
        public string Adi { get; set; }

        /// <summary>
        /// Gets or Sets Soyadi
        /// </summary>
        [DataMember(Name = "soyadi", EmitDefaultValue = true)]
        public string Soyadi { get; set; }

        /// <summary>
        /// Gets or Sets Gorevi
        /// </summary>
        [DataMember(Name = "gorevi", EmitDefaultValue = false)]
        public int Gorevi { get; set; }

        /// <summary>
        /// Gets or Sets DigerGorevi
        /// </summary>
        [DataMember(Name = "digerGorevi", EmitDefaultValue = true)]
        public string DigerGorevi { get; set; }

        /// <summary>
        /// Gets or Sets ImzaYetkisi
        /// </summary>
        [DataMember(Name = "imzaYetkisi", EmitDefaultValue = true)]
        public string ImzaYetkisi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KKBYoneticiBeanResponse {\n");
            sb.Append("  TcKimlikNo: ").Append(TcKimlikNo).Append("\n");
            sb.Append("  Adi: ").Append(Adi).Append("\n");
            sb.Append("  Soyadi: ").Append(Soyadi).Append("\n");
            sb.Append("  Gorevi: ").Append(Gorevi).Append("\n");
            sb.Append("  DigerGorevi: ").Append(DigerGorevi).Append("\n");
            sb.Append("  ImzaYetkisi: ").Append(ImzaYetkisi).Append("\n");
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
