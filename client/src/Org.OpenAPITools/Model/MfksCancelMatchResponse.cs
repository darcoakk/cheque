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
    /// MfksCancelMatchResponse
    /// </summary>
    [DataContract(Name = "MfksCancelMatchResponse")]
    public partial class MfksCancelMatchResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksCancelMatchResponse" /> class.
        /// </summary>
        /// <param name="islemSonucu">islemSonucu.</param>
        /// <param name="islemSonucuAciklama">islemSonucuAciklama.</param>
        /// <param name="islemReferansNo">islemReferansNo.</param>
        /// <param name="uyariHataListe">uyariHataListe.</param>
        public MfksCancelMatchResponse(string islemSonucu = default(string), string islemSonucuAciklama = default(string), string islemReferansNo = default(string), List<MfksUyariHataParametreEsleme> uyariHataListe = default(List<MfksUyariHataParametreEsleme>))
        {
            this.IslemSonucu = islemSonucu;
            this.IslemSonucuAciklama = islemSonucuAciklama;
            this.IslemReferansNo = islemReferansNo;
            this.UyariHataListe = uyariHataListe;
        }

        /// <summary>
        /// Gets or Sets IslemSonucu
        /// </summary>
        [DataMember(Name = "islemSonucu", EmitDefaultValue = true)]
        public string IslemSonucu { get; set; }

        /// <summary>
        /// Gets or Sets IslemSonucuAciklama
        /// </summary>
        [DataMember(Name = "islemSonucuAciklama", EmitDefaultValue = true)]
        public string IslemSonucuAciklama { get; set; }

        /// <summary>
        /// Gets or Sets IslemReferansNo
        /// </summary>
        [DataMember(Name = "islemReferansNo", EmitDefaultValue = true)]
        public string IslemReferansNo { get; set; }

        /// <summary>
        /// Gets or Sets UyariHataListe
        /// </summary>
        [DataMember(Name = "uyariHataListe", EmitDefaultValue = true)]
        public List<MfksUyariHataParametreEsleme> UyariHataListe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfksCancelMatchResponse {\n");
            sb.Append("  IslemSonucu: ").Append(IslemSonucu).Append("\n");
            sb.Append("  IslemSonucuAciklama: ").Append(IslemSonucuAciklama).Append("\n");
            sb.Append("  IslemReferansNo: ").Append(IslemReferansNo).Append("\n");
            sb.Append("  UyariHataListe: ").Append(UyariHataListe).Append("\n");
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
