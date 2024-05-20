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
    /// KarsiliksizCekResponse
    /// </summary>
    [DataContract(Name = "karsiliksizCekResponse")]
    public partial class KarsiliksizCekResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KarsiliksizCekResponse" /> class.
        /// </summary>
        /// <param name="kurumAdi">kurumAdi.</param>
        /// <param name="subeAdi">subeAdi.</param>
        /// <param name="siraNo">siraNo.</param>
        /// <param name="ibrazTarihi">ibrazTarihi.</param>
        /// <param name="tutar">tutar.</param>
        /// <param name="odemeTuru">odemeTuru.</param>
        /// <param name="durumKodu">durumKodu.</param>
        /// <param name="odemeTarihi">odemeTarihi.</param>
        public KarsiliksizCekResponse(string kurumAdi = default(string), string subeAdi = default(string), string siraNo = default(string), string ibrazTarihi = default(string), double tutar = default(double), string odemeTuru = default(string), string durumKodu = default(string), string odemeTarihi = default(string))
        {
            this.KurumAdi = kurumAdi;
            this.SubeAdi = subeAdi;
            this.SiraNo = siraNo;
            this.IbrazTarihi = ibrazTarihi;
            this.Tutar = tutar;
            this.OdemeTuru = odemeTuru;
            this.DurumKodu = durumKodu;
            this.OdemeTarihi = odemeTarihi;
        }

        /// <summary>
        /// Gets or Sets KurumAdi
        /// </summary>
        [DataMember(Name = "kurumAdi", EmitDefaultValue = true)]
        public string KurumAdi { get; set; }

        /// <summary>
        /// Gets or Sets SubeAdi
        /// </summary>
        [DataMember(Name = "subeAdi", EmitDefaultValue = true)]
        public string SubeAdi { get; set; }

        /// <summary>
        /// Gets or Sets SiraNo
        /// </summary>
        [DataMember(Name = "siraNo", EmitDefaultValue = true)]
        public string SiraNo { get; set; }

        /// <summary>
        /// Gets or Sets IbrazTarihi
        /// </summary>
        [DataMember(Name = "ibrazTarihi", EmitDefaultValue = true)]
        public string IbrazTarihi { get; set; }

        /// <summary>
        /// Gets or Sets Tutar
        /// </summary>
        [DataMember(Name = "tutar", EmitDefaultValue = false)]
        public double Tutar { get; set; }

        /// <summary>
        /// Gets or Sets OdemeTuru
        /// </summary>
        [DataMember(Name = "odemeTuru", EmitDefaultValue = true)]
        public string OdemeTuru { get; set; }

        /// <summary>
        /// Gets or Sets DurumKodu
        /// </summary>
        [DataMember(Name = "durumKodu", EmitDefaultValue = true)]
        public string DurumKodu { get; set; }

        /// <summary>
        /// Gets or Sets OdemeTarihi
        /// </summary>
        [DataMember(Name = "odemeTarihi", EmitDefaultValue = true)]
        public string OdemeTarihi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KarsiliksizCekResponse {\n");
            sb.Append("  KurumAdi: ").Append(KurumAdi).Append("\n");
            sb.Append("  SubeAdi: ").Append(SubeAdi).Append("\n");
            sb.Append("  SiraNo: ").Append(SiraNo).Append("\n");
            sb.Append("  IbrazTarihi: ").Append(IbrazTarihi).Append("\n");
            sb.Append("  Tutar: ").Append(Tutar).Append("\n");
            sb.Append("  OdemeTuru: ").Append(OdemeTuru).Append("\n");
            sb.Append("  DurumKodu: ").Append(DurumKodu).Append("\n");
            sb.Append("  OdemeTarihi: ").Append(OdemeTarihi).Append("\n");
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
