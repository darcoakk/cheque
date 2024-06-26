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
    /// KapaliKrediData
    /// </summary>
    [DataContract(Name = "KapaliKrediData")]
    public partial class KapaliKrediData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KapaliKrediData" /> class.
        /// </summary>
        /// <param name="kredituru">kredituru.</param>
        /// <param name="toplamlimit">toplamlimit.</param>
        /// <param name="toplamrisk">toplamrisk.</param>
        /// <param name="gecikmeliHesSayi">gecikmeliHesSayi.</param>
        /// <param name="maxgecikmedonemi">maxgecikmedonemi.</param>
        /// <param name="ggb">ggb.</param>
        /// <param name="gunlukggb">gunlukggb.</param>
        /// <param name="idaritakipadet">idaritakipadet.</param>
        /// <param name="kanunitakipadet">kanunitakipadet.</param>
        public KapaliKrediData(string kredituru = default(string), string toplamlimit = default(string), string toplamrisk = default(string), string gecikmeliHesSayi = default(string), string maxgecikmedonemi = default(string), string ggb = default(string), string gunlukggb = default(string), string idaritakipadet = default(string), string kanunitakipadet = default(string))
        {
            this.Kredituru = kredituru;
            this.Toplamlimit = toplamlimit;
            this.Toplamrisk = toplamrisk;
            this.GecikmeliHesSayi = gecikmeliHesSayi;
            this.Maxgecikmedonemi = maxgecikmedonemi;
            this.Ggb = ggb;
            this.Gunlukggb = gunlukggb;
            this.Idaritakipadet = idaritakipadet;
            this.Kanunitakipadet = kanunitakipadet;
        }

        /// <summary>
        /// Gets or Sets Kredituru
        /// </summary>
        [DataMember(Name = "kredituru", EmitDefaultValue = true)]
        public string Kredituru { get; set; }

        /// <summary>
        /// Gets or Sets Toplamlimit
        /// </summary>
        [DataMember(Name = "toplamlimit", EmitDefaultValue = true)]
        public string Toplamlimit { get; set; }

        /// <summary>
        /// Gets or Sets Toplamrisk
        /// </summary>
        [DataMember(Name = "toplamrisk", EmitDefaultValue = true)]
        public string Toplamrisk { get; set; }

        /// <summary>
        /// Gets or Sets GecikmeliHesSayi
        /// </summary>
        [DataMember(Name = "gecikmeliHesSayi", EmitDefaultValue = true)]
        public string GecikmeliHesSayi { get; set; }

        /// <summary>
        /// Gets or Sets Maxgecikmedonemi
        /// </summary>
        [DataMember(Name = "maxgecikmedonemi", EmitDefaultValue = true)]
        public string Maxgecikmedonemi { get; set; }

        /// <summary>
        /// Gets or Sets Ggb
        /// </summary>
        [DataMember(Name = "ggb", EmitDefaultValue = true)]
        public string Ggb { get; set; }

        /// <summary>
        /// Gets or Sets Gunlukggb
        /// </summary>
        [DataMember(Name = "gunlukggb", EmitDefaultValue = true)]
        public string Gunlukggb { get; set; }

        /// <summary>
        /// Gets or Sets Idaritakipadet
        /// </summary>
        [DataMember(Name = "idaritakipadet", EmitDefaultValue = true)]
        public string Idaritakipadet { get; set; }

        /// <summary>
        /// Gets or Sets Kanunitakipadet
        /// </summary>
        [DataMember(Name = "kanunitakipadet", EmitDefaultValue = true)]
        public string Kanunitakipadet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KapaliKrediData {\n");
            sb.Append("  Kredituru: ").Append(Kredituru).Append("\n");
            sb.Append("  Toplamlimit: ").Append(Toplamlimit).Append("\n");
            sb.Append("  Toplamrisk: ").Append(Toplamrisk).Append("\n");
            sb.Append("  GecikmeliHesSayi: ").Append(GecikmeliHesSayi).Append("\n");
            sb.Append("  Maxgecikmedonemi: ").Append(Maxgecikmedonemi).Append("\n");
            sb.Append("  Ggb: ").Append(Ggb).Append("\n");
            sb.Append("  Gunlukggb: ").Append(Gunlukggb).Append("\n");
            sb.Append("  Idaritakipadet: ").Append(Idaritakipadet).Append("\n");
            sb.Append("  Kanunitakipadet: ").Append(Kanunitakipadet).Append("\n");
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
