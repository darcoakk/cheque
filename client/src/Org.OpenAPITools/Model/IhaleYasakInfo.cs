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
    /// IhaleYasakInfo
    /// </summary>
    [DataContract(Name = "IhaleYasakInfo")]
    public partial class IhaleYasakInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IhaleYasakInfo" /> class.
        /// </summary>
        /// <param name="uNVAN">uNVAN.</param>
        /// <param name="rESMIGAZETETARIHI">rESMIGAZETETARIHI.</param>
        /// <param name="rESMIGAZETESAYISI">rESMIGAZETESAYISI.</param>
        /// <param name="iHALEKAYITNO">iHALEKAYITNO.</param>
        /// <param name="yASAKLAMAKARARINIVERENBAKANLIKKURUM">yASAKLAMAKARARINIVERENBAKANLIKKURUM.</param>
        /// <param name="iHALEYIYAPANIDARENINADI">iHALEYIYAPANIDARENINADI.</param>
        /// <param name="yASAKBASLANGICTARIHI">yASAKBASLANGICTARIHI.</param>
        /// <param name="yASAKBITISTARIHI">yASAKBITISTARIHI.</param>
        /// <param name="yASAKSURESI">yASAKSURESI.</param>
        public IhaleYasakInfo(string uNVAN = default(string), string rESMIGAZETETARIHI = default(string), string rESMIGAZETESAYISI = default(string), string iHALEKAYITNO = default(string), string yASAKLAMAKARARINIVERENBAKANLIKKURUM = default(string), string iHALEYIYAPANIDARENINADI = default(string), string yASAKBASLANGICTARIHI = default(string), string yASAKBITISTARIHI = default(string), string yASAKSURESI = default(string))
        {
            this.UNVAN = uNVAN;
            this.RESMIGAZETETARIHI = rESMIGAZETETARIHI;
            this.RESMIGAZETESAYISI = rESMIGAZETESAYISI;
            this.IHALEKAYITNO = iHALEKAYITNO;
            this.YASAKLAMAKARARINIVERENBAKANLIKKURUM = yASAKLAMAKARARINIVERENBAKANLIKKURUM;
            this.IHALEYIYAPANIDARENINADI = iHALEYIYAPANIDARENINADI;
            this.YASAKBASLANGICTARIHI = yASAKBASLANGICTARIHI;
            this.YASAKBITISTARIHI = yASAKBITISTARIHI;
            this.YASAKSURESI = yASAKSURESI;
        }

        /// <summary>
        /// Gets or Sets UNVAN
        /// </summary>
        [DataMember(Name = "UNVAN", EmitDefaultValue = true)]
        public string UNVAN { get; set; }

        /// <summary>
        /// Gets or Sets RESMIGAZETETARIHI
        /// </summary>
        [DataMember(Name = "RESMIGAZETETARIHI", EmitDefaultValue = true)]
        public string RESMIGAZETETARIHI { get; set; }

        /// <summary>
        /// Gets or Sets RESMIGAZETESAYISI
        /// </summary>
        [DataMember(Name = "RESMIGAZETESAYISI", EmitDefaultValue = true)]
        public string RESMIGAZETESAYISI { get; set; }

        /// <summary>
        /// Gets or Sets IHALEKAYITNO
        /// </summary>
        [DataMember(Name = "IHALEKAYITNO", EmitDefaultValue = true)]
        public string IHALEKAYITNO { get; set; }

        /// <summary>
        /// Gets or Sets YASAKLAMAKARARINIVERENBAKANLIKKURUM
        /// </summary>
        [DataMember(Name = "YASAKLAMAKARARINIVERENBAKANLIKKURUM", EmitDefaultValue = true)]
        public string YASAKLAMAKARARINIVERENBAKANLIKKURUM { get; set; }

        /// <summary>
        /// Gets or Sets IHALEYIYAPANIDARENINADI
        /// </summary>
        [DataMember(Name = "IHALEYIYAPANIDARENINADI", EmitDefaultValue = true)]
        public string IHALEYIYAPANIDARENINADI { get; set; }

        /// <summary>
        /// Gets or Sets YASAKBASLANGICTARIHI
        /// </summary>
        [DataMember(Name = "YASAKBASLANGICTARIHI", EmitDefaultValue = true)]
        public string YASAKBASLANGICTARIHI { get; set; }

        /// <summary>
        /// Gets or Sets YASAKBITISTARIHI
        /// </summary>
        [DataMember(Name = "YASAKBITISTARIHI", EmitDefaultValue = true)]
        public string YASAKBITISTARIHI { get; set; }

        /// <summary>
        /// Gets or Sets YASAKSURESI
        /// </summary>
        [DataMember(Name = "YASAKSURESI", EmitDefaultValue = true)]
        public string YASAKSURESI { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IhaleYasakInfo {\n");
            sb.Append("  UNVAN: ").Append(UNVAN).Append("\n");
            sb.Append("  RESMIGAZETETARIHI: ").Append(RESMIGAZETETARIHI).Append("\n");
            sb.Append("  RESMIGAZETESAYISI: ").Append(RESMIGAZETESAYISI).Append("\n");
            sb.Append("  IHALEKAYITNO: ").Append(IHALEKAYITNO).Append("\n");
            sb.Append("  YASAKLAMAKARARINIVERENBAKANLIKKURUM: ").Append(YASAKLAMAKARARINIVERENBAKANLIKKURUM).Append("\n");
            sb.Append("  IHALEYIYAPANIDARENINADI: ").Append(IHALEYIYAPANIDARENINADI).Append("\n");
            sb.Append("  YASAKBASLANGICTARIHI: ").Append(YASAKBASLANGICTARIHI).Append("\n");
            sb.Append("  YASAKBITISTARIHI: ").Append(YASAKBITISTARIHI).Append("\n");
            sb.Append("  YASAKSURESI: ").Append(YASAKSURESI).Append("\n");
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