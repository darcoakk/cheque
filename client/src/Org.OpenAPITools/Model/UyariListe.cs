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
    /// UyariListe
    /// </summary>
    [DataContract(Name = "UyariListe")]
    public partial class UyariListe : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UyariListe" /> class.
        /// </summary>
        /// <param name="uyariHataKod">uyariHataKod.</param>
        /// <param name="uyariHataKodAciklama">uyariHataKodAciklama.</param>
        /// <param name="fazlaTutar">fazlaTutar.</param>
        public UyariListe(string uyariHataKod = default(string), string uyariHataKodAciklama = default(string), double fazlaTutar = default(double))
        {
            this.UyariHataKod = uyariHataKod;
            this.UyariHataKodAciklama = uyariHataKodAciklama;
            this.FazlaTutar = fazlaTutar;
        }

        /// <summary>
        /// Gets or Sets UyariHataKod
        /// </summary>
        [DataMember(Name = "uyariHataKod", EmitDefaultValue = true)]
        public string UyariHataKod { get; set; }

        /// <summary>
        /// Gets or Sets UyariHataKodAciklama
        /// </summary>
        [DataMember(Name = "uyariHataKodAciklama", EmitDefaultValue = true)]
        public string UyariHataKodAciklama { get; set; }

        /// <summary>
        /// Gets or Sets FazlaTutar
        /// </summary>
        [DataMember(Name = "fazlaTutar", EmitDefaultValue = false)]
        public double FazlaTutar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UyariListe {\n");
            sb.Append("  UyariHataKod: ").Append(UyariHataKod).Append("\n");
            sb.Append("  UyariHataKodAciklama: ").Append(UyariHataKodAciklama).Append("\n");
            sb.Append("  FazlaTutar: ").Append(FazlaTutar).Append("\n");
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