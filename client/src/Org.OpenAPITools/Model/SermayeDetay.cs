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
    /// SermayeDetay
    /// </summary>
    [DataContract(Name = "SermayeDetay")]
    public partial class SermayeDetay : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SermayeDetay" /> class.
        /// </summary>
        /// <param name="ortakAdi">ortakAdi.</param>
        /// <param name="tcKimlikNo">tcKimlikNo.</param>
        /// <param name="vergiNo">vergiNo.</param>
        /// <param name="namaYaziliHisseAdedi">namaYaziliHisseAdedi.</param>
        /// <param name="ortaginToplamSermayesi">ortaginToplamSermayesi.</param>
        /// <param name="sirketinToplamSermayesi">sirketinToplamSermayesi.</param>
        public SermayeDetay(string ortakAdi = default(string), string tcKimlikNo = default(string), string vergiNo = default(string), string namaYaziliHisseAdedi = default(string), string ortaginToplamSermayesi = default(string), string sirketinToplamSermayesi = default(string))
        {
            this.OrtakAdi = ortakAdi;
            this.TcKimlikNo = tcKimlikNo;
            this.VergiNo = vergiNo;
            this.NamaYaziliHisseAdedi = namaYaziliHisseAdedi;
            this.OrtaginToplamSermayesi = ortaginToplamSermayesi;
            this.SirketinToplamSermayesi = sirketinToplamSermayesi;
        }

        /// <summary>
        /// Gets or Sets OrtakAdi
        /// </summary>
        [DataMember(Name = "ortakAdi", EmitDefaultValue = true)]
        public string OrtakAdi { get; set; }

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
        /// Gets or Sets NamaYaziliHisseAdedi
        /// </summary>
        [DataMember(Name = "namaYaziliHisseAdedi", EmitDefaultValue = true)]
        public string NamaYaziliHisseAdedi { get; set; }

        /// <summary>
        /// Gets or Sets OrtaginToplamSermayesi
        /// </summary>
        [DataMember(Name = "ortaginToplamSermayesi", EmitDefaultValue = true)]
        public string OrtaginToplamSermayesi { get; set; }

        /// <summary>
        /// Gets or Sets SirketinToplamSermayesi
        /// </summary>
        [DataMember(Name = "sirketinToplamSermayesi", EmitDefaultValue = true)]
        public string SirketinToplamSermayesi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SermayeDetay {\n");
            sb.Append("  OrtakAdi: ").Append(OrtakAdi).Append("\n");
            sb.Append("  TcKimlikNo: ").Append(TcKimlikNo).Append("\n");
            sb.Append("  VergiNo: ").Append(VergiNo).Append("\n");
            sb.Append("  NamaYaziliHisseAdedi: ").Append(NamaYaziliHisseAdedi).Append("\n");
            sb.Append("  OrtaginToplamSermayesi: ").Append(OrtaginToplamSermayesi).Append("\n");
            sb.Append("  SirketinToplamSermayesi: ").Append(SirketinToplamSermayesi).Append("\n");
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