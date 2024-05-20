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
    /// KKBSicilBeanResponse
    /// </summary>
    [DataContract(Name = "KKBSicilBeanResponse")]
    public partial class KKBSicilBeanResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KKBSicilBeanResponse" /> class.
        /// </summary>
        /// <param name="hukukiYapi">hukukiYapi.</param>
        /// <param name="sicilNo">sicilNo.</param>
        /// <param name="sicilNoTam">sicilNoTam.</param>
        /// <param name="mersisNo">mersisNo.</param>
        /// <param name="mersisNoTam">mersisNoTam.</param>
        /// <param name="tescilMerkezi">tescilMerkezi.</param>
        /// <param name="tescilIli">tescilIli.</param>
        /// <param name="kimlikTuru">kimlikTuru.</param>
        /// <param name="kimlikNo">kimlikNo.</param>
        /// <param name="vergiDairesi">vergiDairesi.</param>
        /// <param name="tescilDetayi">tescilDetayi.</param>
        public KKBSicilBeanResponse(int hukukiYapi = default(int), string sicilNo = default(string), string sicilNoTam = default(string), string mersisNo = default(string), string mersisNoTam = default(string), int tescilMerkezi = default(int), int tescilIli = default(int), string kimlikTuru = default(string), string kimlikNo = default(string), string vergiDairesi = default(string), string tescilDetayi = default(string))
        {
            this.HukukiYapi = hukukiYapi;
            this.SicilNo = sicilNo;
            this.SicilNoTam = sicilNoTam;
            this.MersisNo = mersisNo;
            this.MersisNoTam = mersisNoTam;
            this.TescilMerkezi = tescilMerkezi;
            this.TescilIli = tescilIli;
            this.KimlikTuru = kimlikTuru;
            this.KimlikNo = kimlikNo;
            this.VergiDairesi = vergiDairesi;
            this.TescilDetayi = tescilDetayi;
        }

        /// <summary>
        /// Gets or Sets HukukiYapi
        /// </summary>
        [DataMember(Name = "hukukiYapi", EmitDefaultValue = false)]
        public int HukukiYapi { get; set; }

        /// <summary>
        /// Gets or Sets SicilNo
        /// </summary>
        [DataMember(Name = "sicilNo", EmitDefaultValue = true)]
        public string SicilNo { get; set; }

        /// <summary>
        /// Gets or Sets SicilNoTam
        /// </summary>
        [DataMember(Name = "sicilNoTam", EmitDefaultValue = true)]
        public string SicilNoTam { get; set; }

        /// <summary>
        /// Gets or Sets MersisNo
        /// </summary>
        [DataMember(Name = "mersisNo", EmitDefaultValue = true)]
        public string MersisNo { get; set; }

        /// <summary>
        /// Gets or Sets MersisNoTam
        /// </summary>
        [DataMember(Name = "mersisNoTam", EmitDefaultValue = true)]
        public string MersisNoTam { get; set; }

        /// <summary>
        /// Gets or Sets TescilMerkezi
        /// </summary>
        [DataMember(Name = "tescilMerkezi", EmitDefaultValue = false)]
        public int TescilMerkezi { get; set; }

        /// <summary>
        /// Gets or Sets TescilIli
        /// </summary>
        [DataMember(Name = "tescilIli", EmitDefaultValue = false)]
        public int TescilIli { get; set; }

        /// <summary>
        /// Gets or Sets KimlikTuru
        /// </summary>
        [DataMember(Name = "kimlikTuru", EmitDefaultValue = true)]
        public string KimlikTuru { get; set; }

        /// <summary>
        /// Gets or Sets KimlikNo
        /// </summary>
        [DataMember(Name = "kimlikNo", EmitDefaultValue = true)]
        public string KimlikNo { get; set; }

        /// <summary>
        /// Gets or Sets VergiDairesi
        /// </summary>
        [DataMember(Name = "vergiDairesi", EmitDefaultValue = true)]
        public string VergiDairesi { get; set; }

        /// <summary>
        /// Gets or Sets TescilDetayi
        /// </summary>
        [DataMember(Name = "tescilDetayi", EmitDefaultValue = true)]
        public string TescilDetayi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KKBSicilBeanResponse {\n");
            sb.Append("  HukukiYapi: ").Append(HukukiYapi).Append("\n");
            sb.Append("  SicilNo: ").Append(SicilNo).Append("\n");
            sb.Append("  SicilNoTam: ").Append(SicilNoTam).Append("\n");
            sb.Append("  MersisNo: ").Append(MersisNo).Append("\n");
            sb.Append("  MersisNoTam: ").Append(MersisNoTam).Append("\n");
            sb.Append("  TescilMerkezi: ").Append(TescilMerkezi).Append("\n");
            sb.Append("  TescilIli: ").Append(TescilIli).Append("\n");
            sb.Append("  KimlikTuru: ").Append(KimlikTuru).Append("\n");
            sb.Append("  KimlikNo: ").Append(KimlikNo).Append("\n");
            sb.Append("  VergiDairesi: ").Append(VergiDairesi).Append("\n");
            sb.Append("  TescilDetayi: ").Append(TescilDetayi).Append("\n");
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
