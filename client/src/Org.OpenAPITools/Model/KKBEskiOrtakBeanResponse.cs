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
    /// KKBEskiOrtakBeanResponse
    /// </summary>
    [DataContract(Name = "KKBEskiOrtakBeanResponse")]
    public partial class KKBEskiOrtakBeanResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KKBEskiOrtakBeanResponse" /> class.
        /// </summary>
        /// <param name="tcKimlikNo">tcKimlikNo.</param>
        /// <param name="vergiNo">vergiNo.</param>
        /// <param name="unvan">unvan.</param>
        /// <param name="ayrilmaTarihi">ayrilmaTarihi.</param>
        /// <param name="vefatDurumu">vefatDurumu.</param>
        public KKBEskiOrtakBeanResponse(string tcKimlikNo = default(string), string vergiNo = default(string), string unvan = default(string), string ayrilmaTarihi = default(string), string vefatDurumu = default(string))
        {
            this.TcKimlikNo = tcKimlikNo;
            this.VergiNo = vergiNo;
            this.Unvan = unvan;
            this.AyrilmaTarihi = ayrilmaTarihi;
            this.VefatDurumu = vefatDurumu;
        }

        /// <summary>
        /// Gets or Sets TcKimlikNo
        /// </summary>
        [DataMember(Name = "tcKimlikNo", EmitDefaultValue = true)]
        public string TcKimlikNo { get; set; }

        /// <summary>
        /// Gets or Sets VergiNo
        /// </summary>
        [DataMember(Name = "vergiNo", EmitDefaultValue = true)]
        public string VergiNo { get; set; }

        /// <summary>
        /// Gets or Sets Unvan
        /// </summary>
        [DataMember(Name = "unvan", EmitDefaultValue = true)]
        public string Unvan { get; set; }

        /// <summary>
        /// Gets or Sets AyrilmaTarihi
        /// </summary>
        [DataMember(Name = "ayrilmaTarihi", EmitDefaultValue = true)]
        public string AyrilmaTarihi { get; set; }

        /// <summary>
        /// Gets or Sets VefatDurumu
        /// </summary>
        [DataMember(Name = "vefatDurumu", EmitDefaultValue = true)]
        public string VefatDurumu { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KKBEskiOrtakBeanResponse {\n");
            sb.Append("  TcKimlikNo: ").Append(TcKimlikNo).Append("\n");
            sb.Append("  VergiNo: ").Append(VergiNo).Append("\n");
            sb.Append("  Unvan: ").Append(Unvan).Append("\n");
            sb.Append("  AyrilmaTarihi: ").Append(AyrilmaTarihi).Append("\n");
            sb.Append("  VefatDurumu: ").Append(VefatDurumu).Append("\n");
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
