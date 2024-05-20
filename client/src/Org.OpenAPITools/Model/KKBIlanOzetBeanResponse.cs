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
    /// KKBIlanOzetBeanResponse
    /// </summary>
    [DataContract(Name = "KKBIlanOzetBeanResponse")]
    public partial class KKBIlanOzetBeanResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KKBIlanOzetBeanResponse" /> class.
        /// </summary>
        /// <param name="ilanNo">ilanNo.</param>
        /// <param name="gazeteTarihi">gazeteTarihi.</param>
        /// <param name="gazeteSayisi">gazeteSayisi.</param>
        /// <param name="gazeteSayfasi">gazeteSayfasi.</param>
        /// <param name="tcKimlikNo">tcKimlikNo.</param>
        /// <param name="vergiNo">vergiNo.</param>
        /// <param name="unvan">unvan.</param>
        /// <param name="hukukiYapi">hukukiYapi.</param>
        /// <param name="firmaTescilTarihi">firmaTescilTarihi.</param>
        /// <param name="firmaTescilIli">firmaTescilIli.</param>
        /// <param name="firmaTescilMerkezi">firmaTescilMerkezi.</param>
        /// <param name="vergiDairesi">vergiDairesi.</param>
        /// <param name="vergiDairesiIli">vergiDairesiIli.</param>
        public KKBIlanOzetBeanResponse(string ilanNo = default(string), string gazeteTarihi = default(string), string gazeteSayisi = default(string), string gazeteSayfasi = default(string), string tcKimlikNo = default(string), string vergiNo = default(string), string unvan = default(string), int hukukiYapi = default(int), string firmaTescilTarihi = default(string), int firmaTescilIli = default(int), int firmaTescilMerkezi = default(int), string vergiDairesi = default(string), string vergiDairesiIli = default(string))
        {
            this.IlanNo = ilanNo;
            this.GazeteTarihi = gazeteTarihi;
            this.GazeteSayisi = gazeteSayisi;
            this.GazeteSayfasi = gazeteSayfasi;
            this.TcKimlikNo = tcKimlikNo;
            this.VergiNo = vergiNo;
            this.Unvan = unvan;
            this.HukukiYapi = hukukiYapi;
            this.FirmaTescilTarihi = firmaTescilTarihi;
            this.FirmaTescilIli = firmaTescilIli;
            this.FirmaTescilMerkezi = firmaTescilMerkezi;
            this.VergiDairesi = vergiDairesi;
            this.VergiDairesiIli = vergiDairesiIli;
        }

        /// <summary>
        /// Gets or Sets IlanNo
        /// </summary>
        [DataMember(Name = "ilanNo", EmitDefaultValue = true)]
        public string IlanNo { get; set; }

        /// <summary>
        /// Gets or Sets GazeteTarihi
        /// </summary>
        [DataMember(Name = "gazeteTarihi", EmitDefaultValue = true)]
        public string GazeteTarihi { get; set; }

        /// <summary>
        /// Gets or Sets GazeteSayisi
        /// </summary>
        [DataMember(Name = "gazeteSayisi", EmitDefaultValue = true)]
        public string GazeteSayisi { get; set; }

        /// <summary>
        /// Gets or Sets GazeteSayfasi
        /// </summary>
        [DataMember(Name = "gazeteSayfasi", EmitDefaultValue = true)]
        public string GazeteSayfasi { get; set; }

        /// <summary>
        /// Gets or Sets TcKimlikNo
        /// </summary>
        [DataMember(Name = "tcKimlikNo", EmitDefaultValue = true)]
        public string TcKimlikNo { get; set; }

        /// <summary>
        /// Gets or Sets VergiNo
        /// </summary>
        [DataMember(Name = "vergiNo", EmitDefaultValue = true)]
        public string VergiNo { get; set; }

        /// <summary>
        /// Gets or Sets Unvan
        /// </summary>
        [DataMember(Name = "unvan", EmitDefaultValue = true)]
        public string Unvan { get; set; }

        /// <summary>
        /// Gets or Sets HukukiYapi
        /// </summary>
        [DataMember(Name = "hukukiYapi", EmitDefaultValue = false)]
        public int HukukiYapi { get; set; }

        /// <summary>
        /// Gets or Sets FirmaTescilTarihi
        /// </summary>
        [DataMember(Name = "firmaTescilTarihi", EmitDefaultValue = true)]
        public string FirmaTescilTarihi { get; set; }

        /// <summary>
        /// Gets or Sets FirmaTescilIli
        /// </summary>
        [DataMember(Name = "firmaTescilIli", EmitDefaultValue = false)]
        public int FirmaTescilIli { get; set; }

        /// <summary>
        /// Gets or Sets FirmaTescilMerkezi
        /// </summary>
        [DataMember(Name = "firmaTescilMerkezi", EmitDefaultValue = false)]
        public int FirmaTescilMerkezi { get; set; }

        /// <summary>
        /// Gets or Sets VergiDairesi
        /// </summary>
        [DataMember(Name = "vergiDairesi", EmitDefaultValue = true)]
        public string VergiDairesi { get; set; }

        /// <summary>
        /// Gets or Sets VergiDairesiIli
        /// </summary>
        [DataMember(Name = "vergiDairesiIli", EmitDefaultValue = true)]
        public string VergiDairesiIli { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KKBIlanOzetBeanResponse {\n");
            sb.Append("  IlanNo: ").Append(IlanNo).Append("\n");
            sb.Append("  GazeteTarihi: ").Append(GazeteTarihi).Append("\n");
            sb.Append("  GazeteSayisi: ").Append(GazeteSayisi).Append("\n");
            sb.Append("  GazeteSayfasi: ").Append(GazeteSayfasi).Append("\n");
            sb.Append("  TcKimlikNo: ").Append(TcKimlikNo).Append("\n");
            sb.Append("  VergiNo: ").Append(VergiNo).Append("\n");
            sb.Append("  Unvan: ").Append(Unvan).Append("\n");
            sb.Append("  HukukiYapi: ").Append(HukukiYapi).Append("\n");
            sb.Append("  FirmaTescilTarihi: ").Append(FirmaTescilTarihi).Append("\n");
            sb.Append("  FirmaTescilIli: ").Append(FirmaTescilIli).Append("\n");
            sb.Append("  FirmaTescilMerkezi: ").Append(FirmaTescilMerkezi).Append("\n");
            sb.Append("  VergiDairesi: ").Append(VergiDairesi).Append("\n");
            sb.Append("  VergiDairesiIli: ").Append(VergiDairesiIli).Append("\n");
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