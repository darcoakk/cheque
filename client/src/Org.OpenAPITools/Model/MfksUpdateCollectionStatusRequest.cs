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
    /// MfksUpdateCollectionStatusRequest
    /// </summary>
    [DataContract(Name = "MfksUpdateCollectionStatusRequest")]
    public partial class MfksUpdateCollectionStatusRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksUpdateCollectionStatusRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MfksUpdateCollectionStatusRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksUpdateCollectionStatusRequest" /> class.
        /// </summary>
        /// <param name="kullaniciSicili">kullaniciSicili (required).</param>
        /// <param name="odemeAraciReferansNo">odemeAraciReferansNo.</param>
        /// <param name="acikHesapReferansNo">acikHesapReferansNo.</param>
        /// <param name="odemeAraciTipi">odemeAraciTipi.</param>
        /// <param name="tahsilatTarihi">tahsilatTarihi.</param>
        /// <param name="tahsilatDurumu">tahsilatDurumu.</param>
        /// <param name="tahsilatAlinanKimlikTip">tahsilatAlinanKimlikTip.</param>
        /// <param name="tahsilatAlinanKimlikNo">tahsilatAlinanKimlikNo.</param>
        /// <param name="tahsilatAlinanUnvan">tahsilatAlinanUnvan.</param>
        public MfksUpdateCollectionStatusRequest(string kullaniciSicili = default(string), string odemeAraciReferansNo = default(string), string acikHesapReferansNo = default(string), string odemeAraciTipi = default(string), string tahsilatTarihi = default(string), string tahsilatDurumu = default(string), string tahsilatAlinanKimlikTip = default(string), string tahsilatAlinanKimlikNo = default(string), string tahsilatAlinanUnvan = default(string))
        {
            // to ensure "kullaniciSicili" is required (not null)
            if (kullaniciSicili == null)
            {
                throw new ArgumentNullException("kullaniciSicili is a required property for MfksUpdateCollectionStatusRequest and cannot be null");
            }
            this.KullaniciSicili = kullaniciSicili;
            this.OdemeAraciReferansNo = odemeAraciReferansNo;
            this.AcikHesapReferansNo = acikHesapReferansNo;
            this.OdemeAraciTipi = odemeAraciTipi;
            this.TahsilatTarihi = tahsilatTarihi;
            this.TahsilatDurumu = tahsilatDurumu;
            this.TahsilatAlinanKimlikTip = tahsilatAlinanKimlikTip;
            this.TahsilatAlinanKimlikNo = tahsilatAlinanKimlikNo;
            this.TahsilatAlinanUnvan = tahsilatAlinanUnvan;
        }

        /// <summary>
        /// Gets or Sets KullaniciSicili
        /// </summary>
        [DataMember(Name = "kullaniciSicili", IsRequired = true, EmitDefaultValue = true)]
        public string KullaniciSicili { get; set; }

        /// <summary>
        /// Gets or Sets OdemeAraciReferansNo
        /// </summary>
        [DataMember(Name = "odemeAraciReferansNo", EmitDefaultValue = true)]
        public string OdemeAraciReferansNo { get; set; }

        /// <summary>
        /// Gets or Sets AcikHesapReferansNo
        /// </summary>
        [DataMember(Name = "acikHesapReferansNo", EmitDefaultValue = true)]
        public string AcikHesapReferansNo { get; set; }

        /// <summary>
        /// Gets or Sets OdemeAraciTipi
        /// </summary>
        [DataMember(Name = "odemeAraciTipi", EmitDefaultValue = true)]
        public string OdemeAraciTipi { get; set; }

        /// <summary>
        /// Gets or Sets TahsilatTarihi
        /// </summary>
        [DataMember(Name = "tahsilatTarihi", EmitDefaultValue = true)]
        public string TahsilatTarihi { get; set; }

        /// <summary>
        /// Gets or Sets TahsilatDurumu
        /// </summary>
        [DataMember(Name = "tahsilatDurumu", EmitDefaultValue = true)]
        public string TahsilatDurumu { get; set; }

        /// <summary>
        /// Gets or Sets TahsilatAlinanKimlikTip
        /// </summary>
        [DataMember(Name = "tahsilatAlinanKimlikTip", EmitDefaultValue = true)]
        public string TahsilatAlinanKimlikTip { get; set; }

        /// <summary>
        /// Gets or Sets TahsilatAlinanKimlikNo
        /// </summary>
        [DataMember(Name = "tahsilatAlinanKimlikNo", EmitDefaultValue = true)]
        public string TahsilatAlinanKimlikNo { get; set; }

        /// <summary>
        /// Gets or Sets TahsilatAlinanUnvan
        /// </summary>
        [DataMember(Name = "tahsilatAlinanUnvan", EmitDefaultValue = true)]
        public string TahsilatAlinanUnvan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfksUpdateCollectionStatusRequest {\n");
            sb.Append("  KullaniciSicili: ").Append(KullaniciSicili).Append("\n");
            sb.Append("  OdemeAraciReferansNo: ").Append(OdemeAraciReferansNo).Append("\n");
            sb.Append("  AcikHesapReferansNo: ").Append(AcikHesapReferansNo).Append("\n");
            sb.Append("  OdemeAraciTipi: ").Append(OdemeAraciTipi).Append("\n");
            sb.Append("  TahsilatTarihi: ").Append(TahsilatTarihi).Append("\n");
            sb.Append("  TahsilatDurumu: ").Append(TahsilatDurumu).Append("\n");
            sb.Append("  TahsilatAlinanKimlikTip: ").Append(TahsilatAlinanKimlikTip).Append("\n");
            sb.Append("  TahsilatAlinanKimlikNo: ").Append(TahsilatAlinanKimlikNo).Append("\n");
            sb.Append("  TahsilatAlinanUnvan: ").Append(TahsilatAlinanUnvan).Append("\n");
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
            // KullaniciSicili (string) minLength
            if (this.KullaniciSicili != null && this.KullaniciSicili.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for KullaniciSicili, length must be greater than 1.", new [] { "KullaniciSicili" });
            }

            yield break;
        }
    }

}
