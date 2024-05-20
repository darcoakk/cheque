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
    /// MfksSatisSozlesmesiBean
    /// </summary>
    [DataContract(Name = "MfksSatisSozlesmesiBean")]
    public partial class MfksSatisSozlesmesiBean : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksSatisSozlesmesiBean" /> class.
        /// </summary>
        /// <param name="teslimTarihi">teslimTarihi.</param>
        /// <param name="muhtemelFaturaKesimTarihi">muhtemelFaturaKesimTarihi.</param>
        /// <param name="tahsilatBeklentiTarihi">tahsilatBeklentiTarihi.</param>
        /// <param name="devirKonusu">devirKonusu.</param>
        /// <param name="sozlesmeSuresi">sozlesmeSuresi.</param>
        public MfksSatisSozlesmesiBean(string teslimTarihi = default(string), string muhtemelFaturaKesimTarihi = default(string), string tahsilatBeklentiTarihi = default(string), string devirKonusu = default(string), int sozlesmeSuresi = default(int))
        {
            this.TeslimTarihi = teslimTarihi;
            this.MuhtemelFaturaKesimTarihi = muhtemelFaturaKesimTarihi;
            this.TahsilatBeklentiTarihi = tahsilatBeklentiTarihi;
            this.DevirKonusu = devirKonusu;
            this.SozlesmeSuresi = sozlesmeSuresi;
        }

        /// <summary>
        /// Gets or Sets TeslimTarihi
        /// </summary>
        [DataMember(Name = "teslimTarihi", EmitDefaultValue = true)]
        public string TeslimTarihi { get; set; }

        /// <summary>
        /// Gets or Sets MuhtemelFaturaKesimTarihi
        /// </summary>
        [DataMember(Name = "muhtemelFaturaKesimTarihi", EmitDefaultValue = true)]
        public string MuhtemelFaturaKesimTarihi { get; set; }

        /// <summary>
        /// Gets or Sets TahsilatBeklentiTarihi
        /// </summary>
        [DataMember(Name = "tahsilatBeklentiTarihi", EmitDefaultValue = true)]
        public string TahsilatBeklentiTarihi { get; set; }

        /// <summary>
        /// Gets or Sets DevirKonusu
        /// </summary>
        [DataMember(Name = "devirKonusu", EmitDefaultValue = true)]
        public string DevirKonusu { get; set; }

        /// <summary>
        /// Gets or Sets SozlesmeSuresi
        /// </summary>
        [DataMember(Name = "sozlesmeSuresi", EmitDefaultValue = false)]
        public int SozlesmeSuresi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfksSatisSozlesmesiBean {\n");
            sb.Append("  TeslimTarihi: ").Append(TeslimTarihi).Append("\n");
            sb.Append("  MuhtemelFaturaKesimTarihi: ").Append(MuhtemelFaturaKesimTarihi).Append("\n");
            sb.Append("  TahsilatBeklentiTarihi: ").Append(TahsilatBeklentiTarihi).Append("\n");
            sb.Append("  DevirKonusu: ").Append(DevirKonusu).Append("\n");
            sb.Append("  SozlesmeSuresi: ").Append(SozlesmeSuresi).Append("\n");
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
