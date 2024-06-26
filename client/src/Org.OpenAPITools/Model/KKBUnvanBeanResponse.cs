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
    /// KKBUnvanBeanResponse
    /// </summary>
    [DataContract(Name = "KKBUnvanBeanResponse")]
    public partial class KKBUnvanBeanResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KKBUnvanBeanResponse" /> class.
        /// </summary>
        /// <param name="eskiUnvan">eskiUnvan.</param>
        /// <param name="unvanDegisimTarihi">unvanDegisimTarihi.</param>
        /// <param name="eskiTescilIli">eskiTescilIli.</param>
        /// <param name="eskiSicilNo">eskiSicilNo.</param>
        /// <param name="eskiTescilMerkezi">eskiTescilMerkezi.</param>
        /// <param name="sicilDegisimTarihi">sicilDegisimTarihi.</param>
        /// <param name="yeniHukukYapisi">yeniHukukYapisi.</param>
        /// <param name="hukukYapisiDegismTarhi">hukukYapisiDegismTarhi.</param>
        public KKBUnvanBeanResponse(string eskiUnvan = default(string), string unvanDegisimTarihi = default(string), int eskiTescilIli = default(int), string eskiSicilNo = default(string), string eskiTescilMerkezi = default(string), string sicilDegisimTarihi = default(string), int yeniHukukYapisi = default(int), int hukukYapisiDegismTarhi = default(int))
        {
            this.EskiUnvan = eskiUnvan;
            this.UnvanDegisimTarihi = unvanDegisimTarihi;
            this.EskiTescilIli = eskiTescilIli;
            this.EskiSicilNo = eskiSicilNo;
            this.EskiTescilMerkezi = eskiTescilMerkezi;
            this.SicilDegisimTarihi = sicilDegisimTarihi;
            this.YeniHukukYapisi = yeniHukukYapisi;
            this.HukukYapisiDegismTarhi = hukukYapisiDegismTarhi;
        }

        /// <summary>
        /// Gets or Sets EskiUnvan
        /// </summary>
        [DataMember(Name = "eskiUnvan", EmitDefaultValue = true)]
        public string EskiUnvan { get; set; }

        /// <summary>
        /// Gets or Sets UnvanDegisimTarihi
        /// </summary>
        [DataMember(Name = "unvanDegisimTarihi", EmitDefaultValue = true)]
        public string UnvanDegisimTarihi { get; set; }

        /// <summary>
        /// Gets or Sets EskiTescilIli
        /// </summary>
        [DataMember(Name = "eskiTescilIli", EmitDefaultValue = false)]
        public int EskiTescilIli { get; set; }

        /// <summary>
        /// Gets or Sets EskiSicilNo
        /// </summary>
        [DataMember(Name = "eskiSicilNo", EmitDefaultValue = true)]
        public string EskiSicilNo { get; set; }

        /// <summary>
        /// Gets or Sets EskiTescilMerkezi
        /// </summary>
        [DataMember(Name = "eskiTescilMerkezi", EmitDefaultValue = true)]
        public string EskiTescilMerkezi { get; set; }

        /// <summary>
        /// Gets or Sets SicilDegisimTarihi
        /// </summary>
        [DataMember(Name = "sicilDegisimTarihi", EmitDefaultValue = true)]
        public string SicilDegisimTarihi { get; set; }

        /// <summary>
        /// Gets or Sets YeniHukukYapisi
        /// </summary>
        [DataMember(Name = "yeniHukukYapisi", EmitDefaultValue = false)]
        public int YeniHukukYapisi { get; set; }

        /// <summary>
        /// Gets or Sets HukukYapisiDegismTarhi
        /// </summary>
        [DataMember(Name = "hukukYapisiDegismTarhi", EmitDefaultValue = false)]
        public int HukukYapisiDegismTarhi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KKBUnvanBeanResponse {\n");
            sb.Append("  EskiUnvan: ").Append(EskiUnvan).Append("\n");
            sb.Append("  UnvanDegisimTarihi: ").Append(UnvanDegisimTarihi).Append("\n");
            sb.Append("  EskiTescilIli: ").Append(EskiTescilIli).Append("\n");
            sb.Append("  EskiSicilNo: ").Append(EskiSicilNo).Append("\n");
            sb.Append("  EskiTescilMerkezi: ").Append(EskiTescilMerkezi).Append("\n");
            sb.Append("  SicilDegisimTarihi: ").Append(SicilDegisimTarihi).Append("\n");
            sb.Append("  YeniHukukYapisi: ").Append(YeniHukukYapisi).Append("\n");
            sb.Append("  HukukYapisiDegismTarhi: ").Append(HukukYapisiDegismTarhi).Append("\n");
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
