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
    /// RiskRaporuTicariVysBilgi
    /// </summary>
    [DataContract(Name = "RiskRaporuTicariVysBilgi")]
    public partial class RiskRaporuTicariVysBilgi : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskRaporuTicariVysBilgi" /> class.
        /// </summary>
        /// <param name="vysUyeKodu">vysUyeKodu.</param>
        /// <param name="vysUyeRumuzu">vysUyeRumuzu.</param>
        /// <param name="vysReferansNumarasi">vysReferansNumarasi.</param>
        /// <param name="vysAcilisTarihi">vysAcilisTarihi.</param>
        /// <param name="vysBorcDurum">vysBorcDurum.</param>
        /// <param name="vysKapanisTarihi">vysKapanisTarihi.</param>
        /// <param name="vysSonGuncellemeTarihi">vysSonGuncellemeTarihi.</param>
        /// <param name="vysKalanBorc">vysKalanBorc.</param>
        /// <param name="vysDovizKodu">vysDovizKodu.</param>
        /// <param name="vysTemlikAlinanToplamDevirAdedi">vysTemlikAlinanToplamDevirAdedi.</param>
        /// <param name="vysDevirAlinanFarkliUyeAdedi">vysDevirAlinanFarkliUyeAdedi.</param>
        /// <param name="vysToplamDevirBakiyeAnaPara">vysToplamDevirBakiyeAnaPara.</param>
        public RiskRaporuTicariVysBilgi(string vysUyeKodu = default(string), string vysUyeRumuzu = default(string), string vysReferansNumarasi = default(string), string vysAcilisTarihi = default(string), string vysBorcDurum = default(string), string vysKapanisTarihi = default(string), string vysSonGuncellemeTarihi = default(string), string vysKalanBorc = default(string), string vysDovizKodu = default(string), int vysTemlikAlinanToplamDevirAdedi = default(int), int vysDevirAlinanFarkliUyeAdedi = default(int), string vysToplamDevirBakiyeAnaPara = default(string))
        {
            this.VysUyeKodu = vysUyeKodu;
            this.VysUyeRumuzu = vysUyeRumuzu;
            this.VysReferansNumarasi = vysReferansNumarasi;
            this.VysAcilisTarihi = vysAcilisTarihi;
            this.VysBorcDurum = vysBorcDurum;
            this.VysKapanisTarihi = vysKapanisTarihi;
            this.VysSonGuncellemeTarihi = vysSonGuncellemeTarihi;
            this.VysKalanBorc = vysKalanBorc;
            this.VysDovizKodu = vysDovizKodu;
            this.VysTemlikAlinanToplamDevirAdedi = vysTemlikAlinanToplamDevirAdedi;
            this.VysDevirAlinanFarkliUyeAdedi = vysDevirAlinanFarkliUyeAdedi;
            this.VysToplamDevirBakiyeAnaPara = vysToplamDevirBakiyeAnaPara;
        }

        /// <summary>
        /// Gets or Sets VysUyeKodu
        /// </summary>
        [DataMember(Name = "vysUyeKodu", EmitDefaultValue = true)]
        public string VysUyeKodu { get; set; }

        /// <summary>
        /// Gets or Sets VysUyeRumuzu
        /// </summary>
        [DataMember(Name = "vysUyeRumuzu", EmitDefaultValue = true)]
        public string VysUyeRumuzu { get; set; }

        /// <summary>
        /// Gets or Sets VysReferansNumarasi
        /// </summary>
        [DataMember(Name = "vysReferansNumarasi", EmitDefaultValue = true)]
        public string VysReferansNumarasi { get; set; }

        /// <summary>
        /// Gets or Sets VysAcilisTarihi
        /// </summary>
        [DataMember(Name = "vysAcilisTarihi", EmitDefaultValue = true)]
        public string VysAcilisTarihi { get; set; }

        /// <summary>
        /// Gets or Sets VysBorcDurum
        /// </summary>
        [DataMember(Name = "vysBorcDurum", EmitDefaultValue = true)]
        public string VysBorcDurum { get; set; }

        /// <summary>
        /// Gets or Sets VysKapanisTarihi
        /// </summary>
        [DataMember(Name = "vysKapanisTarihi", EmitDefaultValue = true)]
        public string VysKapanisTarihi { get; set; }

        /// <summary>
        /// Gets or Sets VysSonGuncellemeTarihi
        /// </summary>
        [DataMember(Name = "vysSonGuncellemeTarihi", EmitDefaultValue = true)]
        public string VysSonGuncellemeTarihi { get; set; }

        /// <summary>
        /// Gets or Sets VysKalanBorc
        /// </summary>
        [DataMember(Name = "vysKalanBorc", EmitDefaultValue = true)]
        public string VysKalanBorc { get; set; }

        /// <summary>
        /// Gets or Sets VysDovizKodu
        /// </summary>
        [DataMember(Name = "vysDovizKodu", EmitDefaultValue = true)]
        public string VysDovizKodu { get; set; }

        /// <summary>
        /// Gets or Sets VysTemlikAlinanToplamDevirAdedi
        /// </summary>
        [DataMember(Name = "vysTemlikAlinanToplamDevirAdedi", EmitDefaultValue = false)]
        public int VysTemlikAlinanToplamDevirAdedi { get; set; }

        /// <summary>
        /// Gets or Sets VysDevirAlinanFarkliUyeAdedi
        /// </summary>
        [DataMember(Name = "vysDevirAlinanFarkliUyeAdedi", EmitDefaultValue = false)]
        public int VysDevirAlinanFarkliUyeAdedi { get; set; }

        /// <summary>
        /// Gets or Sets VysToplamDevirBakiyeAnaPara
        /// </summary>
        [DataMember(Name = "vysToplamDevirBakiyeAnaPara", EmitDefaultValue = true)]
        public string VysToplamDevirBakiyeAnaPara { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RiskRaporuTicariVysBilgi {\n");
            sb.Append("  VysUyeKodu: ").Append(VysUyeKodu).Append("\n");
            sb.Append("  VysUyeRumuzu: ").Append(VysUyeRumuzu).Append("\n");
            sb.Append("  VysReferansNumarasi: ").Append(VysReferansNumarasi).Append("\n");
            sb.Append("  VysAcilisTarihi: ").Append(VysAcilisTarihi).Append("\n");
            sb.Append("  VysBorcDurum: ").Append(VysBorcDurum).Append("\n");
            sb.Append("  VysKapanisTarihi: ").Append(VysKapanisTarihi).Append("\n");
            sb.Append("  VysSonGuncellemeTarihi: ").Append(VysSonGuncellemeTarihi).Append("\n");
            sb.Append("  VysKalanBorc: ").Append(VysKalanBorc).Append("\n");
            sb.Append("  VysDovizKodu: ").Append(VysDovizKodu).Append("\n");
            sb.Append("  VysTemlikAlinanToplamDevirAdedi: ").Append(VysTemlikAlinanToplamDevirAdedi).Append("\n");
            sb.Append("  VysDevirAlinanFarkliUyeAdedi: ").Append(VysDevirAlinanFarkliUyeAdedi).Append("\n");
            sb.Append("  VysToplamDevirBakiyeAnaPara: ").Append(VysToplamDevirBakiyeAnaPara).Append("\n");
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
