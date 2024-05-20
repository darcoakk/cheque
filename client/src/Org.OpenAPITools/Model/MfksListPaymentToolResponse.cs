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
    /// MfksListPaymentToolResponse
    /// </summary>
    [DataContract(Name = "MfksListPaymentToolResponse")]
    public partial class MfksListPaymentToolResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfksListPaymentToolResponse" /> class.
        /// </summary>
        /// <param name="islemSonucu">islemSonucu.</param>
        /// <param name="islemSonucuAciklama">islemSonucuAciklama.</param>
        /// <param name="islemReferansNo">islemReferansNo.</param>
        /// <param name="uyariHataListe">uyariHataListe.</param>
        /// <param name="toplamKayitSayisi">toplamKayitSayisi.</param>
        /// <param name="maksimumAralikSayisi">maksimumAralikSayisi.</param>
        /// <param name="birAraliktakiMaksimumKayitSayisi">birAraliktakiMaksimumKayitSayisi.</param>
        /// <param name="senetListe">senetListe.</param>
        /// <param name="policeListe">policeListe.</param>
        /// <param name="acikHesapListe">acikHesapListe.</param>
        public MfksListPaymentToolResponse(string islemSonucu = default(string), string islemSonucuAciklama = default(string), string islemReferansNo = default(string), List<MfksUyariHataListeDevGunc> uyariHataListe = default(List<MfksUyariHataListeDevGunc>), Object toplamKayitSayisi = default(Object), Object maksimumAralikSayisi = default(Object), Object birAraliktakiMaksimumKayitSayisi = default(Object), List<Object> senetListe = default(List<Object>), List<Object> policeListe = default(List<Object>), List<Object> acikHesapListe = default(List<Object>))
        {
            this.IslemSonucu = islemSonucu;
            this.IslemSonucuAciklama = islemSonucuAciklama;
            this.IslemReferansNo = islemReferansNo;
            this.UyariHataListe = uyariHataListe;
            this.ToplamKayitSayisi = toplamKayitSayisi;
            this.MaksimumAralikSayisi = maksimumAralikSayisi;
            this.BirAraliktakiMaksimumKayitSayisi = birAraliktakiMaksimumKayitSayisi;
            this.SenetListe = senetListe;
            this.PoliceListe = policeListe;
            this.AcikHesapListe = acikHesapListe;
        }

        /// <summary>
        /// Gets or Sets IslemSonucu
        /// </summary>
        [DataMember(Name = "islemSonucu", EmitDefaultValue = true)]
        public string IslemSonucu { get; set; }

        /// <summary>
        /// Gets or Sets IslemSonucuAciklama
        /// </summary>
        [DataMember(Name = "islemSonucuAciklama", EmitDefaultValue = true)]
        public string IslemSonucuAciklama { get; set; }

        /// <summary>
        /// Gets or Sets IslemReferansNo
        /// </summary>
        [DataMember(Name = "islemReferansNo", EmitDefaultValue = true)]
        public string IslemReferansNo { get; set; }

        /// <summary>
        /// Gets or Sets UyariHataListe
        /// </summary>
        [DataMember(Name = "uyariHataListe", EmitDefaultValue = true)]
        public List<MfksUyariHataListeDevGunc> UyariHataListe { get; set; }

        /// <summary>
        /// Gets or Sets ToplamKayitSayisi
        /// </summary>
        [DataMember(Name = "toplamKayitSayisi", EmitDefaultValue = true)]
        public Object ToplamKayitSayisi { get; set; }

        /// <summary>
        /// Gets or Sets MaksimumAralikSayisi
        /// </summary>
        [DataMember(Name = "maksimumAralikSayisi", EmitDefaultValue = true)]
        public Object MaksimumAralikSayisi { get; set; }

        /// <summary>
        /// Gets or Sets BirAraliktakiMaksimumKayitSayisi
        /// </summary>
        [DataMember(Name = "birAraliktakiMaksimumKayitSayisi", EmitDefaultValue = true)]
        public Object BirAraliktakiMaksimumKayitSayisi { get; set; }

        /// <summary>
        /// Gets or Sets SenetListe
        /// </summary>
        [DataMember(Name = "senetListe", EmitDefaultValue = true)]
        public List<Object> SenetListe { get; set; }

        /// <summary>
        /// Gets or Sets PoliceListe
        /// </summary>
        [DataMember(Name = "policeListe", EmitDefaultValue = true)]
        public List<Object> PoliceListe { get; set; }

        /// <summary>
        /// Gets or Sets AcikHesapListe
        /// </summary>
        [DataMember(Name = "acikHesapListe", EmitDefaultValue = true)]
        public List<Object> AcikHesapListe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MfksListPaymentToolResponse {\n");
            sb.Append("  IslemSonucu: ").Append(IslemSonucu).Append("\n");
            sb.Append("  IslemSonucuAciklama: ").Append(IslemSonucuAciklama).Append("\n");
            sb.Append("  IslemReferansNo: ").Append(IslemReferansNo).Append("\n");
            sb.Append("  UyariHataListe: ").Append(UyariHataListe).Append("\n");
            sb.Append("  ToplamKayitSayisi: ").Append(ToplamKayitSayisi).Append("\n");
            sb.Append("  MaksimumAralikSayisi: ").Append(MaksimumAralikSayisi).Append("\n");
            sb.Append("  BirAraliktakiMaksimumKayitSayisi: ").Append(BirAraliktakiMaksimumKayitSayisi).Append("\n");
            sb.Append("  SenetListe: ").Append(SenetListe).Append("\n");
            sb.Append("  PoliceListe: ").Append(PoliceListe).Append("\n");
            sb.Append("  AcikHesapListe: ").Append(AcikHesapListe).Append("\n");
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
