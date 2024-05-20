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
    /// KKBSermayeBeanResponse
    /// </summary>
    [DataContract(Name = "KKBSermayeBeanResponse")]
    public partial class KKBSermayeBeanResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KKBSermayeBeanResponse" /> class.
        /// </summary>
        /// <param name="sermayeTutari">sermayeTutari.</param>
        /// <param name="dovizCinsi">dovizCinsi.</param>
        /// <param name="eskiSermayeTutari">eskiSermayeTutari.</param>
        /// <param name="sermayeArttirimTarihi">sermayeArttirimTarihi.</param>
        /// <param name="sonToplantiTarihi">sonToplantiTarihi.</param>
        public KKBSermayeBeanResponse(double sermayeTutari = default(double), int dovizCinsi = default(int), double eskiSermayeTutari = default(double), string sermayeArttirimTarihi = default(string), string sonToplantiTarihi = default(string))
        {
            this.SermayeTutari = sermayeTutari;
            this.DovizCinsi = dovizCinsi;
            this.EskiSermayeTutari = eskiSermayeTutari;
            this.SermayeArttirimTarihi = sermayeArttirimTarihi;
            this.SonToplantiTarihi = sonToplantiTarihi;
        }

        /// <summary>
        /// Gets or Sets SermayeTutari
        /// </summary>
        [DataMember(Name = "sermayeTutari", EmitDefaultValue = false)]
        public double SermayeTutari { get; set; }

        /// <summary>
        /// Gets or Sets DovizCinsi
        /// </summary>
        [DataMember(Name = "dovizCinsi", EmitDefaultValue = false)]
        public int DovizCinsi { get; set; }

        /// <summary>
        /// Gets or Sets EskiSermayeTutari
        /// </summary>
        [DataMember(Name = "eskiSermayeTutari", EmitDefaultValue = false)]
        public double EskiSermayeTutari { get; set; }

        /// <summary>
        /// Gets or Sets SermayeArttirimTarihi
        /// </summary>
        [DataMember(Name = "sermayeArttirimTarihi", EmitDefaultValue = true)]
        public string SermayeArttirimTarihi { get; set; }

        /// <summary>
        /// Gets or Sets SonToplantiTarihi
        /// </summary>
        [DataMember(Name = "sonToplantiTarihi", EmitDefaultValue = true)]
        public string SonToplantiTarihi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KKBSermayeBeanResponse {\n");
            sb.Append("  SermayeTutari: ").Append(SermayeTutari).Append("\n");
            sb.Append("  DovizCinsi: ").Append(DovizCinsi).Append("\n");
            sb.Append("  EskiSermayeTutari: ").Append(EskiSermayeTutari).Append("\n");
            sb.Append("  SermayeArttirimTarihi: ").Append(SermayeArttirimTarihi).Append("\n");
            sb.Append("  SonToplantiTarihi: ").Append(SonToplantiTarihi).Append("\n");
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