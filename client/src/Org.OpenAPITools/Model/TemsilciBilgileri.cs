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
    /// TemsilciBilgileri
    /// </summary>
    [DataContract(Name = "TemsilciBilgileri")]
    public partial class TemsilciBilgileri : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemsilciBilgileri" /> class.
        /// </summary>
        /// <param name="islemSonucu">islemSonucu.</param>
        /// <param name="hataAciklama">hataAciklama.</param>
        /// <param name="temsilciListesi">temsilciListesi.</param>
        public TemsilciBilgileri(string islemSonucu = default(string), string hataAciklama = default(string), List<TemsilciDetay> temsilciListesi = default(List<TemsilciDetay>))
        {
            this.IslemSonucu = islemSonucu;
            this.HataAciklama = hataAciklama;
            this.TemsilciListesi = temsilciListesi;
        }

        /// <summary>
        /// Gets or Sets IslemSonucu
        /// </summary>
        [DataMember(Name = "islemSonucu", EmitDefaultValue = true)]
        public string IslemSonucu { get; set; }

        /// <summary>
        /// Gets or Sets HataAciklama
        /// </summary>
        [DataMember(Name = "hataAciklama", EmitDefaultValue = true)]
        public string HataAciklama { get; set; }

        /// <summary>
        /// Gets or Sets TemsilciListesi
        /// </summary>
        [DataMember(Name = "temsilciListesi", EmitDefaultValue = true)]
        public List<TemsilciDetay> TemsilciListesi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemsilciBilgileri {\n");
            sb.Append("  IslemSonucu: ").Append(IslemSonucu).Append("\n");
            sb.Append("  HataAciklama: ").Append(HataAciklama).Append("\n");
            sb.Append("  TemsilciListesi: ").Append(TemsilciListesi).Append("\n");
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