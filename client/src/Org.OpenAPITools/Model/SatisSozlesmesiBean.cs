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
    /// SatisSozlesmesiBean
    /// </summary>
    [DataContract(Name = "satisSozlesmesiBean")]
    public partial class SatisSozlesmesiBean : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SatisSozlesmesiBean" /> class.
        /// </summary>
        /// <param name="teslimTarihiField">teslimTarihiField.</param>
        /// <param name="muhtemelFaturaKesimTarihiField">muhtemelFaturaKesimTarihiField.</param>
        /// <param name="tahsilatBeklentiTarihiField">tahsilatBeklentiTarihiField.</param>
        /// <param name="devirKonusuField">devirKonusuField.</param>
        /// <param name="sozlesmeSuresiField">sozlesmeSuresiField.</param>
        public SatisSozlesmesiBean(string teslimTarihiField = default(string), string muhtemelFaturaKesimTarihiField = default(string), string tahsilatBeklentiTarihiField = default(string), string devirKonusuField = default(string), int sozlesmeSuresiField = default(int))
        {
            this.TeslimTarihiField = teslimTarihiField;
            this.MuhtemelFaturaKesimTarihiField = muhtemelFaturaKesimTarihiField;
            this.TahsilatBeklentiTarihiField = tahsilatBeklentiTarihiField;
            this.DevirKonusuField = devirKonusuField;
            this.SozlesmeSuresiField = sozlesmeSuresiField;
        }

        /// <summary>
        /// Gets or Sets TeslimTarihiField
        /// </summary>
        [DataMember(Name = "teslimTarihiField", EmitDefaultValue = true)]
        public string TeslimTarihiField { get; set; }

        /// <summary>
        /// Gets or Sets MuhtemelFaturaKesimTarihiField
        /// </summary>
        [DataMember(Name = "muhtemelFaturaKesimTarihiField", EmitDefaultValue = true)]
        public string MuhtemelFaturaKesimTarihiField { get; set; }

        /// <summary>
        /// Gets or Sets TahsilatBeklentiTarihiField
        /// </summary>
        [DataMember(Name = "tahsilatBeklentiTarihiField", EmitDefaultValue = true)]
        public string TahsilatBeklentiTarihiField { get; set; }

        /// <summary>
        /// Gets or Sets DevirKonusuField
        /// </summary>
        [DataMember(Name = "devirKonusuField", EmitDefaultValue = true)]
        public string DevirKonusuField { get; set; }

        /// <summary>
        /// Gets or Sets SozlesmeSuresiField
        /// </summary>
        [DataMember(Name = "sozlesmeSuresiField", EmitDefaultValue = false)]
        public int SozlesmeSuresiField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SatisSozlesmesiBean {\n");
            sb.Append("  TeslimTarihiField: ").Append(TeslimTarihiField).Append("\n");
            sb.Append("  MuhtemelFaturaKesimTarihiField: ").Append(MuhtemelFaturaKesimTarihiField).Append("\n");
            sb.Append("  TahsilatBeklentiTarihiField: ").Append(TahsilatBeklentiTarihiField).Append("\n");
            sb.Append("  DevirKonusuField: ").Append(DevirKonusuField).Append("\n");
            sb.Append("  SozlesmeSuresiField: ").Append(SozlesmeSuresiField).Append("\n");
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
