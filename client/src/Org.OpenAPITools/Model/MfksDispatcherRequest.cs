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
    /// MfksDispatcherRequest
    /// </summary>
    [DataContract(Name = "MfksDispatcherRequest")]
    public partial class MfksDispatcherRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksDispatcherRequest" /> class.
        /// </summary>
        /// <param name="belgeBilgileri">belgeBilgileri.</param>
        /// <param name="surecNumarasi">surecNumarasi.</param>
        public MfksDispatcherRequest(List<BelgeBilgi> belgeBilgileri = default(List<BelgeBilgi>), int surecNumarasi = default(int))
        {
            this.BelgeBilgileri = belgeBilgileri;
            this.SurecNumarasi = surecNumarasi;
        }

        /// <summary>
        /// Gets or Sets BelgeBilgileri
        /// </summary>
        [DataMember(Name = "belgeBilgileri", EmitDefaultValue = true)]
        public List<BelgeBilgi> BelgeBilgileri { get; set; }

        /// <summary>
        /// Gets or Sets SurecNumarasi
        /// </summary>
        [DataMember(Name = "surecNumarasi", EmitDefaultValue = false)]
        public int SurecNumarasi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfksDispatcherRequest {\n");
            sb.Append("  BelgeBilgileri: ").Append(BelgeBilgileri).Append("\n");
            sb.Append("  SurecNumarasi: ").Append(SurecNumarasi).Append("\n");
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
