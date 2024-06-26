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
    /// AkreditifBean
    /// </summary>
    [DataContract(Name = "akreditifBean")]
    public partial class AkreditifBean : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AkreditifBean" /> class.
        /// </summary>
        /// <param name="teslimTarihiField">teslimTarihiField.</param>
        /// <param name="muhtemelFaturaKesimTarihiField">muhtemelFaturaKesimTarihiField.</param>
        /// <param name="tahsilatBeklentiTarihiField">tahsilatBeklentiTarihiField.</param>
        /// <param name="amirBankaSwiftKoduField">amirBankaSwiftKoduField.</param>
        /// <param name="amirBankaUnvanField">amirBankaUnvanField.</param>
        /// <param name="muhabirBankaSwiftKoduField">muhabirBankaSwiftKoduField.</param>
        /// <param name="muhabirBankaUnvanField">muhabirBankaUnvanField.</param>
        /// <param name="teyitBankaSwiftKoduField">teyitBankaSwiftKoduField.</param>
        /// <param name="teyitBankaUnvanField">teyitBankaUnvanField.</param>
        /// <param name="sonYuklemeTarihiField">sonYuklemeTarihiField.</param>
        public AkreditifBean(string teslimTarihiField = default(string), string muhtemelFaturaKesimTarihiField = default(string), string tahsilatBeklentiTarihiField = default(string), string amirBankaSwiftKoduField = default(string), string amirBankaUnvanField = default(string), string muhabirBankaSwiftKoduField = default(string), string muhabirBankaUnvanField = default(string), string teyitBankaSwiftKoduField = default(string), string teyitBankaUnvanField = default(string), string sonYuklemeTarihiField = default(string))
        {
            this.TeslimTarihiField = teslimTarihiField;
            this.MuhtemelFaturaKesimTarihiField = muhtemelFaturaKesimTarihiField;
            this.TahsilatBeklentiTarihiField = tahsilatBeklentiTarihiField;
            this.AmirBankaSwiftKoduField = amirBankaSwiftKoduField;
            this.AmirBankaUnvanField = amirBankaUnvanField;
            this.MuhabirBankaSwiftKoduField = muhabirBankaSwiftKoduField;
            this.MuhabirBankaUnvanField = muhabirBankaUnvanField;
            this.TeyitBankaSwiftKoduField = teyitBankaSwiftKoduField;
            this.TeyitBankaUnvanField = teyitBankaUnvanField;
            this.SonYuklemeTarihiField = sonYuklemeTarihiField;
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
        /// Gets or Sets AmirBankaSwiftKoduField
        /// </summary>
        [DataMember(Name = "amirBankaSwiftKoduField", EmitDefaultValue = true)]
        public string AmirBankaSwiftKoduField { get; set; }

        /// <summary>
        /// Gets or Sets AmirBankaUnvanField
        /// </summary>
        [DataMember(Name = "amirBankaUnvanField", EmitDefaultValue = true)]
        public string AmirBankaUnvanField { get; set; }

        /// <summary>
        /// Gets or Sets MuhabirBankaSwiftKoduField
        /// </summary>
        [DataMember(Name = "muhabirBankaSwiftKoduField", EmitDefaultValue = true)]
        public string MuhabirBankaSwiftKoduField { get; set; }

        /// <summary>
        /// Gets or Sets MuhabirBankaUnvanField
        /// </summary>
        [DataMember(Name = "muhabirBankaUnvanField", EmitDefaultValue = true)]
        public string MuhabirBankaUnvanField { get; set; }

        /// <summary>
        /// Gets or Sets TeyitBankaSwiftKoduField
        /// </summary>
        [DataMember(Name = "teyitBankaSwiftKoduField", EmitDefaultValue = true)]
        public string TeyitBankaSwiftKoduField { get; set; }

        /// <summary>
        /// Gets or Sets TeyitBankaUnvanField
        /// </summary>
        [DataMember(Name = "teyitBankaUnvanField", EmitDefaultValue = true)]
        public string TeyitBankaUnvanField { get; set; }

        /// <summary>
        /// Gets or Sets SonYuklemeTarihiField
        /// </summary>
        [DataMember(Name = "sonYuklemeTarihiField", EmitDefaultValue = true)]
        public string SonYuklemeTarihiField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AkreditifBean {\n");
            sb.Append("  TeslimTarihiField: ").Append(TeslimTarihiField).Append("\n");
            sb.Append("  MuhtemelFaturaKesimTarihiField: ").Append(MuhtemelFaturaKesimTarihiField).Append("\n");
            sb.Append("  TahsilatBeklentiTarihiField: ").Append(TahsilatBeklentiTarihiField).Append("\n");
            sb.Append("  AmirBankaSwiftKoduField: ").Append(AmirBankaSwiftKoduField).Append("\n");
            sb.Append("  AmirBankaUnvanField: ").Append(AmirBankaUnvanField).Append("\n");
            sb.Append("  MuhabirBankaSwiftKoduField: ").Append(MuhabirBankaSwiftKoduField).Append("\n");
            sb.Append("  MuhabirBankaUnvanField: ").Append(MuhabirBankaUnvanField).Append("\n");
            sb.Append("  TeyitBankaSwiftKoduField: ").Append(TeyitBankaSwiftKoduField).Append("\n");
            sb.Append("  TeyitBankaUnvanField: ").Append(TeyitBankaUnvanField).Append("\n");
            sb.Append("  SonYuklemeTarihiField: ").Append(SonYuklemeTarihiField).Append("\n");
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
