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
    /// ProformaFaturaBean
    /// </summary>
    [DataContract(Name = "proformaFaturaBean")]
    public partial class ProformaFaturaBean : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaFaturaBean" /> class.
        /// </summary>
        /// <param name="odemeSartlariField">odemeSartlariField.</param>
        /// <param name="teslimTarihiField">teslimTarihiField.</param>
        /// <param name="muhtemelFaturaKesimTarihiField">muhtemelFaturaKesimTarihiField.</param>
        /// <param name="tahsilatBeklentiTarihiField">tahsilatBeklentiTarihiField.</param>
        public ProformaFaturaBean(string odemeSartlariField = default(string), string teslimTarihiField = default(string), string muhtemelFaturaKesimTarihiField = default(string), string tahsilatBeklentiTarihiField = default(string))
        {
            this.OdemeSartlariField = odemeSartlariField;
            this.TeslimTarihiField = teslimTarihiField;
            this.MuhtemelFaturaKesimTarihiField = muhtemelFaturaKesimTarihiField;
            this.TahsilatBeklentiTarihiField = tahsilatBeklentiTarihiField;
        }

        /// <summary>
        /// Gets or Sets OdemeSartlariField
        /// </summary>
        [DataMember(Name = "odemeSartlariField", EmitDefaultValue = true)]
        public string OdemeSartlariField { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProformaFaturaBean {\n");
            sb.Append("  OdemeSartlariField: ").Append(OdemeSartlariField).Append("\n");
            sb.Append("  TeslimTarihiField: ").Append(TeslimTarihiField).Append("\n");
            sb.Append("  MuhtemelFaturaKesimTarihiField: ").Append(MuhtemelFaturaKesimTarihiField).Append("\n");
            sb.Append("  TahsilatBeklentiTarihiField: ").Append(TahsilatBeklentiTarihiField).Append("\n");
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
