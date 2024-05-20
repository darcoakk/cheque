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
    /// MfksDevirEkleFaturaEkGirdiParametre
    /// </summary>
    [DataContract(Name = "MfksDevirEkleFaturaEkGirdiParametre")]
    public partial class MfksDevirEkleFaturaEkGirdiParametre : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksDevirEkleFaturaEkGirdiParametre" /> class.
        /// </summary>
        /// <param name="gumrukBeyannameNo">gumrukBeyannameNo.</param>
        /// <param name="konsimentoNumarasi">konsimentoNumarasi.</param>
        /// <param name="yuklemeTarihi">yuklemeTarihi.</param>
        /// <param name="muhabirUnvan">muhabirUnvan.</param>
        /// <param name="sigortaSirketiUnvan">sigortaSirketiUnvan.</param>
        /// <param name="irsaliyeNumarasi">irsaliyeNumarasi.</param>
        /// <param name="irsaliyeTarihi">irsaliyeTarihi.</param>
        /// <param name="imalatciVergiNo">imalatciVergiNo.</param>
        /// <param name="faturaTipi">faturaTipi.</param>
        /// <param name="eFaturaHashDegeri">eFaturaHashDegeri.</param>
        /// <param name="faturaXml">faturaXml.</param>
        /// <param name="faturamParaId">faturamParaId.</param>
        /// <param name="toplamTutar">toplamTutar.</param>
        /// <param name="numuneFaturaMi">numuneFaturaMi.</param>
        /// <param name="gtbOnayliFaturaMi">gtbOnayliFaturaMi.</param>
        /// <param name="disTicaretGumrukKimlikTip">disTicaretGumrukKimlikTip.</param>
        /// <param name="disTicaretGumrukKimlikNo">disTicaretGumrukKimlikNo.</param>
        /// <param name="disTicaretGumrukUnvan">disTicaretGumrukUnvan.</param>
        public MfksDevirEkleFaturaEkGirdiParametre(string gumrukBeyannameNo = default(string), string konsimentoNumarasi = default(string), string yuklemeTarihi = default(string), string muhabirUnvan = default(string), string sigortaSirketiUnvan = default(string), string irsaliyeNumarasi = default(string), string irsaliyeTarihi = default(string), string imalatciVergiNo = default(string), string faturaTipi = default(string), string eFaturaHashDegeri = default(string), byte[] faturaXml = default(byte[]), string faturamParaId = default(string), double toplamTutar = default(double), string numuneFaturaMi = default(string), string gtbOnayliFaturaMi = default(string), string disTicaretGumrukKimlikTip = default(string), string disTicaretGumrukKimlikNo = default(string), string disTicaretGumrukUnvan = default(string))
        {
            this.GumrukBeyannameNo = gumrukBeyannameNo;
            this.KonsimentoNumarasi = konsimentoNumarasi;
            this.YuklemeTarihi = yuklemeTarihi;
            this.MuhabirUnvan = muhabirUnvan;
            this.SigortaSirketiUnvan = sigortaSirketiUnvan;
            this.IrsaliyeNumarasi = irsaliyeNumarasi;
            this.IrsaliyeTarihi = irsaliyeTarihi;
            this.ImalatciVergiNo = imalatciVergiNo;
            this.FaturaTipi = faturaTipi;
            this.EFaturaHashDegeri = eFaturaHashDegeri;
            this.FaturaXml = faturaXml;
            this.FaturamParaId = faturamParaId;
            this.ToplamTutar = toplamTutar;
            this.NumuneFaturaMi = numuneFaturaMi;
            this.GtbOnayliFaturaMi = gtbOnayliFaturaMi;
            this.DisTicaretGumrukKimlikTip = disTicaretGumrukKimlikTip;
            this.DisTicaretGumrukKimlikNo = disTicaretGumrukKimlikNo;
            this.DisTicaretGumrukUnvan = disTicaretGumrukUnvan;
        }

        /// <summary>
        /// Gets or Sets GumrukBeyannameNo
        /// </summary>
        [DataMember(Name = "gumrukBeyannameNo", EmitDefaultValue = true)]
        public string GumrukBeyannameNo { get; set; }

        /// <summary>
        /// Gets or Sets KonsimentoNumarasi
        /// </summary>
        [DataMember(Name = "konsimentoNumarasi", EmitDefaultValue = true)]
        public string KonsimentoNumarasi { get; set; }

        /// <summary>
        /// Gets or Sets YuklemeTarihi
        /// </summary>
        [DataMember(Name = "yuklemeTarihi", EmitDefaultValue = true)]
        public string YuklemeTarihi { get; set; }

        /// <summary>
        /// Gets or Sets MuhabirUnvan
        /// </summary>
        [DataMember(Name = "muhabirUnvan", EmitDefaultValue = true)]
        public string MuhabirUnvan { get; set; }

        /// <summary>
        /// Gets or Sets SigortaSirketiUnvan
        /// </summary>
        [DataMember(Name = "sigortaSirketiUnvan", EmitDefaultValue = true)]
        public string SigortaSirketiUnvan { get; set; }

        /// <summary>
        /// Gets or Sets IrsaliyeNumarasi
        /// </summary>
        [DataMember(Name = "irsaliyeNumarasi", EmitDefaultValue = true)]
        public string IrsaliyeNumarasi { get; set; }

        /// <summary>
        /// Gets or Sets IrsaliyeTarihi
        /// </summary>
        [DataMember(Name = "irsaliyeTarihi", EmitDefaultValue = true)]
        public string IrsaliyeTarihi { get; set; }

        /// <summary>
        /// Gets or Sets ImalatciVergiNo
        /// </summary>
        [DataMember(Name = "imalatciVergiNo", EmitDefaultValue = true)]
        public string ImalatciVergiNo { get; set; }

        /// <summary>
        /// Gets or Sets FaturaTipi
        /// </summary>
        [DataMember(Name = "faturaTipi", EmitDefaultValue = true)]
        public string FaturaTipi { get; set; }

        /// <summary>
        /// Gets or Sets EFaturaHashDegeri
        /// </summary>
        [DataMember(Name = "eFaturaHashDegeri", EmitDefaultValue = true)]
        public string EFaturaHashDegeri { get; set; }

        /// <summary>
        /// Gets or Sets FaturaXml
        /// </summary>
        [DataMember(Name = "faturaXml", EmitDefaultValue = true)]
        public byte[] FaturaXml { get; set; }

        /// <summary>
        /// Gets or Sets FaturamParaId
        /// </summary>
        [DataMember(Name = "faturamParaId", EmitDefaultValue = true)]
        public string FaturamParaId { get; set; }

        /// <summary>
        /// Gets or Sets ToplamTutar
        /// </summary>
        [DataMember(Name = "toplamTutar", EmitDefaultValue = false)]
        public double ToplamTutar { get; set; }

        /// <summary>
        /// Gets or Sets NumuneFaturaMi
        /// </summary>
        [DataMember(Name = "numuneFaturaMi", EmitDefaultValue = true)]
        public string NumuneFaturaMi { get; set; }

        /// <summary>
        /// Gets or Sets GtbOnayliFaturaMi
        /// </summary>
        [DataMember(Name = "gtbOnayliFaturaMi", EmitDefaultValue = true)]
        public string GtbOnayliFaturaMi { get; set; }

        /// <summary>
        /// Gets or Sets DisTicaretGumrukKimlikTip
        /// </summary>
        [DataMember(Name = "disTicaretGumrukKimlikTip", EmitDefaultValue = true)]
        public string DisTicaretGumrukKimlikTip { get; set; }

        /// <summary>
        /// Gets or Sets DisTicaretGumrukKimlikNo
        /// </summary>
        [DataMember(Name = "disTicaretGumrukKimlikNo", EmitDefaultValue = true)]
        public string DisTicaretGumrukKimlikNo { get; set; }

        /// <summary>
        /// Gets or Sets DisTicaretGumrukUnvan
        /// </summary>
        [DataMember(Name = "disTicaretGumrukUnvan", EmitDefaultValue = true)]
        public string DisTicaretGumrukUnvan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfksDevirEkleFaturaEkGirdiParametre {\n");
            sb.Append("  GumrukBeyannameNo: ").Append(GumrukBeyannameNo).Append("\n");
            sb.Append("  KonsimentoNumarasi: ").Append(KonsimentoNumarasi).Append("\n");
            sb.Append("  YuklemeTarihi: ").Append(YuklemeTarihi).Append("\n");
            sb.Append("  MuhabirUnvan: ").Append(MuhabirUnvan).Append("\n");
            sb.Append("  SigortaSirketiUnvan: ").Append(SigortaSirketiUnvan).Append("\n");
            sb.Append("  IrsaliyeNumarasi: ").Append(IrsaliyeNumarasi).Append("\n");
            sb.Append("  IrsaliyeTarihi: ").Append(IrsaliyeTarihi).Append("\n");
            sb.Append("  ImalatciVergiNo: ").Append(ImalatciVergiNo).Append("\n");
            sb.Append("  FaturaTipi: ").Append(FaturaTipi).Append("\n");
            sb.Append("  EFaturaHashDegeri: ").Append(EFaturaHashDegeri).Append("\n");
            sb.Append("  FaturaXml: ").Append(FaturaXml).Append("\n");
            sb.Append("  FaturamParaId: ").Append(FaturamParaId).Append("\n");
            sb.Append("  ToplamTutar: ").Append(ToplamTutar).Append("\n");
            sb.Append("  NumuneFaturaMi: ").Append(NumuneFaturaMi).Append("\n");
            sb.Append("  GtbOnayliFaturaMi: ").Append(GtbOnayliFaturaMi).Append("\n");
            sb.Append("  DisTicaretGumrukKimlikTip: ").Append(DisTicaretGumrukKimlikTip).Append("\n");
            sb.Append("  DisTicaretGumrukKimlikNo: ").Append(DisTicaretGumrukKimlikNo).Append("\n");
            sb.Append("  DisTicaretGumrukUnvan: ").Append(DisTicaretGumrukUnvan).Append("\n");
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