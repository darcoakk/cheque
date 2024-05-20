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
    /// SermayeBilgileri
    /// </summary>
    [DataContract(Name = "SermayeBilgileri")]
    public partial class SermayeBilgileri : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SermayeBilgileri" /> class.
        /// </summary>
        /// <param name="islemSonucu">islemSonucu.</param>
        /// <param name="hataAciklama">hataAciklama.</param>
        /// <param name="sermayeListesi">sermayeListesi.</param>
        public SermayeBilgileri(string islemSonucu = default(string), string hataAciklama = default(string), List<SermayeDetay> sermayeListesi = default(List<SermayeDetay>))
        {
            this.IslemSonucu = islemSonucu;
            this.HataAciklama = hataAciklama;
            this.SermayeListesi = sermayeListesi;
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
        /// Gets or Sets SermayeListesi
        /// </summary>
        [DataMember(Name = "sermayeListesi", EmitDefaultValue = true)]
        public List<SermayeDetay> SermayeListesi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SermayeBilgileri {\n");
            sb.Append("  IslemSonucu: ").Append(IslemSonucu).Append("\n");
            sb.Append("  HataAciklama: ").Append(HataAciklama).Append("\n");
            sb.Append("  SermayeListesi: ").Append(SermayeListesi).Append("\n");
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