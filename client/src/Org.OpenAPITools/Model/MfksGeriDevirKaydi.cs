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
    /// MfksGeriDevirKaydi
    /// </summary>
    [DataContract(Name = "MfksGeriDevirKaydi")]
    public partial class MfksGeriDevirKaydi : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksGeriDevirKaydi" /> class.
        /// </summary>
        /// <param name="geriDevirIslemReferansNo">geriDevirIslemReferansNo.</param>
        /// <param name="belgeReferansNo">belgeReferansNo.</param>
        /// <param name="islemTarihi">islemTarihi.</param>
        /// <param name="geriDevirTuru">geriDevirTuru.</param>
        /// <param name="geriDevirDurum">geriDevirDurum.</param>
        /// <param name="geriDevirTutari">geriDevirTutari.</param>
        public MfksGeriDevirKaydi(string geriDevirIslemReferansNo = default(string), string belgeReferansNo = default(string), string islemTarihi = default(string), string geriDevirTuru = default(string), string geriDevirDurum = default(string), double geriDevirTutari = default(double))
        {
            this.GeriDevirIslemReferansNo = geriDevirIslemReferansNo;
            this.BelgeReferansNo = belgeReferansNo;
            this.IslemTarihi = islemTarihi;
            this.GeriDevirTuru = geriDevirTuru;
            this.GeriDevirDurum = geriDevirDurum;
            this.GeriDevirTutari = geriDevirTutari;
        }

        /// <summary>
        /// Gets or Sets GeriDevirIslemReferansNo
        /// </summary>
        [DataMember(Name = "geriDevirIslemReferansNo", EmitDefaultValue = true)]
        public string GeriDevirIslemReferansNo { get; set; }

        /// <summary>
        /// Gets or Sets BelgeReferansNo
        /// </summary>
        [DataMember(Name = "belgeReferansNo", EmitDefaultValue = true)]
        public string BelgeReferansNo { get; set; }

        /// <summary>
        /// Gets or Sets IslemTarihi
        /// </summary>
        [DataMember(Name = "islemTarihi", EmitDefaultValue = true)]
        public string IslemTarihi { get; set; }

        /// <summary>
        /// Gets or Sets GeriDevirTuru
        /// </summary>
        [DataMember(Name = "geriDevirTuru", EmitDefaultValue = true)]
        public string GeriDevirTuru { get; set; }

        /// <summary>
        /// Gets or Sets GeriDevirDurum
        /// </summary>
        [DataMember(Name = "geriDevirDurum", EmitDefaultValue = true)]
        public string GeriDevirDurum { get; set; }

        /// <summary>
        /// Gets or Sets GeriDevirTutari
        /// </summary>
        [DataMember(Name = "geriDevirTutari", EmitDefaultValue = false)]
        public double GeriDevirTutari { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfksGeriDevirKaydi {\n");
            sb.Append("  GeriDevirIslemReferansNo: ").Append(GeriDevirIslemReferansNo).Append("\n");
            sb.Append("  BelgeReferansNo: ").Append(BelgeReferansNo).Append("\n");
            sb.Append("  IslemTarihi: ").Append(IslemTarihi).Append("\n");
            sb.Append("  GeriDevirTuru: ").Append(GeriDevirTuru).Append("\n");
            sb.Append("  GeriDevirDurum: ").Append(GeriDevirDurum).Append("\n");
            sb.Append("  GeriDevirTutari: ").Append(GeriDevirTutari).Append("\n");
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
