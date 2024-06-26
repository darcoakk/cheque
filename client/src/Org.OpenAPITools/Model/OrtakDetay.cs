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
    /// OrtakDetay
    /// </summary>
    [DataContract(Name = "OrtakDetay")]
    public partial class OrtakDetay : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrtakDetay" /> class.
        /// </summary>
        /// <param name="adiSoyadi">adiSoyadi.</param>
        /// <param name="ortaklikTipi">ortaklikTipi.</param>
        /// <param name="uyrugu">uyrugu.</param>
        /// <param name="tcKimlikNoMersisNo">tcKimlikNoMersisNo.</param>
        /// <param name="pasaportNo">pasaportNo.</param>
        /// <param name="vergiNo">vergiNo.</param>
        /// <param name="baslangicTarihi">baslangicTarihi.</param>
        /// <param name="bitisTarihi">bitisTarihi.</param>
        public OrtakDetay(string adiSoyadi = default(string), string ortaklikTipi = default(string), string uyrugu = default(string), string tcKimlikNoMersisNo = default(string), string pasaportNo = default(string), string vergiNo = default(string), string baslangicTarihi = default(string), string bitisTarihi = default(string))
        {
            this.AdiSoyadi = adiSoyadi;
            this.OrtaklikTipi = ortaklikTipi;
            this.Uyrugu = uyrugu;
            this.TcKimlikNoMersisNo = tcKimlikNoMersisNo;
            this.PasaportNo = pasaportNo;
            this.VergiNo = vergiNo;
            this.BaslangicTarihi = baslangicTarihi;
            this.BitisTarihi = bitisTarihi;
        }

        /// <summary>
        /// Gets or Sets AdiSoyadi
        /// </summary>
        [DataMember(Name = "adiSoyadi", EmitDefaultValue = true)]
        public string AdiSoyadi { get; set; }

        /// <summary>
        /// Gets or Sets OrtaklikTipi
        /// </summary>
        [DataMember(Name = "ortaklikTipi", EmitDefaultValue = true)]
        public string OrtaklikTipi { get; set; }

        /// <summary>
        /// Gets or Sets Uyrugu
        /// </summary>
        [DataMember(Name = "uyrugu", EmitDefaultValue = true)]
        public string Uyrugu { get; set; }

        /// <summary>
        /// Gets or Sets TcKimlikNoMersisNo
        /// </summary>
        [DataMember(Name = "tcKimlikNoMersisNo", EmitDefaultValue = true)]
        public string TcKimlikNoMersisNo { get; set; }

        /// <summary>
        /// Gets or Sets PasaportNo
        /// </summary>
        [DataMember(Name = "pasaportNo", EmitDefaultValue = true)]
        public string PasaportNo { get; set; }

        /// <summary>
        /// Gets or Sets VergiNo
        /// </summary>
        [DataMember(Name = "vergiNo", EmitDefaultValue = true)]
        public string VergiNo { get; set; }

        /// <summary>
        /// Gets or Sets BaslangicTarihi
        /// </summary>
        [DataMember(Name = "baslangicTarihi", EmitDefaultValue = true)]
        public string BaslangicTarihi { get; set; }

        /// <summary>
        /// Gets or Sets BitisTarihi
        /// </summary>
        [DataMember(Name = "bitisTarihi", EmitDefaultValue = true)]
        public string BitisTarihi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrtakDetay {\n");
            sb.Append("  AdiSoyadi: ").Append(AdiSoyadi).Append("\n");
            sb.Append("  OrtaklikTipi: ").Append(OrtaklikTipi).Append("\n");
            sb.Append("  Uyrugu: ").Append(Uyrugu).Append("\n");
            sb.Append("  TcKimlikNoMersisNo: ").Append(TcKimlikNoMersisNo).Append("\n");
            sb.Append("  PasaportNo: ").Append(PasaportNo).Append("\n");
            sb.Append("  VergiNo: ").Append(VergiNo).Append("\n");
            sb.Append("  BaslangicTarihi: ").Append(BaslangicTarihi).Append("\n");
            sb.Append("  BitisTarihi: ").Append(BitisTarihi).Append("\n");
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
