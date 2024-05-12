using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KKB
{
[XmlRoot(ElementName = "KKBChequeResponse")]
public class KKBChequeResponse
{
    [XmlElement(ElementName = "errors")]
    public Errors Errors { get; set; }

    [XmlElement(ElementName = "data")]
    public Data Data { get; set; }

    [XmlElement(ElementName = "CekAutomaticallyResult")]
    public CekAutomaticallyResult CekAutomaticallyResult { get; set; }
}

public class Errors
{
    [XmlElement(ElementName = "error")]
    public string Error { get; set; }

    [XmlElement(ElementName = "errorText")]
    public string ErrorText { get; set; }
}

public class Data
{
    [XmlElement(ElementName = "bankaList")]
    public BankaList BankaList { get; set; }

    [XmlElement(ElementName = "ihtiyatiTedbirliCekList")]
    public List<object> IhtiyatiTedbirliCekList { get; set; }  // Assuming empty list content

    [XmlElement(ElementName = "karsiliksizCekList")]
    public List<object> KarsiliksizCekList { get; set; }  // Assuming empty list content

    [XmlElement(ElementName = "kesideEdilenCekTutarList")]
    public List<KesideEdilenCekTutarlariResponse> KesideEdilenCekTutarList { get; set; }

    [XmlElement(ElementName = "sonCirantayaAitCekOzet")]
    public SonCirantayaAitCekOzet SonCirantayaAitCekOzet { get; set; }

    [XmlElement(ElementName = "vadeliCekOzetList")]
    public List<VadeliCekOzetResponse> VadeliCekOzetList { get; set; }
}

public class BankaList
{
    [XmlElement(ElementName = "cekHesabiOlanBankaResponse")]
    public List<CekHesabiOlanBankaResponse> CekHesabiOlanBankaResponses { get; set; }
}

public class CekHesabiOlanBankaResponse
{
    [XmlElement(ElementName = "kurumAdi")]
    public string KurumAdi { get; set; }
}

public class KesideEdilenCekTutarlariResponse
{
    [XmlElement(ElementName = "yil")]
    public int Yil { get; set; }

    [XmlElement(ElementName = "enDusukTutar")]
    public decimal EnDusukTutar { get; set; }

    [XmlElement(ElementName = "enYuksekTutar")]
    public decimal EnYuksekTutar { get; set; }

    [XmlElement(ElementName = "ortalamaCekTutari")]
    public decimal OrtalamaCekTutari { get; set; }
}

public class SonCirantayaAitCekOzet
{
    [XmlElement(ElementName = "son1AyTahsilEdilenCekTutar")]
    public decimal Son1AyTahsilEdilenCekTutar { get; set; }

    [XmlElement(ElementName = "son1AyKarsiliksizCekTutar")]
    public decimal Son1AyKarsiliksizCekTutar { get; set; }

    [XmlElement(ElementName = "son1AyOdenmiseDonenCekTutar")]
    public decimal Son1AyOdenmiseDonenCekTutar { get; set; }

    [XmlElement(ElementName = "son1AyTahsilEdilenCekTutariOran")]
    public decimal Son1AyTahsilEdilenCekTutariOran { get; set; }

    [XmlElement(ElementName = "son1AyOdenmiseDonenCekTutariOran")]
    public decimal Son1AyOdenmiseDonenCekTutariOran { get; set; }

    [XmlElement(ElementName = "son3AyTahsilEdilenCekTutar")]
    public decimal Son3AyTahsilEdilenCekTutar { get; set; }

    [XmlElement(ElementName = "son3AyKarsiliksizCekTutar")]
    public decimal Son3AyKarsiliksizCekTutar { get; set; }

    [XmlElement(ElementName = "son3AyOdenmiseDonenCekTutar")]
    public decimal Son3AyOdenmiseDonenCekTutar { get; set; }

    [XmlElement(ElementName = "son3AyTahsilEdilenCekTutariOran")]
    public decimal Son3AyTahsilEdilenCekTutariOran { get; set; }

    [XmlElement(ElementName = "son3AyOdenmiseDonenCekTutariOran")]
    public decimal Son3AyOdenmiseDonenCekTutariOran { get; set; }

    [XmlElement(ElementName = "son12AyTahsilEdilenCekTutar")]
    public decimal Son12AyTahsilEdilenCekTutar { get; set; }

    [XmlElement(ElementName = "son12AyKarsiliksizCekTutar")]
    public decimal Son12AyKarsiliksizCekTutar { get; set; }

    [XmlElement(ElementName = "son12AyOdenmiseDonenCekTutar")]
    public decimal Son12AyOdenmiseDonenCekTutar { get; set; }

    [XmlElement(ElementName = "son12AyTahsilEdilenCekTutariOran")]
    public decimal Son12AyTahsilEdilenCekTutariOran { get; set; }

    [XmlElement(ElementName = "son12AyOdenmiseDonenCekTutariOran")]
    public decimal Son12AyOdenmiseDonenCekTutariOran { get; set; }
}


public class VadeliCekOzetResponse
{
    [XmlElement(ElementName = "vadeliCekDonemi")]
    public int VadeliCekDonemi { get; set; }

    [XmlElement(ElementName = "vadeliToplamCekAdedi")]
    public int VadeliToplamCekAdedi { get; set; }

    [XmlElement(ElementName = "vadeliToplamCekTutari")]
    public decimal VadeliToplamCekTutari { get; set; }
}

public class CekAutomaticallyResult
{
    [XmlElement(ElementName = "CekAutoResult")]
    public CekAutoResult CekAutoResult { get; set; }
}

    public class CekAutoResult
    {
        [XmlElement(ElementName = "CekNo")]
        public string CekNo { get; set; }

        [XmlElement(ElementName = "AutomaticallyResult")]
        public int AutomaticallyResult { get; set; }

        // Additional properties based on your XML
        [XmlElement(ElementName = "kesidecison12AyOdenenCekTutari")]
        public decimal Kesidecison12AyOdenenCekTutari { get; set; }

        [XmlElement(ElementName = "musterimevcutkesidecektutar")]
        public decimal Musterimevcutkesidecektutar { get; set; }

        [XmlElement(ElementName = "CekTutar")]
        public decimal CekTutar { get; set; }

        [XmlElement(ElementName = "sonikiyilmaxtutar")]
        public decimal Sonikiyilmaxtutar { get; set; }

        [XmlElement(ElementName = "sonikiyilorttutar")]
        public decimal Sonikiyilorttutar { get; set; }

        [XmlElement(ElementName = "CekVade")]
        public DateTime CekVade { get; set; }

        [XmlElement(ElementName = "tedarikcifinansmanlimiti")]
        public decimal Tedarikcifinansmanlimiti { get; set; }

        [XmlElement(ElementName = "skor")]
        public int Skor { get; set; }
    }
}