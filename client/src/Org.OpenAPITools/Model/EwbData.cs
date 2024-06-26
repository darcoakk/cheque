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
    /// EwbData
    /// </summary>
    [DataContract(Name = "EwbData")]
    public partial class EwbData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EwbData" /> class.
        /// </summary>
        /// <param name="firmaAdi">firmaAdi.</param>
        /// <param name="nakitKrediGecikmesiAktif">nakitKrediGecikmesiAktif.</param>
        /// <param name="nakitKrediGecikmesiToplam">nakitKrediGecikmesiToplam.</param>
        /// <param name="tmKomisyonGecikmesiAktif">tmKomisyonGecikmesiAktif.</param>
        /// <param name="tmKomisyonGecikmesiToplam">tmKomisyonGecikmesiToplam.</param>
        /// <param name="gayrinakdiKrediTanzimiAktif">gayrinakdiKrediTanzimiAktif.</param>
        /// <param name="gayrinakdiKrediTanzimiToplam">gayrinakdiKrediTanzimiToplam.</param>
        /// <param name="problemliMemzucKaydiToplam">problemliMemzucKaydiToplam.</param>
        /// <param name="memzucGelisimiToplam">memzucGelisimiToplam.</param>
        /// <param name="sakincaliFirmaKaydiToplam">sakincaliFirmaKaydiToplam.</param>
        /// <param name="limitAsimiToplam">limitAsimiToplam.</param>
        /// <param name="limitDoluluguToplam">limitDoluluguToplam.</param>
        /// <param name="depodanIadeEdilenTeminatCekleriToplam">depodanIadeEdilenTeminatCekleriToplam.</param>
        public EwbData(string firmaAdi = default(string), string nakitKrediGecikmesiAktif = default(string), string nakitKrediGecikmesiToplam = default(string), string tmKomisyonGecikmesiAktif = default(string), string tmKomisyonGecikmesiToplam = default(string), string gayrinakdiKrediTanzimiAktif = default(string), string gayrinakdiKrediTanzimiToplam = default(string), string problemliMemzucKaydiToplam = default(string), string memzucGelisimiToplam = default(string), string sakincaliFirmaKaydiToplam = default(string), string limitAsimiToplam = default(string), string limitDoluluguToplam = default(string), string depodanIadeEdilenTeminatCekleriToplam = default(string))
        {
            this.FirmaAdi = firmaAdi;
            this.NakitKrediGecikmesiAktif = nakitKrediGecikmesiAktif;
            this.NakitKrediGecikmesiToplam = nakitKrediGecikmesiToplam;
            this.TmKomisyonGecikmesiAktif = tmKomisyonGecikmesiAktif;
            this.TmKomisyonGecikmesiToplam = tmKomisyonGecikmesiToplam;
            this.GayrinakdiKrediTanzimiAktif = gayrinakdiKrediTanzimiAktif;
            this.GayrinakdiKrediTanzimiToplam = gayrinakdiKrediTanzimiToplam;
            this.ProblemliMemzucKaydiToplam = problemliMemzucKaydiToplam;
            this.MemzucGelisimiToplam = memzucGelisimiToplam;
            this.SakincaliFirmaKaydiToplam = sakincaliFirmaKaydiToplam;
            this.LimitAsimiToplam = limitAsimiToplam;
            this.LimitDoluluguToplam = limitDoluluguToplam;
            this.DepodanIadeEdilenTeminatCekleriToplam = depodanIadeEdilenTeminatCekleriToplam;
        }

        /// <summary>
        /// Gets or Sets FirmaAdi
        /// </summary>
        [DataMember(Name = "FirmaAdi", EmitDefaultValue = true)]
        public string FirmaAdi { get; set; }

        /// <summary>
        /// Gets or Sets NakitKrediGecikmesiAktif
        /// </summary>
        [DataMember(Name = "NakitKrediGecikmesiAktif", EmitDefaultValue = true)]
        public string NakitKrediGecikmesiAktif { get; set; }

        /// <summary>
        /// Gets or Sets NakitKrediGecikmesiToplam
        /// </summary>
        [DataMember(Name = "NakitKrediGecikmesiToplam", EmitDefaultValue = true)]
        public string NakitKrediGecikmesiToplam { get; set; }

        /// <summary>
        /// Gets or Sets TmKomisyonGecikmesiAktif
        /// </summary>
        [DataMember(Name = "TmKomisyonGecikmesiAktif", EmitDefaultValue = true)]
        public string TmKomisyonGecikmesiAktif { get; set; }

        /// <summary>
        /// Gets or Sets TmKomisyonGecikmesiToplam
        /// </summary>
        [DataMember(Name = "TmKomisyonGecikmesiToplam", EmitDefaultValue = true)]
        public string TmKomisyonGecikmesiToplam { get; set; }

        /// <summary>
        /// Gets or Sets GayrinakdiKrediTanzimiAktif
        /// </summary>
        [DataMember(Name = "GayrinakdiKrediTanzimiAktif", EmitDefaultValue = true)]
        public string GayrinakdiKrediTanzimiAktif { get; set; }

        /// <summary>
        /// Gets or Sets GayrinakdiKrediTanzimiToplam
        /// </summary>
        [DataMember(Name = "GayrinakdiKrediTanzimiToplam", EmitDefaultValue = true)]
        public string GayrinakdiKrediTanzimiToplam { get; set; }

        /// <summary>
        /// Gets or Sets ProblemliMemzucKaydiToplam
        /// </summary>
        [DataMember(Name = "ProblemliMemzucKaydiToplam", EmitDefaultValue = true)]
        public string ProblemliMemzucKaydiToplam { get; set; }

        /// <summary>
        /// Gets or Sets MemzucGelisimiToplam
        /// </summary>
        [DataMember(Name = "MemzucGelisimiToplam", EmitDefaultValue = true)]
        public string MemzucGelisimiToplam { get; set; }

        /// <summary>
        /// Gets or Sets SakincaliFirmaKaydiToplam
        /// </summary>
        [DataMember(Name = "SakincaliFirmaKaydiToplam", EmitDefaultValue = true)]
        public string SakincaliFirmaKaydiToplam { get; set; }

        /// <summary>
        /// Gets or Sets LimitAsimiToplam
        /// </summary>
        [DataMember(Name = "LimitAsimiToplam", EmitDefaultValue = true)]
        public string LimitAsimiToplam { get; set; }

        /// <summary>
        /// Gets or Sets LimitDoluluguToplam
        /// </summary>
        [DataMember(Name = "LimitDoluluguToplam", EmitDefaultValue = true)]
        public string LimitDoluluguToplam { get; set; }

        /// <summary>
        /// Gets or Sets DepodanIadeEdilenTeminatCekleriToplam
        /// </summary>
        [DataMember(Name = "DepodanIadeEdilenTeminatCekleriToplam", EmitDefaultValue = true)]
        public string DepodanIadeEdilenTeminatCekleriToplam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EwbData {\n");
            sb.Append("  FirmaAdi: ").Append(FirmaAdi).Append("\n");
            sb.Append("  NakitKrediGecikmesiAktif: ").Append(NakitKrediGecikmesiAktif).Append("\n");
            sb.Append("  NakitKrediGecikmesiToplam: ").Append(NakitKrediGecikmesiToplam).Append("\n");
            sb.Append("  TmKomisyonGecikmesiAktif: ").Append(TmKomisyonGecikmesiAktif).Append("\n");
            sb.Append("  TmKomisyonGecikmesiToplam: ").Append(TmKomisyonGecikmesiToplam).Append("\n");
            sb.Append("  GayrinakdiKrediTanzimiAktif: ").Append(GayrinakdiKrediTanzimiAktif).Append("\n");
            sb.Append("  GayrinakdiKrediTanzimiToplam: ").Append(GayrinakdiKrediTanzimiToplam).Append("\n");
            sb.Append("  ProblemliMemzucKaydiToplam: ").Append(ProblemliMemzucKaydiToplam).Append("\n");
            sb.Append("  MemzucGelisimiToplam: ").Append(MemzucGelisimiToplam).Append("\n");
            sb.Append("  SakincaliFirmaKaydiToplam: ").Append(SakincaliFirmaKaydiToplam).Append("\n");
            sb.Append("  LimitAsimiToplam: ").Append(LimitAsimiToplam).Append("\n");
            sb.Append("  LimitDoluluguToplam: ").Append(LimitDoluluguToplam).Append("\n");
            sb.Append("  DepodanIadeEdilenTeminatCekleriToplam: ").Append(DepodanIadeEdilenTeminatCekleriToplam).Append("\n");
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
